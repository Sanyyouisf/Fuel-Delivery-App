using FuelDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryMVC.Controllers
{
    public class OperatingRegionController : Controller
    {
        // GET: OperatingRegion
        public ActionResult Index()
        {
            OperatingRegion region = new OperatingRegion()
            {
                regionId = 1,
                regionName = "Nashville"
            };
            return View();
        }
    }
}