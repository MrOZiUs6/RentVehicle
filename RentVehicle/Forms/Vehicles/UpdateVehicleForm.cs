using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.Forms.ForAdmin.Vehicles
{
    public partial class UpdateVehicleForm : Form
    {
        public UpdateVehicleForm()
        {
            InitializeComponent();
            try
            {
                using (TSContext db = new TSContext())
                {
                    foreach (Model models in db.Models)
                    {
                        modelTypeComboBox.Items.Add(models.ModelType);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private Vehicle SearchBySN(int sn)
        {
            using (TSContext db = new TSContext())
            {
                return db.Vehicles.FirstOrDefault(v => v.SerialNumber == sn);
            }
        }

        public int Sn
        {
            get; set;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var vehicle = SearchBySN(Sn);
                    vehicle.IdModelType = modelTypeComboBox.SelectedIndex + 1;
                    vehicle.LifeTime = int.Parse(lifeTimeTextBox.Text);
                    vehicle.RentalPrice = decimal.Parse(rentalPriceTextBox.Text);
                    db.Vehicles.Update(vehicle);
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
