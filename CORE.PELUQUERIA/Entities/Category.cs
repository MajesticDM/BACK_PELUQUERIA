using System;
using System.Collections.Generic;

namespace CORE.PELUQUERIA.Entities
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public decimal CategorieId { get; set; }
        public string Categorie { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
