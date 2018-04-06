using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ascend_Network.Models
{
    public class User
    {
        //https://stackoverflow.com/questions/1970655/asp-net-mvc-and-login-authentication 
        // add the other authentication bits to fit needs.
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string VendId { get; set; }

        public bool IsAdmin { get; set; }
    }
}