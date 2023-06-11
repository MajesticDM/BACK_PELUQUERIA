

namespace CORE.PELUQUERIA.Entities
{
    public partial class Client
    {
        public Client()
        {
            Appointments = new HashSet<Appointment>();
            Users = new HashSet<User>();
        }

        public decimal ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string? LastName { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime? LastVisit { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
