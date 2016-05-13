using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class LkpUSState
    {
        public LkpUSState()
        {
            PackageReturnAddress = new HashSet<PackageReturnAddress>();
            WarehouseAddress = new HashSet<WarehouseAddress>();
        }

        public int USStateId { get; set; }
        public string Caption { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string Enumeration { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<PackageReturnAddress> PackageReturnAddress { get; set; }
        public virtual ICollection<WarehouseAddress> WarehouseAddress { get; set; }
    }
}
