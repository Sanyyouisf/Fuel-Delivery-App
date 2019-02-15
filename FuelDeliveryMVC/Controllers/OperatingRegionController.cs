using FuelDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryMVC.Controllers
{
    // GET: OperatingRegion
    public class OperatingRegionController : Controller
    {
        private AppDbContext context = new AppDbContext();
        // GET: OperatingRegion
        public ActionResult Index(int id)
        {
            //by creating instance of the AppDbContext class it will use the connections string 
            //that in the web config file to creat the connection for us

            //return single region
            OperatingRegion region = context.OperatingRegions.FirstOrDefault(s => s.regionId == id);
            return View(region);
        }
    }
}