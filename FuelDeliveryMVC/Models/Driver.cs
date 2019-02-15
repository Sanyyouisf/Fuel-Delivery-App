using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FuelDeliveryMVC.Models
{
    [Table("Driver")]
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }

        public string DriverName { get; set; }

        public string driverAddress { get; set; }

        public string driverPhoneNumder { get; set; }

        [DefaultValue(true)]
        public bool driverFullTime { get; set; }

    }
}