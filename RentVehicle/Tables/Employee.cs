using System;
using System.Collections.Generic;

namespace RentVehicle
{
    public partial class Employee
    {
        public Employee()
        {
            Contracts = new HashSet<Contract>();
        }

        public int IdEmployee { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Patronymic { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; } = null!;
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
