using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTrashCollector.Models
{
    public class ZipCodes
    {
        [Key]
        public int ZipCodeId { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCodeNumber { get; set; }
    }
}