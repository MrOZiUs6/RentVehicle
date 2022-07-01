using RentVehicle.Forms.ForAdmin.Vehicles;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace RentVehicle.Forms.ForAdmin
{
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
            try
            {
                using (TSContext db = new TSContext())
                {
                    var vehicles = db.Vehicles.ToList();
                    DataGridFill(vehicles);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            try
            {
                using (TSContext db = new TSContext())
                {
                    foreach (Model models in db.Models)
                    {
                        modelTypeComboBox.Items.Add(models.ModelType);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private Vehicle SearchBySN(int sn)
        {
            using (TSContext db = new TSContext())
            {
                return db.Vehicles.FirstOrDefault(v => v.SerialNumber == sn);
            }
        }

        private void DataGridFill(List<Vehicle> vehicles)
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (TSContext db = new TSContext())
                {
                    var models = db.Models.ToList();
                    foreach (var v in vehicles)
                    {
                        var model = models.Where(m => m.IdModelType == v.IdModelType).FirstOrDefault();
                        dataGridView1.Rows.Add($"{v.SerialNumber}",
                            $"{model.ModelType}",
                            $"{v.LifeTime}",
                            $"{v.RentalPrice}",
                            "✎");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void VehicleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Authorization.IDRole == 1)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else if (Authorization.IDRole == 2)
            {
                EmployeeForm employeeForm = new EmployeeForm();
                employeeForm.Show();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                try
                {
                    using (TSContext db = new TSContext())
                    {
                        var vehicles = db.Vehicles.ToList();
                        DataGridFill(vehicles);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            };
            addVehicleForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                CMB cmb = new CMB();
                cmb.ShowDialog();
                try
                {
                    if (cmb.DialogResult.Equals(DialogResult.Yes))
                    {
                        using (TSContext db = new TSContext())
                        {
                            var vehicle = SearchBySN(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                            db.Vehicles.Remove(vehicle);
                            db.SaveChanges();
                            MessageBox.Show("Удаление прошло успешно", "EZДЖИ");
                            var vehicles = db.Vehicles.ToList();
                            DataGridFill(vehicles);
                        }
                    }
                    else if (cmb.DialogResult.Equals(DialogResult.No))
                    {
                        UpdateVehicleForm updateVehicleForm = new UpdateVehicleForm();
                        updateVehicleForm.Sn = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                        updateVehicleForm.modelTypeComboBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                        updateVehicleForm.lifeTimeTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                        updateVehicleForm.rentalPriceTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                        updateVehicleForm.FormClosed += (object s, FormClosedEventArgs args) =>
                        {
                            using (TSContext db = new TSContext())
                            {
                                var vehicles = db.Vehicles.ToList();
                                DataGridFill(vehicles);
                            }
                        };
                        updateVehicleForm.Show();
                    }
                    else return;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                try
                {
                    using (TSContext db = new TSContext())
                    {
                        var model = db.Models.FirstOrDefault(m => m.ModelType == dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());
                        MessageBox.Show($"Тип Модели - {model.ModelType}\n" +
                            $"Кол-во Колёс - {model.NumberOfWheels}\n" +
                            $"Кол-во Мест - {model.NumberOfSeats}\n" +
                            $"Размер Колёс - {model.WheelSize}\n" +
                            $"Тип Шин - {model.WheelType}\n" +
                            $"Тип Рамы - {model.FrameType}"
                            , "EZДЖИ");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }       
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var vehicles = db.Vehicles.ToList();
                    if (!string.IsNullOrEmpty(searchSNTextBox.Text))
                        vehicles = vehicles.Where(v => v.SerialNumber.ToString().Contains(searchSNTextBox.Text)).ToList();
                    if (!string.IsNullOrEmpty(searchRNTextBox.Text))
                        vehicles = vehicles.Where(v => v.RentalPrice.ToString().Contains(searchRNTextBox.Text)).ToList();
                    if (!string.IsNullOrEmpty(modelTypeComboBox.Text))
                        vehicles = vehicles.Where(v => v.IdModelType.ToString().Contains((modelTypeComboBox.SelectedIndex + 1).ToString())).ToList();
                    DataGridFill(vehicles);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Excel.Application application = new Excel.Application();
            application.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)application.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 2; j++)
                {
                    ws.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            application.Visible = true;
        }
    }
}

