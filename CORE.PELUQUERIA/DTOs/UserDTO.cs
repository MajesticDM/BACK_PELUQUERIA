

namespace CORE.PELUQUERIA.DTOs
{
    public partial class UserDTO
    {
        public decimal UserId { get; set; }
        public decimal ClientIdx { get; set; }
        public decimal UserTypeIdx { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
