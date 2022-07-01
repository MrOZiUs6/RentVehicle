using RentVehicle.Forms.ForAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void viewingClientButton_Click(object sender, EventArgs e)
        {
            Hide();
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void viewingEmployeeButton_Click(object sender, EventArgs e)
        {
            Hide();
            EmloyeesForm emloyeesForm = new EmloyeesForm();
            emloyeesForm.Show();
        }

        private void viewingRoleButton_Click(object sender, EventArgs e)
        {
            Hide();
            RolesForm rolesForm = new RolesForm();
            rolesForm.Show();
        }

        private void viewingVehicleButton_Click(object sender, EventArgs e)
        {
            Hide();
            VehicleForm vehicleForm = new VehicleForm();
            vehicleForm.Show();
        }

        private void viewingModelButton_Click(object sender, EventArgs e)
        {
            Hide();
            ModelsForm modelsForm = new ModelsForm();
            modelsForm.Show();
        }

        private void viewingContractsButton_Click(object sender, EventArgs e)
        {
            Hide();
            ContractsForm contractsForm = new ContractsForm();
            contractsForm.Show();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
        }
    }
}
