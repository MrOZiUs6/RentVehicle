using RentVehicle.Forms.ForAdmin.Clients;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace RentVehicle.Forms.ForAdmin
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            try
            {
                using (TSContext db = new TSContext())
                {
                    var clients = db.Clients.ToList();
                    DataGridFill(clients);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ClientsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DataGridFill(List<Client> clients)
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (TSContext db = new TSContext())
                {
                    foreach (var client in clients)
                    {
                        dataGridView1.Rows.Add($"{client.DocumentNumber}",
                            $"{client.Surname}",
                            $"{client.Name}",
                            $"{client.Patronymic}",
                            $"{client.TelephoneNumber}",
                            $"{client.Password}",
                            "✎");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private Client SearchByDocumentNumber(long dn)
        {
            using (TSContext db = new TSContext())
            {
                return db.Clients.FirstOrDefault(c => c.DocumentNumber == dn);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var clients = db.Clients.ToList();
                    if (!string.IsNullOrEmpty(searchDNTextBox.Text))
                        clients = clients.Where(c => c.DocumentNumber.ToString().Contains(searchDNTextBox.Text)).ToList();
                    if (!string.IsNullOrEmpty(searchSTextBox.Text))
                        clients = clients.Where(c => c.Surname.ToLower().Contains(searchSTextBox.Text.ToLower())).ToList();
                    if (!string.IsNullOrEmpty(searchTNTextBox.Text))
                        clients = clients.Where(c => c.TelephoneNumber.ToString().Contains(searchTNTextBox.Text)).ToList();
                    DataGridFill(clients);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                try
                {
                    using (TSContext db = new TSContext())
                    {
                        var clients = db.Clients.ToList();
                        DataGridFill(clients);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            };
            addClientForm.Show();
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
                            var client = SearchByDocumentNumber(long.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                            db.Clients.Remove(client);
                            db.SaveChanges();
                            MessageBox.Show("Удаление прошло успешно", "EZДЖИ");
                            var clients = db.Clients.ToList();
                            DataGridFill(clients);
                        }
                    }
                    else if (cmb.DialogResult.Equals(DialogResult.No))
                    {
                        UpdateClientForm updateClientForm = new UpdateClientForm();
                        updateClientForm.DocumentNumber = decimal.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                        updateClientForm.surnameTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                        updateClientForm.nameTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                        updateClientForm.patronymicTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                        updateClientForm.telephoneNumberMaskedTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                        updateClientForm.passwordTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                        updateClientForm.FormClosed += (object s, FormClosedEventArgs args) =>
                        {
                            using (TSContext db = new TSContext())
                            {
                                var clients = db.Clients.ToList();
                                DataGridFill(clients);
                            }
                        };
                        updateClientForm.Show();
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