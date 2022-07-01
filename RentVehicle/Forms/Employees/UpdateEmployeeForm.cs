using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.Forms.ForAdmin.Employees
{
    public partial class UpdateEmployeeForm : Form
    {
        public UpdateEmployeeForm()
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

        private Employee SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Employees.FirstOrDefault(e => e.IdEmployee == id);
            }
        }

        public int Id
        {
            get; set;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var employee = SearchByID(Id);
                    employee.Surname = surnameTextBox.Text;
                    employee.Name = nameTextBox.Text;
                    employee.Patronymic = patronymicTextBox.Text;
                    employee.Login = loginTextBox.Text;
                    employee.Password = passwordTextBox.Text;
                    employee.IdRole = roleComboBox.SelectedIndex + 1;
                    db.Employees.Update(employee);
                    db.SaveChanges();
                    MessageBox.Show("Обновление прошло успешно", "EZДЖИ");
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
