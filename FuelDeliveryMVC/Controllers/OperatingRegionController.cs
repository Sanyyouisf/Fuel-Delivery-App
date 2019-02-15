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
        //by creating instance of the AppDbContext class it will use the connections string (Which should have the same name)
        //that in the web config file to creat the connection for us
        private AppDbContext db = new AppDbContext();

        // GET: OperatingRegion by id
        [HttpGet, Route ("OperatingRegion/Index/{id}")]
        public ActionResult Index(int id)
        {
            //return single region
            OperatingRegion region = db.OperatingRegions.FirstOrDefault(s => s.regionId == id);
            return View(region);
        }

        //get All the Operating Regions
        [HttpGet,Route("OperatingRegion/Index")]
        public IEnumerable<OperatingRegion> Index()
        {
            IEnumerable<OperatingRegion> RegionList = db.OperatingRegions.ToList();
            return RegionList;
        }

    }
}