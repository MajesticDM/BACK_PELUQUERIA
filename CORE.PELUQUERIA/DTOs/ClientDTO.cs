

namespace CORE.PELUQUERIA.Entities
{
    public partial class ClientDTO
    {

        public decimal ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string? LastName { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime? LastVisit { get; set; }
    }
}
