using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StXavierParents.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome St Xavier Parents.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This site was built to help parents with some of their common questions";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Steve is you have questions about the info here or new questions we have not answered yet.";

            return View();
        }
    }
}
