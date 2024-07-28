using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.Entities
{
    public partial class News
    {
        public decimal NoticeId { get; set; }
        public decimal SpecialistCreatorIdx { get; set; }
        public decimal SpecialistInvolvedIdx { get; set; }
        public string? Notice { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual Specialist SpecialistCreatorIdxNavigation { get; set; } = null!;
        public virtual Specialist SpecialistInvolvedIdxNavigation { get; set; } = null!;
    }
}
