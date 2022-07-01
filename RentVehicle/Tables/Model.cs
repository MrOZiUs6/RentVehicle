using System;
using System.Collections.Generic;

namespace RentVehicle
{
    public partial class Model
    {
        public Model()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int IdModelType { get; set; }
        public string ModelType { get; set; } = null!;
        public int? NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public int WheelSize { get; set; }
        public string WheelType { get; set; } = null!;
        public string FrameType { get; set; } = null!;

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
