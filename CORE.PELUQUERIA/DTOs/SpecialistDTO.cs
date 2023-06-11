

namespace CORE.PELUQUERIA.DTOs
{
    public partial class SpecialistDTO
    {

        public decimal SpecialistId { get; set; }
        public string SpecialistName { get; set; } = null!;
        public decimal SpecialistPhone { get; set; }
        public byte[] SpecialistPhoto { get; set; } = null!;
        public string? SpecialistNote { get; set; }
    }
}
