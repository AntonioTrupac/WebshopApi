using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models;

namespace Infrastructure
{    
    [Table("product_type")]
    public class ProductType :BaseEntity
    {
      
       [Column("Name")]
       public string Name { get; set; }
       
       
    }
}
