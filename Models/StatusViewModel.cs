using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Web.Mvc;

namespace Praktika.Models
{
    public partial class StatusViewModel
    {
        public int StatusId { get; set; }
       
        public List<SelectListItem> Status { get; set; }
        public int  ID { get; set; }
        
        public string NamE { get; set; }
        
        public string Adress { get; set; }
       
        public string Phone { get; set; }

        public int PriceDostavki { get; set; }
}
}