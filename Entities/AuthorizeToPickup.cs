using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class AuthorizeToPickup
    {
        public AuthorizeToPickup()
        {
            PackageNavigation = new HashSet<Package>();
        }

        public int AuthorizeToPickupId { get; set; }
        public DateTime Created { get; set; }
        public string Firstname { get; set; }
        public DateTime LastModified { get; set; }
        public string Lastname { get; set; }
        public int PackageId { get; set; }
        public int RelationId { get; set; }

        public virtual ICollection<Package> PackageNavigation { get; set; }
        public virtual Package Package { get; set; }
        public virtual LkpPickupRelation Relation { get; set; }
    }
}
