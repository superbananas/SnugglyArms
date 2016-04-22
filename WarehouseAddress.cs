using System;
using System.Collections.Generic;

namespace Entities2
{
    public partial class WarehouseAddress
    {
        public int WarehouseAddressId { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModified { get; set; }
        public int? SecondaryUnitId { get; set; }
        public string SecondaryUnitValue { get; set; }
        public int USStateId { get; set; }
        public int WarehouseId { get; set; }
        public string Zip4 { get; set; }
        public string Zipcode { get; set; }

        public virtual LkpSecondaryUnitType SecondaryUnit { get; set; }
        public virtual LkpUSState USState { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
