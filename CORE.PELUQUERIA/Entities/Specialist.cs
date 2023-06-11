

namespace CORE.PELUQUERIA.Entities
{
    public partial class Specialist
    {
        public Specialist()
        {
            Appointments = new HashSet<Appointment>();
        }

        public decimal SpecialistId { get; set; }
        public string SpecialistName { get; set; } = null!;
        public decimal SpecialistPhone { get; set; }
        public byte[] SpecialistPhoto { get; set; } = null!;
        public string? SpecialistNote { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
