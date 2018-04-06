using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ascend_Network.Models;

namespace Ascend_Network.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Data Source = (localdb)\mssqllocaldb; AttachDbFilename =| DataDirectory | Ascend_Network.Models.BusinessContext.mdf; Initial Catalog = Ascend_Network.Models.BusinessContext; Integrated Security = True; MultipleActiveResultSets = True

            using (var ctx = new BusinessContext())
            {
                var vend = new Vendor()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Address1 = "123 story ln ",
                    Address2 = "suite 440",
                    PhoneNumber = "5164285402",
                    CompanyName = "Acme Widgets",
                    JoinDate = DateTime.Now,
                    LastActiveDate = DateTime.Now,                    
                    VendID=1
                };
                ctx.Vendors.Add(vend);
                ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}