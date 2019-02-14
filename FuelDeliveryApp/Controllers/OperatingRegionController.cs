using FuelDeliveryApp.DataModels;
using FuelDeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryApp.Controllers
{
    public class OperatingRegionController : Controller
    {
        //GET: OperatingRegion
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            //ViewBag.Title = "Operationg Region Page Sany";
            //OperatingRegions region = new OperatingRegions()
            //{
            //    regionId = 1,
            //    regionName = "Nashville"
            //};


            return View(db.OperatingRegions.ToList());
        }

        //get all the operating regions
        //public List<string> Index()
        //{


        //    return;
        //}
    }
}