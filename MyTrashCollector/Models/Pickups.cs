using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyTrashCollector.Models
{
    public class Pickups
    {
        [Key]
        public int PickUpId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Display(Name ="Start Day")]
        public DateTime? StartDay { get; set; }

        [Display(Name = "End Day")]
        public DateTime? EndDay { get; set; }

        [Display(Name = "Pick Up Day")]
        public DateTime? PickUpDay { get; set; }

        [Display(Name = "Bonus Pick Up Day")]
        public DateTime? BonusPickUp { get; set; }

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }


    }
}