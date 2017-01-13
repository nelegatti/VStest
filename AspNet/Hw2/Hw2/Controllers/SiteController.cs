using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hw2.Models;

namespace Hw2.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult GotoHome()
        {
            return View("GotoHome");
        }
        public ActionResult AboutUs()
        {
            return View("About");
        }
        public ActionResult SeeProduct()
        {
            return View("Product");
        }
    }
}