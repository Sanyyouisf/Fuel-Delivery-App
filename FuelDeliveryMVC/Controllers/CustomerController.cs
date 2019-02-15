using FuelDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelDeliveryMVC.Controllers
{
    public class CustomerController : Controller
    {
        private AppDbContext db = new AppDbContext();

        //Get Customer By Id
        [HttpGet, Route("Customer/Details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = db.customer.Find(id);
            return View(customer);       
        }
        
        // GET: Customer All Customers
        [HttpGet,Route("Customer/Index")]
        public ActionResult Index()
        {
            List<Customer> customerList = db.customer.ToList();
            return View(customerList);
        }
    }
}