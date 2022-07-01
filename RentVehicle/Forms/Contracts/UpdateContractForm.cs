using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.Forms.ForAdmin.Contracts
{
    public partial class UpdateContractForm : Form
    {
        public UpdateContractForm()
        {
            InitializeComponent();
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

        public int ID
        {
            get; set;        
        }

        private Contract SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Contracts.FirstOrDefault(c => c.IdContract == id);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var contract = SearchByID(ID);
                    contract.DateOfConclusion = DateTimeOffset.Parse(dateMaskedTextBox.Text.Replace("-", ".")).UtcDateTime;
                    contract.IdEmployee = employeesComboBox.SelectedIndex + 1;
                    contract.DocumentNumber = decimal.Parse(clientsComboBox.Text.Substring(clientsComboBox.Text.IndexOf('/') + 1));
                    contract.SerialNumber = int.Parse(serialNumberTextBox.Text);
                    contract.FinalPrice = decimal.Parse(finalPriceTextBox.Text);
                    db.Contracts.Update(contract);
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
