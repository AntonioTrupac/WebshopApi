using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure;

namespace Core.Models
{
    public class Product : BaseEntity {
        
        public string Name { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public  ProductType ProductType { get; set; }
       
        

    }
}
