using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Ascend_Network.Models;




namespace Ascend_Network.Controllers
{
    public class AccountController : Controller
    {
        UserApplication userApp = new UserApplication();
        SessionContext context = new SessionContext();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var authenticatedUser = userApp.GetByUsernameAndPassword(user);
            if (authenticatedUser != null)
            {
                context.SetAuthenticationToken(authenticatedUser.UserId.ToString(), false, authenticatedUser);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");

        }
}