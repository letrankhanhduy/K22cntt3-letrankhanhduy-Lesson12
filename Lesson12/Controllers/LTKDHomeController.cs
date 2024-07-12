using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson12.Controllers
{
    public class LTKDHomeController : Controller
    {
        public ActionResult LTKDIndex()
        {
            return View();
        }

        public ActionResult LTKDAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LTKDContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}