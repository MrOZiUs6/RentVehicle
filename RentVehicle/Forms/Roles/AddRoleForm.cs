using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.Forms.ForAdmin.Roles
{
    public partial class AddRoleForm : Form
    {
        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var role = new Role();
                    role.IdRole = db.Roles.ToList().Count + 1;
                    role.NameRole = nameRoleTextBox.Text;
                    db.Roles.Add(role);
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
