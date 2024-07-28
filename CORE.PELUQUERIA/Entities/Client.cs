using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.Entities
{
    public partial class Client
    {
        public Client()
        {
            Appointments = new HashSet<Appointment>();
        }

        public decimal ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string? LastName { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime? LastVisit { get; set; }
        public string? SpecialistNote { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
