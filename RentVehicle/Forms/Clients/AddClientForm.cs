using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.Forms.ForAdmin
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var client = new Client();
                    client.DocumentNumber = decimal.Parse(documentNumberMaskedTextBox.Text.Replace(" ", ""));
                    client.Surname = surnameTextBox.Text;
                    client.Name = nameTextBox.Text;
                    client.Patronymic = patronymicTextBox.Text;
                    client.TelephoneNumber = decimal.Parse(telephoneBumberMaskedTextBox.Text.Replace(" ", "").Replace("-", ""));
                    client.Password = passwordTextBox.Text;
                    db.Clients.Add(client);
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
