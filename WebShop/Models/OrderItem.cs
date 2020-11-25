using System;
using System.Collections.Generic;

namespace WebShop.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            ShipmentItem = new HashSet<ShipmentItem>();
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public virtual ShopOrder Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItem { get; set; }
    }
}
