

namespace CORE.PELUQUERIA.Entities
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public decimal UserTypeId { get; set; }
        public string? UserType1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
