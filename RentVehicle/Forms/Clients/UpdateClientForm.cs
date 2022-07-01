namespace RentVehicle.Forms.ForAdmin.Clients
{
    public partial class UpdateClientForm : Form
    {
        public UpdateClientForm()
        {
            InitializeComponent();
        }

        public decimal DocumentNumber
        {
            get; set;
        }

        private Client SearchByDocumentNumber(decimal dn)
        {
            using (TSContext db = new TSContext())
            {
                return db.Clients.FirstOrDefault(c => c.DocumentNumber == dn);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var client = SearchByDocumentNumber(DocumentNumber);
                    client.Surname = surnameTextBox.Text;
                    client.Name = nameTextBox.Text;
                    client.Patronymic = patronymicTextBox.Text;
                    client.TelephoneNumber = decimal.Parse(telephoneNumberMaskedTextBox.Text.Replace(" ", "").Replace("-", ""));
                    client.Password = passwordTextBox.Text;
                    db.Clients.Update(client);
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
