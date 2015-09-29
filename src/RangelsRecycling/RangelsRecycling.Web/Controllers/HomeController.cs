using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RangelsRecycling.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Rangel's Recycling";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Rangel's Recylcing";

            return View();
        }

        public ActionResult CRV()
        {
            ViewBag.Message = "California Refund Value";
            return View();
        }

        public ActionResult Rates()
        {
            ViewBag.Message = "Our Current Rates";
            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "Frequently Asked Questions";
            return View();
        }

        public ActionResult Hours()
        {
            ViewBag.Message = "Our Current Hours";
            return View();
        }
    }
}