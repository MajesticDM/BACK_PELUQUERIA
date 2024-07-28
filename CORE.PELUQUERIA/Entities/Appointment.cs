using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.Entities
{
    public partial class Appointment
    {
        public decimal ApptId { get; set; }
        public decimal ApptTypeIdx { get; set; }
        public decimal ApptStatusIdx { get; set; }
        public decimal SpecialistIdx { get; set; }
        public decimal? ClientIdx { get; set; }
        public DateTime Date { get; set; }
        public string? Note { get; set; }

        public virtual AppointmentStatus ApptStatusIdxNavigation { get; set; } = null!;
        public virtual AppointmentType ApptTypeIdxNavigation { get; set; } = null!;
        public virtual Client? ClientIdxNavigation { get; set; }
        public virtual Specialist SpecialistIdxNavigation { get; set; } = null!;
    }
}
