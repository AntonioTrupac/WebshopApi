using System;
using System.Collections.Generic;

namespace WebShop
{
    public partial class Product
    {
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
