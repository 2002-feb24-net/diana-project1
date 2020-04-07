using System;
using System.Collections.Generic;

namespace LimsGarden.DataAccess.Model
{
    public partial class Plant
    {
        public Plant()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public int? InventoryCount { get; set; }
        public int? Cost { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
