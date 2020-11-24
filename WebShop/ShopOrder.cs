using System;
using System.Collections.Generic;

namespace WebShop
{
    public partial class ShopOrder
    {
        public ShopOrder()
        {
            OrderItem = new HashSet<OrderItem>();
            Shipment = new HashSet<Shipment>();
        }

        public int OrderId { get; set; }
        public int SellerId { get; set; }
        public string OrderDetails { get; set; }
        public DateTime DateOrderPlaced { get; set; }

        public virtual AppUser Seller { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
