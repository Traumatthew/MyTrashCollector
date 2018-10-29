using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyTrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name ="Zip Code")]
        public string Zipcode { get; set; }

        [Display(Name = "Start Day")]
        public DateTime StartDay { get; set; }

        [Display(Name = "End Day")]
        public DateTime EndDay { get; set; }

        [Display(Name = "Pick Up Day")]
        public string PickupDay { get; set; }

        [Display(Name = "Account Balance")]
        public decimal AccountBalance { get; set; }
    }
}