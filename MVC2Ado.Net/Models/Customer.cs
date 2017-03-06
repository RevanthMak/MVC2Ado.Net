using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2Ado.Net.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage ="Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Enter Mobile Number")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage ="Enter Id")]
        public string EmailId { get; set; }

        [Required(ErrorMessage ="Enter Date of Birth")]
        public DateTime BirthDate { get; set; }

        public List<Customer> GetAllCustomers { get; set; }
    }
}