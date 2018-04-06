using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Ascend_Network.Models
{
    /// <summary>
    /// requested work from vendor
    /// </summary>
    public class WorkOrder
    {
        public WorkOrder() { }
        [Key]
        public string  WorkOrderNumber { get; set; }
                
        [Required]
        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress1 { get; set; }

        public string CustomerAddress2 { get; set; }

        public string CustomerCity { get; set; }

        public string CustomerState { get; set; }
        
        [Required]
        public string Description { get; set; }

        public string VendorId { get; set; }
    }
}
