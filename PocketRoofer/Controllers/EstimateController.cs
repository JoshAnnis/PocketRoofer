using PocketRoofer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PocketRoofer.Controllers
{
    public class EstimateController : Controller
    {
        // GET: Estimate
        [HttpGet]
        public ActionResult Index()
        {
            ApplicationDbContext pkr = new ApplicationDbContext();
            List<EstimateViewModel> models = pkr.Estimate.ToList();
            return View(models);
        }

        public ActionResult EstimateDetails(int Id)
        {
            ApplicationDbContext pkr = new ApplicationDbContext();
            EstimateViewModel models = pkr.Estimate.Single(est => est.Id == Id);
            return View(models);
        }

        // Post: Estimate
        [HttpPost]
        public ActionResult SaveEstimate()
        {
            string address = Request.Form["address"].ToString();
            decimal bundleArea = Convert.ToDecimal(Request.Form["adjustedArea"].ToString());

            EstimateViewModel model = new EstimateViewModel();
            model.address = address;
            model.bundle = Convert.ToInt32(bundleArea /100 * 3);
            model.Email = Convert.ToString(User.Identity.Name);
            using (var pkr = new ApplicationDbContext())
            {
                EstimateViewModel est = new EstimateViewModel();
                est.address = model.address;
                est.bundle = model.bundle;
                est.Email = model.Email;
                pkr.Estimate.Add(est);
                pkr.SaveChanges();
            }
            return View(model);
        }

        // Post: Gutter
        [HttpPost]
        public ActionResult SaveGutter()
        {
            return View();
        }

        // Post: Area
        //[HttpPost]
        //public ActionResult SaveArea()
        //{
        //    return View();
        //}
    }
}


