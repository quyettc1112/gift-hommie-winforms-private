using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Tblorder
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public byte[] Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? WardCode { get; set; }
        public int? DistrictId { get; set; }
        public int? ProvinceId { get; set; }
        public DateTime? OrderTime { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
