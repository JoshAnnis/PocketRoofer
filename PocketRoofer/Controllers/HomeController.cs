using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using MVCEmail.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using PocketRoofer.Models;

namespace PocketRoofer.Controllers
{
    [System.Runtime.InteropServices.Guid("D605B378-B9F1-4FC9-B46C-5AAD66C6AC9B")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                ApplicationDbContext pkr = new ApplicationDbContext();
                List<EstimateViewModel> models = pkr.Estimate.ToList();
                return View("AdminIndex",models);
            }
            else if (User.IsInRole("User"))
            {
                return View("RegisteredUser");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        public ActionResult AdminIndex()
        {
            ApplicationDbContext pkr = new ApplicationDbContext();
            List<EstimateViewModel> models = pkr.Estimate.ToList();
            return View(models);
        }

        [HttpGet]
        public ActionResult EstimateDetails(int Id)
        {
            ApplicationDbContext pkr = new ApplicationDbContext();
            EstimateViewModel models = pkr.Estimate.Single(est => est.Id == Id);
            return View(models);
        }
        public ActionResult GoHome()
        {

            return View("Index");
        }

        public ActionResult Email()
        {
            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("e490c4bbb3aa75", "ab43f3cf77703d"),
                EnableSsl = true
            };
            client.Send("from@example.com", "to@example.com", "Hello world", "Your estimate here.");
            return View("RegisteredUser");
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Contact(EmailFormModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
        //        var message = new MailMessage();
        //        message.To.Add(new MailAddress("recipient@gmail.com"));   replace with valid value 
        //        message.From = new MailAddress("flyboy1209.jd@gmail.com");  
        //        message.Subject = "Your email subject";
        //        message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
        //        message.IsBodyHtml = true;
        //        message.Attachments.Add(new Attachment(HttpContext.Server.MapPath("~/App_Data/Test.docx")));
        //        using (var smtp = new SmtpClient())
        //        {
        //            await smtp.SendMailAsync(message);
        //            return RedirectToAction("Sent");
        //        }

        //    }
        //    return View(model);
        //}
        //public ActionResult Sent()
        //{
        //    return View();
        //}
    }
}