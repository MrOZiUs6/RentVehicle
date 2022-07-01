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
    public partial class UpdateRoleForm : Form
    {
        public int Id
        {
            get; set;
        }

        public UpdateRoleForm()
        {
            InitializeComponent();
        }
        private Role SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Roles.FirstOrDefault(e => e.IdRole == id);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var role = SearchByID(Id);
                    role.NameRole = nameRoleTextBox.Text;
                    db.Roles.Update(role);
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
