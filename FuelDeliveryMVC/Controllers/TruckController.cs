using FuelDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryMVC.Controllers
{
    public class TruckController : Controller
    {
        private AppDbContext db = new AppDbContext();
        // GET: Truck
        [HttpGet,Route("Truck/Index")]
        public ActionResult Index()
        {
            IEnumerable<Truck> trucksList = db.truck.ToList();
            return View(trucksList);
        }

        //get truck details
        [HttpGet, Route("Truck/Details/{id}")]
        public ActionResult Details(int id)
        {
            Truck truck = db.truck.Find(id);
            return View(truck);
        }
    }
}