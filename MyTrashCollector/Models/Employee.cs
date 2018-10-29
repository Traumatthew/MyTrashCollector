using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Display(Name = "Route Zip Code")]
        public string RouteZipCode { get; set; }
    }
}