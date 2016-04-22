using System;
using System.Collections.Generic;

namespace Entities2
{
    public partial class LkpWarehouseAvailability
    {
        public LkpWarehouseAvailability()
        {
            Warehouse = new HashSet<Warehouse>();
        }

        public int WarehouseAvailabilityId { get; set; }
        public string Caption { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string Enumeration { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<Warehouse> Warehouse { get; set; }
    }
}
