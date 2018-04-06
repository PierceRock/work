using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Ascend_Network.Models
{
    public class BusinessContext : DbContext
    {
        public BusinessContext(): base() { }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }

    }
}