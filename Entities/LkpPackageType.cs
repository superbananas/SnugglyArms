using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class LkpPackageType
    {
        public LkpPackageType()
        {
            Package = new HashSet<Package>();
        }

        public int PackageTypeId { get; set; }
        public string Caption { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string Enumeration { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<Package> Package { get; set; }
    }
}
