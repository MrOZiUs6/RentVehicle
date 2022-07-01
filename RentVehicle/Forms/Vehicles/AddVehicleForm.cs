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
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var vehicle = new Vehicle();
                    vehicle.SerialNumber = int.Parse(serialNumberTextBox.Text);
                    vehicle.IdModelType = modelTypeComboBox.SelectedIndex + 1;
                    vehicle.LifeTime = int.Parse(lifeTimeTextBox.Text);
                    vehicle.RentalPrice = int.Parse(rentalPriceTextBox.Text);
                    db.Vehicles.Add(vehicle);
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

        private void modelTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var model = db.Models.FirstOrDefault(m => m.IdModelType == modelTypeComboBox.SelectedIndex + 1);
                    MessageBox.Show($"Тип Модели - {model.ModelType}\n" +
                        $"Кол-во Колёс - {model.NumberOfWheels}\n" +
                        $"Кол-во Мест - {model.NumberOfSeats}\n" +
                        $"Размер Колёс - {model.WheelSize}\n" +
                        $"Тип Шин - {model.WheelType}\n" +
                        $"Тип Рамы - {model.FrameType}"
                        , "EZДЖИ");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
