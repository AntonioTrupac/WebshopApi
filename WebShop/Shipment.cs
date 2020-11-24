using System;
using System.Collections.Generic;

namespace WebShop
{
    public partial class Shipment
    {
        public Shipment()
        {
            ShipmentItem = new HashSet<ShipmentItem>();
        }

        public int ShipmentId { get; set; }
        public int OrderId { get; set; }
        public int? ShipmentTrackingNumber { get; set; }
        public DateTime? ShipmentDate { get; set; }

        public virtual ShopOrder Order { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItem { get; set; }
    }
}
