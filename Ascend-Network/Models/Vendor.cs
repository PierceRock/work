using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ascend_Network.Models
{
    /// <summary>
    /// Vendors that will log in.
    /// </summary>
    public class Vendor
    {
        public Vendor() { }

        [Key]
        public int VendID { get; set; }

        public string FirstName { get; set;}

        public string LastName  { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public string  Address1 { get; set; }

        public string Address2 { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime LastActiveDate { get; set; }

     



    }
}
