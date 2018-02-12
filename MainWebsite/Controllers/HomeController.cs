using System.Threading.Tasks;
using System.Web.Mvc;
using MainWebsite.Models;
using MainWebsite.Infrastructure;

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

        // CODE REVIEW TODO: Questions - 1. How is this conversion into an async controller? Is it better to rename Contact to ContactAsync and reroute the submit from the Contact View, or leave as is?
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailDetails emailDetails, EmailProcessor emailProcessor)
        {
            if (ModelState.IsValid)
            {
                await emailProcessor.ProcessEmailAsync(emailDetails);
                ViewBag.Status = emailDetails.StatusMessage;
                return View("Thankyou", emailDetails);
            };

            // return empty form if invalid
            return View("Contact");
        }

        // Temporary test for the 500 error
        public ActionResult Test(int testInt)
        {
            return RedirectToAction("Index");
        }
    }
}