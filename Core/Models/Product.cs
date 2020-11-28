using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure;

namespace Core.Models
{
    public class Product
    {
        
        [Key]
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        
        public ProductType ProductType { get; set; }
        
        

    }
}
