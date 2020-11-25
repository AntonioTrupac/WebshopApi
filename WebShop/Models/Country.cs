using System;
using System.Collections.Generic;

namespace WebShop.Models
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ContinentName { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
