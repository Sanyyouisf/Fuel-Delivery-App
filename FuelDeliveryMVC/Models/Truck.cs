using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FuelDeliveryMVC.Models
{
    [Table("Truck")]
    public class Truck
    {
        [Key]
        public int truckId { get; set; }

        public int driverId { get; set; }

        public int plateNumber { get; set; }

    }
}