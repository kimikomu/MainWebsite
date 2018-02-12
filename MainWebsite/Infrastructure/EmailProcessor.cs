using System;
using System.Text;
using System.Threading.Tasks;
using MainWebsite.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace MainWebsite.Infrastructure
{
    public class EmailProcessor
    {
        public async Task ProcessEmailAsync(EmailDetails emailDetails)
        {
            // for debug
            //var myEmailAccount = System.Configuration.ConfigurationManager.AppSettings["mailAccount"];
            //var apiKey = System.Configuration.ConfigurationManager.AppSettings["SENDGRID_APIKEY"];

            // for release
            var myEmailAccount = System.Environment.GetEnvironmentVariable("mailAccount");
            var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");

            var client = new SendGridClient(apiKey);
            var emailAccountName = "Kimiko";

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
            message.AddTo(new EmailAddress(myEmailAccount, emailAccountName));

            try
            {
                await client.SendEmailAsync(message);

                emailDetails.StatusMessage = "Your email was successfully sent :)";
            }
            catch (Exception)
            {
                emailDetails.StatusMessage = "Unfortunately, there was a problem sending your email.";
            }
        }
    }
}
