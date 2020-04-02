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
        public DateTime dateRented { get; set; }
        [DataType(DataType.Date)]
        public DateTime dueDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateReturned { get; set; }
        [DataType(DataType.Date)]
        public DateTime pickupDate { get; set; }
        public String contact { get; set; }
        public String orNumber { get; set; }
        public String address { get; set; }
        public String partialPayment { get; set; }
        public String balance { get; set; }
        public String securityDeposit { get; set; }
    }
}
