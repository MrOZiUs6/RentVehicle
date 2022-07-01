using System;
using System.Collections.Generic;

namespace RentVehicle
{
    public partial class Contract
    {
        public int IdContract { get; set; }
        public DateTime DateOfConclusion { get; set; }
        public int IdEmployee { get; set; }
        public decimal DocumentNumber { get; set; }
        public int SerialNumber { get; set; }
        public decimal FinalPrice { get; set; }

        public virtual Client DocumentNumberNavigation { get; set; } = null!;
        public virtual Employee IdEmployeeNavigation { get; set; } = null!;
        public virtual Vehicle SerialNumberNavigation { get; set; } = null!;
    }
}
