using System;
using System.Collections.Generic;

namespace LimsGarden.Core.Model
{
    public partial class Customer
    {
        public int LocationId { get; set; }
        public string BranchName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public int? Zipcode { get; set; }

    }
}