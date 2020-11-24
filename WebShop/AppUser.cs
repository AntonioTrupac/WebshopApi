using System;
using System.Collections.Generic;

namespace WebShop
{
    public partial class AppUser
    {
        public AppUser()
        {
            ShopOrder = new HashSet<ShopOrder>();
        }

        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<ShopOrder> ShopOrder { get; set; }
    }
}
