using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Item
    {
        public string Caption { get; set; }

        public string Description { get; set; }

        public class Image
        {
            public string Picture { get; set; }

            public string Thumbnail { get; set; }

            public string Name { get; set; }
        }

        public enum Status
        {

        }

        public string SKU { get; set; }

        public string UPC { get; set; }

        public class Price
        {
            public string Type { get; set; }

            public decimal Amount { get; set; }

            public DateTime EffectiveDate { get; set; }

            public DateTime ExpirationDate { get; set; }
        }

        public class Supplier
        {
            public string CompanyName { get; set; }

            public class Address
            {

            }

            public enum Type
            {

            }

            public class Contact
            {

            }
        }

    }

    public class Quantity
    {

    }

    public class Name
    {

    }
}
