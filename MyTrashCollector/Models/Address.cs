using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyTrashCollector.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [ForeignKey("ZipCodes")]
        public int ZipCodeId { get; set; }
        public ZipCodes ZipCodes { get; set; }
       
    }
}