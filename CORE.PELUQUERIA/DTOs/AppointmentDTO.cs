using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.DTOs
{
    public partial class AppointmentDTO
    {
        public decimal ApptId { get; set; }
        public decimal ApptTypeIdx { get; set; }
        public decimal ApptStatusIdx { get; set; }
        public decimal SpecialistIdx { get; set; }
        public decimal? ClientIdx { get; set; }
        public DateTime Date { get; set; }
        public string? Note { get; set; }
    }
}
