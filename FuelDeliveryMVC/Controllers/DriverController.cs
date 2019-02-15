using FuelDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryMVC.Controllers
{   
    public class DriverController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: list of Driver
        [HttpGet,Route("Driver/Index")]
        public ActionResult Index()
        {
            IEnumerable<Driver> driversLis = db.driver.ToList();
            return View(driversLis);
        }

        // GET: Driver details
        [HttpGet, Route("Driver/Details/{id}")]
        public ActionResult Details(int id)
        {
            Driver driver = db.driver.Find(id);
            return View(driver);
        }


    }
}