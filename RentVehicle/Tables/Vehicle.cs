using System;
using System.Collections.Generic;

namespace RentVehicle
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Contracts = new HashSet<Contract>();
        }

        public int SerialNumber { get; set; }
        public int IdModelType { get; set; }
        public int LifeTime { get; set; }
        public decimal RentalPrice { get; set; }

        public virtual Model IdModelTypeNavigation { get; set; } = null!;
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
