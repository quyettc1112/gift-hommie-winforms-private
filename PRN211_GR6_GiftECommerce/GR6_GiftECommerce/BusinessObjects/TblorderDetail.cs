using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblorderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
