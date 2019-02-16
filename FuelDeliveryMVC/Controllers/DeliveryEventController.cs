using FuelDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryMVC.Controllers
{
    public class DeliveryEventController : Controller
    {
        private AppDbContext db = new AppDbContext(); 
        
        // GET: DeliveryEvent by id
        [HttpGet,Route("DeliveryEvent/Details/{id}")]
        public ActionResult Details(int id)
        {
            DeliveryEvent delivery = db.deliveryEvent.Find(id);
            return View(delivery);
        }

        // GET: All DeliveryEvent 
        [HttpGet, Route("DeliveryEvent/Index")]
        public ActionResult Index()
        {
            List<DeliveryEvent> deliveriesList = db.deliveryEvent.ToList();
            return View(deliveriesList);
        }
    }
}