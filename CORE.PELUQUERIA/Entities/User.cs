

namespace CORE.PELUQUERIA.Entities
{
    public partial class User
    {
        public decimal UserId { get; set; }
        public decimal? ClientIdx { get; set; }
        public decimal UserTypeIdx { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual Client ClientIdxNavigation { get; set; } = null!;
        public virtual UserType UserTypeIdxNavigation { get; set; } = null!;
    }
}
