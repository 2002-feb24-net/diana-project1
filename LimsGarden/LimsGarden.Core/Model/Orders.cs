using System;
using System.Collections.Generic;

namespace LimsGarden.Core.Model
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? LocationId { get; set; }
        public decimal? OrderTotal { get; set; }
    }
}