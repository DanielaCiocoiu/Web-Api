using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Curs_3_1_.Models
{
    public class Customer
    {
        //va ajunge in baza de date unde va fi o tabela cu 3 coloane
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }

}
