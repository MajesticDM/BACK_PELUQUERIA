using System;
using System.Collections.Generic;

namespace INFRAESTRUCTURE.PELUQUERIA.Cambios
{
    public partial class User
    {
        public decimal UserId { get; set; }
        public decimal PersonIdx { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool Employee { get; set; }
    }
}
