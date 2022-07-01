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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void viewingClientButton_Click(object sender, EventArgs e)
        {
            Hide();
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
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
    }
}
