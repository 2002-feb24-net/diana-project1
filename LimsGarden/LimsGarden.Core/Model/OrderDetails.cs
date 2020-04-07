using System;
using System.Collections.Generic;

namespace LimsGarden.Core.Model
{
    public partial class OrderDetails
    {
        public int OrderItemId { get; set; }
        public int? OrderId { get; set; }
        public int? PlantId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalCost { get; set; }

    }
}
