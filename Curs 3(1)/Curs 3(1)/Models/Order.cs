using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curs_3_1_.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Nume { get; set; }

    }
}