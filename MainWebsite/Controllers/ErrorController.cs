using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainWebsite.Controllers
{
    public class ErrorController : Controller
    {
        // GET: ErrorHandler
        public ActionResult Default()
        {
            return View();
        }

        // 400 status code
        public ActionResult NotFound()
        {
            return View();
        }

        // 500 status code
        public ActionResult InternalServerError()
        {
            return View();
        }
    }
}