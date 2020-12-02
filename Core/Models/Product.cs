using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure;

namespace Core.Models
{
    [Table("product")]
    public class Product : BaseEntity {
        
        [Column("Name")]
        public string Name { get; set; }
        [Column("Price")]
        public string Price { get; set; }
        [Column("Size")]
        public string Size { get; set; }
        [Column("Stock")]
        public int Stock { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Product_Type_Id")]
        public int Product_Type_Id { get; set; }
        

    }
}
