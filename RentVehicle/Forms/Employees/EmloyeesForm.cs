using RentVehicle.Forms.ForAdmin.Employees;
using Excel = Microsoft.Office.Interop.Excel;

namespace RentVehicle.Forms.ForAdmin
{
    public partial class EmloyeesForm : Form
    {
        public EmloyeesForm()
        {
            InitializeComponent();
            try
            {
                using (TSContext db = new TSContext())
                {
                    var employees = db.Employees.ToList();
                    DataGridFill(employees);
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
                    foreach (Role roles in db.Roles)
                    {
                        roleComboBox.Items.Add(roles.NameRole);
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private Employee SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Employees.FirstOrDefault(e => e.IdEmployee == id);
            }
        }

        private void EmloyeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void DataGridFill(List<Employee> employees)
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (TSContext db = new TSContext())
                {
                    var roles = db.Roles.ToList();
                    foreach (var e in employees)
                    {
                        var role = roles.Where(r => r.IdRole == e.IdRole).FirstOrDefault();
                        dataGridView1.Rows.Add($"{e.IdEmployee}",
                            $"{e.Surname}",
                            $"{e.Name}",
                            $"{e.Patronymic}",
                            $"{e.Login}",
                            $"{e.Password}",
                            $"{role.NameRole}",
                            "✎");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                try
                {
                    using (TSContext db = new TSContext())
                    {
                        var employees = db.Employees.ToList();
                        DataGridFill(employees);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }           
            };
            addEmployeeForm.Show();
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
                            var employee = SearchByID(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                            db.Employees.Remove(employee);
                            db.SaveChanges();
                            MessageBox.Show("Удаление прошло успешно", "EZДЖИ");
                            var employees = db.Employees.ToList();
                            DataGridFill(employees);
                        }
                    }
                    else if (cmb.DialogResult.Equals(DialogResult.No))
                    {
                        UpdateEmployeeForm updateEmployeeForm = new UpdateEmployeeForm();
                        updateEmployeeForm.Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                        updateEmployeeForm.surnameTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                        updateEmployeeForm.nameTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                        updateEmployeeForm.patronymicTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                        updateEmployeeForm.loginTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                        updateEmployeeForm.passwordTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                        updateEmployeeForm.roleComboBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                        updateEmployeeForm.FormClosed += (object s, FormClosedEventArgs args) =>
                        {
                            using (TSContext db = new TSContext())
                            {
                                var employees = db.Employees.ToList();
                                DataGridFill(employees);
                            }
                        };
                        updateEmployeeForm.Show();
                    }
                    else return;
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
                    var employees = db.Employees.ToList();
                    if (!string.IsNullOrEmpty(searchIDTextBox.Text))
                        employees = employees.Where(e => e.IdEmployee.ToString().Contains(searchIDTextBox.Text)).ToList();
                    if (!string.IsNullOrEmpty(searchSTextBox.Text))
                        employees = employees.Where(e => e.Surname.ToLower().Contains(searchSTextBox.Text.ToLower())).ToList();
                    if (!string.IsNullOrEmpty(roleComboBox.Text))
                        employees = employees.Where(e => e.IdRole.ToString().Contains((roleComboBox.SelectedIndex + 1).ToString())).ToList();
                    DataGridFill(employees);
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
