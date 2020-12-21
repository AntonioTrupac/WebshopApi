using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models;

namespace Infrastructure
{
    public class ProductType :BaseEntity
    {
        public string Name { get; set; }
    }
}
