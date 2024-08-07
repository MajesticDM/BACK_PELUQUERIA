﻿using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.DTOs
{
    public partial class SpecialistDTO
    {

        public decimal SpecialistId { get; set; }
        public string SpecialistName { get; set; } = null!;
        public decimal SpecialistPhone { get; set; }
        public byte[]? SpecialistPhoto { get; set; }
        public string? SpecialistEmail { get; set; }
        public string? SpecialistNote { get; set; }
        public bool? BitStatus { get; set; }
        public bool? BitAdmin { get; set; }

    }
}
