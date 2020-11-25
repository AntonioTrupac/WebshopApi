using System;
using System.Collections.Generic;

namespace WebShop.Models
{
    public class Product
    {
        

        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        
    }
}
