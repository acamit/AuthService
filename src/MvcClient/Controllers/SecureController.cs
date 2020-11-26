using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcClient.Controllers
{
    public class SecureController : Controller
    {
        // GET: Secure
        [Route("signin-oidc")]
        public ActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}