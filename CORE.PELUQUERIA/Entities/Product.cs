using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.Entities
{
    public partial class Product
    {
        public decimal ProductId { get; set; }
        public decimal CategorieIdx { get; set; }
        public string? Product1 { get; set; }
        public decimal? Quantity { get; set; }
        public byte[]? Photo { get; set; }

        public virtual Category CategorieIdxNavigation { get; set; } = null!;
    }
}
