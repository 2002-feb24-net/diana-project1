using System;
using System.Collections.Generic;

namespace LimsGarden.DataAccess.Model
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? LocationId { get; set; }
        public decimal? OrderTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
