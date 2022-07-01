using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.Forms.ForAdmin.Models
{
    public partial class AddModelForm : Form
    {
        public AddModelForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var model = new Model();
                    model.IdModelType = db.Models.ToList().Count + 1;
                    model.ModelType = modelTypeTextBox.Text;
                    model.NumberOfWheels = int.Parse(numberOfWheelsTextBox.Text);
                    model.NumberOfSeats = int.Parse(numberOfSeatsTextBox.Text);
                    model.WheelSize = int.Parse(wheelSizeTextBox.Text);
                    model.WheelType = wheelTypeTextBox.Text;
                    model.FrameType = frameTypeTextBox.Text;
                    db.Models.Add(model);
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
