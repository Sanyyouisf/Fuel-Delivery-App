using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FuelDeliveryApp.DataModels
{
    public class OperatingRegions
    {
        [Key]
        public int regionId { get; set; }

        public string regionName { get; set; }
    }
}