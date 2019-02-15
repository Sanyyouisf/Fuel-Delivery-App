using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FuelDeliveryMVC.Models
{
    //the perpose of this AppDbContext class to staplish a connection with the database
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("FuelDelivery") { }

        public DbSet<OperatingRegion> operatingRegion { get; set; }

        public DbSet<Customer> customer { get; set; }

        public DbSet<Driver> driver { get; set; }

        public DbSet<Truck> truck { get; set; }
    }
}