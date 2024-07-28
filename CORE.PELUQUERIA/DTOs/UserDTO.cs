using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.DTOs
{
    public partial class UserDTO
    {
        public decimal UserId { get; set; }
        public decimal PersonIdx { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool Employee { get; set; }
    }
}
