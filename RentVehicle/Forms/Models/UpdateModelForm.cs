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
    public partial class UpdateModelForm : Form
    {
        public UpdateModelForm()
        {
            InitializeComponent();
        }

        private Model SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Models.FirstOrDefault(m => m.IdModelType == id);
            }
        }

        public int Id
        {
            get; set;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TSContext db = new TSContext())
                {
                    var model = SearchByID(Id);
                    model.ModelType = modelTypeTextBox.Text;
                    model.NumberOfWheels = int.Parse(numberOfWheelsTextBox.Text);
                    model.NumberOfSeats = int.Parse(numberOfSeatsTextBox.Text);
                    model.WheelSize = int.Parse(wheelSizeTextBox.Text);
                    model.WheelType = wheelTypeTextBox.Text;
                    model.FrameType = frameTypeTextBox.Text;
                    db.Models.Update(model);
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
