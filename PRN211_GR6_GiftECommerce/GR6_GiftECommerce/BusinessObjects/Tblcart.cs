using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Tblcart
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? LastTimeUpdated { get; set; }
    }
}
