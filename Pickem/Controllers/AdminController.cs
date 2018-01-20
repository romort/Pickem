using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace Pickem.Controllers
{

    // Hard-coding the email address that is authorized to get to the AdminController because it's quick and easy for now.
    // Maybe in the future use a better method by using Identity Roles or some other method.
    [Authorize(Users = "rodneymort@gmail.com")]
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TeamEdit()
        {
            return View();
        }
    }
}