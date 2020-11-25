using System;
using System.Collections.Generic;

namespace WebShop.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

        public int ProductTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
