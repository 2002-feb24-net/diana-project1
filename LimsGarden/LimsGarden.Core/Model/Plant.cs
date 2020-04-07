using System;
using System.Collections.Generic;

namespace LimsGarden.Core.Model
{
    public partial class Plant
    {
        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public int? InventoryCount { get; set; }
        public int? Cost { get; set; }

    }
}