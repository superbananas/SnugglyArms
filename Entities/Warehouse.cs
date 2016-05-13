using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            WarehouseAddress = new HashSet<WarehouseAddress>();
        }

        public int WarehouseId { get; set; }
        public int Availability { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModified { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WarehouseAddress> WarehouseAddress { get; set; }
        public virtual LkpWarehouseAvailability AvailabilityNavigation { get; set; }
    }
}
