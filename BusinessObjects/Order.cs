using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? OrderTime { get; set; }
        public string Message { get; set; }
        public double? ShippingFee { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
