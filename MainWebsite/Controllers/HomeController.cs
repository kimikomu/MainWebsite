using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using MainWebsite.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

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

        [HttpPost]
        public ActionResult Contact(EmailDetails emailDetails)
        {

            //string username = System.Web.Configuration.WebConfigurationManager.AppSettings["mailAccount"];
            //string password = System.Web.Configuration.WebConfigurationManager.AppSettings["mailPassword"];

            //var username = System.Configuration.ConfigurationManager.AppSettings["mailAccount"];
            //var password = System.Configuration.ConfigurationManager.AppSettings["mailPassword"];

            var username = System.Environment.GetEnvironmentVariable("mailAccount");
            var password = System.Environment.GetEnvironmentVariable("mailPassword");

            var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
            var client = new SendGridClient(apiKey);


            StringBuilder emailBody = new StringBuilder()
            .AppendLine("An email from your site from ")
                .AppendLine(emailDetails.Name);
            emailBody.AppendLine("---");

            emailBody.AppendLine(emailDetails.Message);
            emailBody.AppendLine("---");
            emailBody.AppendLine("Email Address: ")
                .AppendLine(emailDetails.EmailAddress);
            emailBody.AppendFormat(" -- Audio: {0} --",
                    emailDetails.Audio ? "Yes" : "No");
            emailBody.AppendFormat(" Website: {0} --",
                    emailDetails.Website ? "Yes" : "No");
            emailBody.AppendFormat(" Programming: {0} -- ",
                    emailDetails.Programming ? "Yes" : "No");

            try
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;
                WebMail.EnableSsl = true;
                WebMail.UserName = username;
                WebMail.Password = password;

                WebMail.From = emailDetails.EmailAddress;

                WebMail.Send(username, "Email from you site from " + emailDetails.Name,
                    emailBody.ToString());

                ViewBag.Status = "Your email was successfully sent :)";
            }
            catch(Exception)
            {
                ViewBag.Status = "Problem while sending your email.";
            }

            return View("Thankyou", emailDetails);
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