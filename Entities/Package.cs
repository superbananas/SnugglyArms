using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class Package
    {
        public Package()
        {
            AuthorizeToPickup = new HashSet<AuthorizeToPickup>();
            CustomerPackage = new HashSet<CustomerPackage>();
            PackageNote = new HashSet<PackageNote>();
            PackageReturnAddress = new HashSet<PackageReturnAddress>();
        }

        public int PackageId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModified { get; set; }
        public int PackageStatus { get; set; }
        public int PackageType { get; set; }
        public int? PickedupBy { get; set; }
        public DateTime? PickedUpDate { get; set; }
        public DateTime? RecievedDate { get; set; }
        public double? Weight { get; set; }

        public virtual ICollection<AuthorizeToPickup> AuthorizeToPickup { get; set; }
        public virtual ICollection<CustomerPackage> CustomerPackage { get; set; }
        public virtual ICollection<PackageNote> PackageNote { get; set; }
        public virtual ICollection<PackageReturnAddress> PackageReturnAddress { get; set; }
        public virtual LkpPackageStatus PackageStatusNavigation { get; set; }
        public virtual LkpPackageType PackageTypeNavigation { get; set; }
        public virtual AuthorizeToPickup PickedupByNavigation { get; set; }
    }
}
