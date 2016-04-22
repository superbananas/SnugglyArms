using System;
using System.Collections.Generic;

namespace Entities2
{
    public partial class LkpSecondaryUnitType
    {
        public LkpSecondaryUnitType()
        {
            PackageReturnAddress = new HashSet<PackageReturnAddress>();
            WarehouseAddress = new HashSet<WarehouseAddress>();
        }

        public int SecondaryUnitTypeId { get; set; }
        public string Caption { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string Enumeration { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<PackageReturnAddress> PackageReturnAddress { get; set; }
        public virtual ICollection<WarehouseAddress> WarehouseAddress { get; set; }
    }
}
