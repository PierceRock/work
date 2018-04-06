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

            //using (var ctx = new BusinessContext())
            //{
            //    var vend = new Vendor()
            //    {
            //        FirstName = "John",
            //        LastName = "Doe",
            //        Address1 = "123 story ln ",
            //        Address2 = "suite 440",
            //        PhoneNumber = "5164285402",
            //        CompanyName = "Acme Widgets",
            //        JoinDate = DateTime.Now,
            //        LastActiveDate = DateTime.Now,                    
            //        VendID=1
            //    };
            //    ctx.Vendors.Add(vend);
            //    ctx.SaveChanges();
            //}
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us. bla bla bla bla bla";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our Contacts....";

            return View();
        }
        public ActionResult Specials()
        {
            ViewBag.Message = " This is where we have all types of seasonal information that is related to who knows.";
           

                return View();
        }

    }
}