using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Tblproduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public int? CategoryId { get; set; }
        public string LastUpdatedBy { get; set; }
        public string Avatar { get; set; }
    }
}
