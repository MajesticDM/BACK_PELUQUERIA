using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.DTOs
{
    public partial class ProductDTO
    {
        public decimal ProductId { get; set; }
        public decimal CategorieIdx { get; set; }
        public string? Product1 { get; set; }
        public decimal? Quantity { get; set; }
        public byte[]? Photo { get; set; }

    }
}
