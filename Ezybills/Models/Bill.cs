using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ezybills.Models;

namespace EzyBills.Models
{
    public class Bill
    {
        [Required]
<<<<<<< HEAD
        [Display(Name ="Vendor")]
        public int BillVendorID { get; set; }
        public virtual Vendor Vendor { get; set; }


        [Required]
        [Display(Name ="Customer")]
        public int BillCustomerID { get; set; }
        public virtual Customer Customer { get; set; }
=======
       
        public int BillVendorID { get; set; }

        [Required]

        public int BillCustomerID { get; set; }
>>>>>>> f8854fddcfa0a376030405a3a8710b490387e8f7

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }

        [Display(Name = "Total")]
        public double Total_Bill;


        [Display(Name ="Date")]
        public DateTime dateOfPurchase { get; set; }
    }
}