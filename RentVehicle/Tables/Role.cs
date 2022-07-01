using System;
using System.Collections.Generic;

namespace RentVehicle
{
    public partial class Role
    {
        public Role()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdRole { get; set; }
        public string NameRole { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
