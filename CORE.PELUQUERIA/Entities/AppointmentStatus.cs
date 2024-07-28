using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.Entities
{
    public partial class AppointmentStatus
    {
        public AppointmentStatus()
        {
            Appointments = new HashSet<Appointment>();
        }

        public decimal ApptStatusId { get; set; }
        public string? ApptStatus { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
