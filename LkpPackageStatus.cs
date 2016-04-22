using System;
using System.Collections.Generic;

namespace Entities2
{
    public partial class LkpPackageStatus
    {
        public LkpPackageStatus()
        {
            Package = new HashSet<Package>();
        }

        public int PackageStatusId { get; set; }
        public string Caption { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string Enumeration { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<Package> Package { get; set; }
    }
}
