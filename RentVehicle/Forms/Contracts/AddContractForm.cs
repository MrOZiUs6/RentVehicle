namespace RentVehicle.Forms.ForAdmin.Contracts
{
    public partial class AddContractForm : Form
    {
        public static int Hours { get; set; }

        public AddContractForm()
        {
            InitializeComponent();
            clientsComboBox.ItemHeight = 50;
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

        private Vehicle SearchBySerialNumber(int sn)
        {
            using (TSContext db = new TSContext())
            {
                return db.Vehicles.FirstOrDefault(v => v.SerialNumber == sn);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var contract = new Contract();
                    contract.IdContract = db.Contracts.ToList().Count() + 1;
                    contract.DateOfConclusion = DateTime.UtcNow;
                    contract.IdEmployee = employeesComboBox.SelectedIndex + 1;
                    contract.DocumentNumber = decimal.Parse(clientsComboBox.Text.Substring(clientsComboBox.Text.IndexOf('/') + 1));
                    contract.SerialNumber = int.Parse(serialNumberTextBox.Text);
                    contract.FinalPrice = decimal.Parse(finalPriceTextBox.Text);
                    db.Add(contract);
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

        private void finalPriceTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            HCM hcm = new HCM();
            hcm.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                finalPriceTextBox.Text = (Hours * SearchBySerialNumber(int.Parse(serialNumberTextBox.Text)).RentalPrice).ToString();
            };
            hcm.Show();
        }
    }
}
