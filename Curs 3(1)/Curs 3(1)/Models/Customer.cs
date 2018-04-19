using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curs_3_1_.Models
{
    public class Customer
    {
        
            public string Id { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }

            public int OrderId { get; set; }
            public Order Order { get; set; }
        }

    }
