namespace RentVehicle.Forms.ForAdmin.Employees
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var employee = new Employee();
                    employee.IdEmployee = db.Employees.ToList().Count + 1;
                    employee.Surname = surnameTextBox.Text;
                    employee.Name = nameTextBox.Text;
                    employee.Patronymic = patronymicTextBox.Text;
                    employee.Login = loginTextBox.Text;
                    employee.Password = passwordTextBox.Text;
                    employee.IdRole = roleComboBox.SelectedIndex + 1;
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    MessageBox.Show("Добавление прошло успешно", "EZДЖИ");
                    Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
