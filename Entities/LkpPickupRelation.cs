using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class LkpPickupRelation
    {
        public LkpPickupRelation()
        {
            AuthorizeToPickup = new HashSet<AuthorizeToPickup>();
        }

        public int PickupRelationId { get; set; }
        public string Caption { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string Enumeration { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<AuthorizeToPickup> AuthorizeToPickup { get; set; }
    }
}
