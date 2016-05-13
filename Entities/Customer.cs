using System;
using System.Collections.Generic;

namespace Snuggly.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerPackage = new HashSet<CustomerPackage>();
        }

        public int CustomerId { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public DateTime LastModified { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }

        public virtual ICollection<CustomerPackage> CustomerPackage { get; set; }
    }
}
