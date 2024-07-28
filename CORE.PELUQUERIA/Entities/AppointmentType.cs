using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.Entities
{
    public partial class AppointmentType
    {
        public AppointmentType()
        {
            Appointments = new HashSet<Appointment>();
        }

        public decimal ApptTypeId { get; set; }
        public string? ApptType { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
