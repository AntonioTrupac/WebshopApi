using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Infrastructure
{
    public  class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }
        [Key]
        public int ProductTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
