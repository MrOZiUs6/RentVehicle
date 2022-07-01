using System;
using System.Collections.Generic;

namespace RentVehicle
{
    public partial class Client
    {
        public Client()
        {
            Contracts = new HashSet<Contract>();
        }

        public decimal DocumentNumber { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Patronymic { get; set; }
        public decimal TelephoneNumber { get; set; }
        public string Password { get; set; } = null!;

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
