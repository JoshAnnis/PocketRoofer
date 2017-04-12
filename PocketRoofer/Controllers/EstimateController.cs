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
            return View();
        }

        //public ActionResult MakeEstimate()
        //{
        //    ViewBag.Message = "Your estimation page.";

        //    return View("GenerateEstimate");
        //}

        // Post: Estimate
        [HttpPost]
        public ActionResult SaveEstimate()
        {
            string address = Request.Form["address"].ToString();
            decimal bundleArea = Convert.ToDecimal(Request.Form["adjustedArea"].ToString());
            EstimateViewModels model = new EstimateViewModels();

            model.address = address;
            model.bundle = Convert.ToInt32(bundleArea / 100 * 3);
            model.Email = Convert.ToString(User.Identity.Name);
           
            return View(model);
        }

        // Post: Area
        [HttpPost]
        public ActionResult SaveArea()
        {
            //var bundles = estimateRoofArea * 100 / 3;
            return View();
        }
        // Post: Gutter

        [HttpPost]
        public ActionResult SaveGutter()
        {
            return View();
        }
    }
}


