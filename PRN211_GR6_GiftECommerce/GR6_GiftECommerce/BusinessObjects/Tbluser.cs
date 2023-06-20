using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Tbluser
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Gender { get; set; }
        public string Phone { get; set; }
        public int? Yob { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public int? WardCode { get; set; }
        public byte? Enabled { get; set; }
    }
}
