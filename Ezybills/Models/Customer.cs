using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.Net;
using System.Data;

namespace EzyBills.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name = "Username")]
        [Remote("UserNameDoesNotExit", "Customers", HttpMethod = "POST", ErrorMessage = "Username already exits!!")]
        public string UserName { get; set; }
        public string CustomerUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        private String CustomerPassword;



        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "Password")]
        public String SetCustomerPassword
        {
            get
            {
                return CustomerPassword;
            }
            set
            {
                CustomerPassword = value;
            }
        }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public String CustomerEmail { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Display(Name = "PhoneNo")]
        public string CustomerPhone { get; set; }



    }
}