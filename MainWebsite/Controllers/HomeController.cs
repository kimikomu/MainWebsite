using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Code()
        {
            return View();
        }

        public ActionResult Sites()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        // modal form
        //public ViewResult Modal(EmailDetails emailDetails)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return View("Code", "Home");
        //    }
        //    // return with validation error(s)
        //    return View("Sites", "Home");
        //}

        // Temporary test for the 500 error
        public ActionResult Test(int testInt)
        {
            return RedirectToAction("Index");
        }
    }
}