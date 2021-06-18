using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Praktika.Models
{
    public class Dostavka
    {
        [Key]
        public int ID { get; set; }
        public string  NamE { get; set; }
        public string  Adress { get; set; }
        public string Phone { get; set; }
        public  int PriceDostavki { get; set; }
        public int? StatID { get; set; }
    }
}