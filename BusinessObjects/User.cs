using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            OrderShipperNavigations = new HashSet<Order>();
            OrderUsernameNavigations = new HashSet<Order>();
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public byte? Gender { get; set; }
        public string Sex => (Gender == 1) ? "Male" : "Female";
        public string Phone { get; set; }
        public int? Yob { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> OrderShipperNavigations { get; set; }
        public virtual ICollection<Order> OrderUsernameNavigations { get; set; }
    }
}
