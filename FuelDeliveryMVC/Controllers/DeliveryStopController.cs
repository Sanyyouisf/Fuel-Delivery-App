using FuelDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryMVC.Controllers
{
    public class DeliveryStopController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: DeliveryStop by id
        [HttpGet, Route("DeliveryStop/Details/{id}")]
        public ActionResult Details(int id)
        {
            DeliveryStop deliveryStop = db.deliveryStop.Find(id);
            return View(deliveryStop);
        }

        // GET: All DeliveryStops 
        [HttpGet, Route("DeliveryStop/Index")]
        public ActionResult Index()
        {
            List<DeliveryStop> deliveryStopsList = db.deliveryStop.ToList();
            return View(deliveryStopsList);
        }
    }
}