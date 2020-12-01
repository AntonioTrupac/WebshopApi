using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models;

namespace Infrastructure
{    
    [Table("product_type")]
    public class ProductType 
    {
       [Key]
       [Column("Product_Type_Id")]
       public int Product_Type_Id { get; set; }
       [Column("Name")]
       public string Name { get; set; }

        
    }
}
