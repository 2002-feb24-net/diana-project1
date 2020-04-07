using System;
using System.Collections.Generic;

namespace LimsGarden.DataAccess.Model
{
    public partial class OrderDetails
    {
        public int OrderItemId { get; set; }
        public int? OrderId { get; set; }
        public int? PlantId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalCost { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Plant Plant { get; set; }
    }
}
