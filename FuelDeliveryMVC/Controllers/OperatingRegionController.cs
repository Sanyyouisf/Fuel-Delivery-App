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
        [HttpGet, Route ("OperatingRegion/Details/{id}")]
        public ActionResult Details(int id)
        {
            //return single region details
            // OperatingRegion region = db.OperatingRegion.FirstOrDefault(s => s.regionId == id);
            //return View(region);

            //return all the customers for certain region
            IQueryable<Customer> customersRegion =  db.customer.Where(c => c.regionId == id);
            return View(customersRegion);
        }

        //get All the Operating Regions
        [HttpGet,Route("OperatingRegion/Index")]
        //public IEnumerable<OperatingRegion> Index()
        public ActionResult Index()
        {
            List<OperatingRegion> RegionList = db.OperatingRegion.ToList();
            return View(RegionList);
        }

    }
}