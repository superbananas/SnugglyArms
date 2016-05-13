using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class PackageNote
    {
        public int PackageNoteId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModified { get; set; }
        public string Note { get; set; }
        public int PackageId { get; set; }

        public virtual Package Package { get; set; }
    }
}
