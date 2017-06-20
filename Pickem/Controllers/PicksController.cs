using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pickem.Controllers
{
    public class PicksController : Controller
    {
        // GET: Picks
        public ActionResult Index()
        {
            return View();
        }
    }
}