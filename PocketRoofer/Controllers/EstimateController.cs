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
        public ActionResult Index()
        {
            return View();
        }

        // Post: Estimate
        [HttpPost]
        public ActionResult SaveEstimate()
        {
            return View();
        }
        // Post: Area
        [HttpPost]
        public ActionResult SaveArea()
        {
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


