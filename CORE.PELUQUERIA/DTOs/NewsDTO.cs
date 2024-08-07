﻿using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.DTOs
{
    public partial class NewsDTO
    {
        public decimal NoticeId { get; set; }
        public decimal SpecialistCreatorIdx { get; set; }
        public decimal SpecialistInvolvedIdx { get; set; }
        public string? Notice { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
