using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Cart
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int? Quantity { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public virtual User UsernameNavigation { get; set; }
    }
}
