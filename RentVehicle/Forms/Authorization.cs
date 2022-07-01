using System.Data;

namespace RentVehicle.Forms
{
    public partial class Authorization : Form
    {
        public static int IDRole;

        public Authorization()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            using (TSContext db = new TSContext())
            {
                try
                {
                    var list = db.Employees.Where(e => e.Login == loginTextBox.Text && e.Password == passwordTextBox.Text).ToList();
                    if (list.Count == 0)
                    {
                        MessageBox.Show("Введены неправильный логин или пароль!");
                    }
                    else
                    {
                        foreach (var employee in list)
                        {
                            if (employee.IdRole == 2)
                            {
                                IDRole = 2;
                                Hide();
                                EmployeeForm employeeForm = new EmployeeForm();
                                employeeForm.Show();
                                MessageBox.Show($"Добро пожаловать, {employee.Name} {employee.Patronymic}", "EZДЖИ");
                            }
                            else if (employee.IdRole == 1)
                            {
                                IDRole = 1;
                                Hide();
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                                MessageBox.Show("Добро пожаловать в админское приложение", "EZДЖИ");
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }
}
