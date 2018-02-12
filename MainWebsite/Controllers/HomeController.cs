﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        // TODO: Infrastructure folder
        // TODO: Convert into an async controller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailDetails emailDetails)
        {
            // for debug
            //var myEmailAccount = System.Configuration.ConfigurationManager.AppSettings["mailAccount"];
            //var apiKey = System.Configuration.ConfigurationManager.AppSettings["SENDGRID_APIKEY"];

            // for live deployment
            var myEmailAccount = System.Environment.GetEnvironmentVariable("mailAccount");
            var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");

            var client = new SendGridClient(apiKey);

            if (ModelState.IsValid)
            {
                StringBuilder emailBody = new StringBuilder()
                .AppendLine("You have recieved an email from your site from ")
                    .AppendLine(emailDetails.Name);
                emailBody.Append(Environment.NewLine);
                emailBody.AppendLine(emailDetails.Message);
                emailBody.Append(Environment.NewLine);
                emailBody.AppendLine("Email Address: ")
                    .AppendLine(emailDetails.EmailAddress);
                emailBody.Append(Environment.NewLine);
                emailBody.Append("-----------------------------------------------");
                emailBody.Append(Environment.NewLine);
                emailBody.AppendFormat(" -- Audio: {0} --",
                        emailDetails.Audio ? "Yes" : "No");
                emailBody.AppendFormat(" Website: {0} --",
                        emailDetails.Website ? "Yes" : "No");
                emailBody.AppendFormat(" Programming: {0} -- ",
                        emailDetails.Programming ? "Yes" : "No");

                var message = new SendGridMessage()
                {
                    From = new EmailAddress(emailDetails.EmailAddress, emailDetails.Name),
                    Subject = "New Email From Your Site",
                    PlainTextContent = emailBody.ToString()
                };
                message.AddTo(new EmailAddress(myEmailAccount, "Kimiko"));

                try
                {
                    await client.SendEmailAsync(message);

                    ViewBag.Status = "Your email was successfully sent :)";
                }
                catch (Exception)
                {
                    ViewBag.Status = "Unfortunately, there was a problem sending your email.";
                }
                return View("Thankyou", emailDetails);
            };

            return View("Contact");
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