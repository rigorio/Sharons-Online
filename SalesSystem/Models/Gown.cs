using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models
{
    public class Gown
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public Double price { get; set; }
        public String status { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "date rented")]
        public DateTime dateRented { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "duedate")]
        public DateTime dueDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "date returned")]
        public DateTime dateReturned { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "pickup date")]
        public DateTime pickupDate { get; set; }
        public String contact { get; set; }
        [Display(Name = "or #")]
        public String orNumber { get; set; }
        public String address { get; set; }
        [Display(Name = "partial pay")]
        public String partialPayment { get; set; }
        public String balance { get; set; }
        [Display(Name = "sec deposit")]
        public String securityDeposit { get; set; }
    }
}
