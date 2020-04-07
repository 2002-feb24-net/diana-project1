using System;
using System.Collections.Generic;

namespace LimsGarden.DataAccess.Model
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Orders>();
        }

        public int LocationId { get; set; }
        public string BranchName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public int? Zipcode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
