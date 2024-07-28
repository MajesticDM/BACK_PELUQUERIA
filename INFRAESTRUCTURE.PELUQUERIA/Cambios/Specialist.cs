using System;
using System.Collections.Generic;

namespace INFRAESTRUCTURE.PELUQUERIA.Cambios
{
    public partial class Specialist
    {
        public Specialist()
        {
            Appointments = new HashSet<Appointment>();
            NewsSpecialistCreatorIdxNavigations = new HashSet<News>();
            NewsSpecialistInvolvedIdxNavigations = new HashSet<News>();
        }

        public decimal SpecialistId { get; set; }
        public string SpecialistName { get; set; } = null!;
        public decimal SpecialistPhone { get; set; }
        public byte[]? SpecialistPhoto { get; set; }
        public string? SpecialistEmail { get; set; }
        public string? SpecialistNote { get; set; }
        public bool? BitStatus { get; set; }
        public bool? BitAdmin { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<News> NewsSpecialistCreatorIdxNavigations { get; set; }
        public virtual ICollection<News> NewsSpecialistInvolvedIdxNavigations { get; set; }
    }
}
