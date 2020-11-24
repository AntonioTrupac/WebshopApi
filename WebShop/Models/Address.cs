using System;
using System.Collections.Generic;

namespace WebShop
{
    public partial class Address
    {
        public Address()
        {
            AppUser = new HashSet<AppUser>();
        }

        public int AddressId { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<AppUser> AppUser { get; set; }
    }
}
