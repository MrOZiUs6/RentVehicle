using Excel = Microsoft.Office.Interop.Excel;
using RentVehicle.Forms.ForAdmin.Contracts;
using System.Data;


namespace RentVehicle.Forms.ForAdmin
{
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
            try
            {
                using (TSContext db = new TSContext())
                {
                    var contracts = db.Contracts.ToList();
                    DataGridFill(contracts);
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
                    foreach (Employee employees in db.Employees)
                    {
                        employeesComboBox.Items.Add(employees.Surname + "/" + employees.IdEmployee);
                    }
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
                    foreach (Client clients in db.Clients)
                    {
                        clientsComboBox.Items.Add(clients.Surname + "/" + clients.DocumentNumber);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private Contract SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Contracts.FirstOrDefault(c => c.IdContract == id);
            }
        }

        private void DataGridFill(List<Contract> contracts)
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (TSContext db = new TSContext())
                {
                    var employees = db.Employees.ToList();
                    var clients = db.Clients.ToList();
                    foreach (var c in contracts)
                    {
                        var employee = employees.Where(e => e.IdEmployee == c.IdEmployee).FirstOrDefault();
                        var client = clients.Where(cl => cl.DocumentNumber == c.DocumentNumber).FirstOrDefault();
                        dataGridView1.Rows.Add($"{c.IdContract}",
                            $"{c.DateOfConclusion}",
                            $"{employee.Surname}/{c.IdEmployee}",
                            $"{client.Surname}/{c.DocumentNumber}",
                            $"{c.SerialNumber}",
                            $"{c.FinalPrice}",
                            "✎");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ContractsForm_FormClosing(object sender, FormClosingEventArgs e)
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
            AddContractForm addContractForm = new AddContractForm();
            addContractForm.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                try
                {
                    using (TSContext db = new TSContext())
                    {
                        var contracts = db.Contracts.ToList();
                        DataGridFill(contracts);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }            
            };
            addContractForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var contracts = db.Contracts.ToList();
                    if (!string.IsNullOrEmpty(dateMaskedTextBox.Text))
                        contracts = contracts.Where(c => c.DateOfConclusion.ToString().Replace("-", "").Replace(":", "").Replace(" ", "")
                        .Contains(dateMaskedTextBox.Text.Replace("-", "").Replace(":", "").Replace(" ", ""))).ToList();
                    if (!string.IsNullOrEmpty(employeesComboBox.Text))
                        contracts = contracts.Where(c => c.IdEmployee == employeesComboBox.SelectedIndex + 1).ToList();
                    if (!string.IsNullOrEmpty(clientsComboBox.Text))
                        contracts = contracts.Where(c => c.DocumentNumber == decimal.Parse(clientsComboBox.Text.Substring(clientsComboBox.Text.IndexOf('/') + 1))).ToList();
                    DataGridFill(contracts);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 6)
            {
                CMB cmb = new CMB();
                cmb.ShowDialog();
                try
                {
                    if (cmb.DialogResult.Equals(DialogResult.Yes))
                    {
                        using (TSContext db = new TSContext())
                        {
                            var contract = SearchByID(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                            db.Contracts.Remove(contract);
                            db.SaveChanges();
                            MessageBox.Show("Удаление прошло успешно", "EZДЖИ");
                            var contarcts = db.Contracts.ToList();
                            DataGridFill(contarcts);
                        }
                    }
                    else if (cmb.DialogResult.Equals(DialogResult.No))
                    {
                        UpdateContractForm updateContractForm = new UpdateContractForm();
                        updateContractForm.ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                        updateContractForm.dateMaskedTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                        updateContractForm.employeesComboBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                        updateContractForm.clientsComboBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                        updateContractForm.serialNumberTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                        updateContractForm.finalPriceTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                        updateContractForm.FormClosed += (object s, FormClosedEventArgs args) =>
                        {
                            using (TSContext db = new TSContext())
                            {
                                var contracts = db.Contracts.ToList();
                                DataGridFill(contracts);
                            }
                        };
                        updateContractForm.Show();
                    }
                    else return;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
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
