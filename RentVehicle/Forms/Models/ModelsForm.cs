using RentVehicle.Forms.ForAdmin.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace RentVehicle.Forms.ForAdmin
{
    public partial class ModelsForm : Form
    {
        public ModelsForm()
        {
            InitializeComponent();
            try
            {
                using (TSContext db = new TSContext())
                {
                    var models = db.Models.ToList();
                    DataGridFill(models);
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

        private Model SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Models.FirstOrDefault(m => m.IdModelType == id);
            }
        }

        private void DataGridFill(List<Model> models)
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (TSContext db = new TSContext())
                {
                    foreach (var m in models)
                    {
                        dataGridView1.Rows.Add($"{m.IdModelType}",
                            $"{m.ModelType}",
                            $"{m.NumberOfWheels}",
                            $"{m.NumberOfSeats}",
                            $"{m.WheelSize}",
                            $"{m.WheelType}",
                            $"{m.FrameType}",
                            "✎");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ModelsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                CMB cmb = new CMB();
                cmb.ShowDialog();
                try
                {
                    if (cmb.DialogResult.Equals(DialogResult.Yes))
                    {
                        using (TSContext db = new TSContext())
                        {
                            var model = SearchByID(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                            db.Models.Remove(model);
                            db.SaveChanges();
                            MessageBox.Show("Удаление прошло успешно", "EZДЖИ");
                            var models = db.Models.ToList();
                            DataGridFill(models);
                        }
                    }
                    else if (cmb.DialogResult.Equals(DialogResult.No))
                    {
                        UpdateModelForm updateModelForm = new UpdateModelForm();
                        updateModelForm.Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                        updateModelForm.modelTypeTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                        updateModelForm.numberOfWheelsTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                        updateModelForm.numberOfSeatsTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                        updateModelForm.wheelSizeTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                        updateModelForm.wheelTypeTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                        updateModelForm.frameTypeTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                        updateModelForm.FormClosed += (object s, FormClosedEventArgs args) =>
                        {
                            using (TSContext db = new TSContext())
                            {
                                var models = db.Models.ToList();
                                DataGridFill(models);
                            }
                        };
                        updateModelForm.Show();
                    }
                    else return;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddModelForm addModelForm = new AddModelForm();
            addModelForm.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                try
                {
                    using (TSContext db = new TSContext())
                    {
                        var models = db.Models.ToList();
                        DataGridFill(models);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            };
            addModelForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var models = db.Models.ToList();
                    if (!string.IsNullOrEmpty(searchIDTextBox.Text))
                        models = models.Where(m => m.IdModelType.ToString().Contains(searchIDTextBox.Text)).ToList();
                    if (!string.IsNullOrEmpty(modelTypeComboBox.Text))
                        models = models.Where(m => m.ModelType.Contains(modelTypeComboBox.Text)).ToList();
                    DataGridFill(models);
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
