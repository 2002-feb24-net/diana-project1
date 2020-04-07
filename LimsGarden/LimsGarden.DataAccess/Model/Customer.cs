using System;
using System.Collections.Generic;

namespace LimsGarden.DataAccess.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

            public int CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
