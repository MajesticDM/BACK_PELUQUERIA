using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.DTOs
{
    public partial class ClientDTO
    {

        public decimal ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string? LastName { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime? LastVisit { get; set; }
        public string? SpecialistNote { get; set; }
    }
}
