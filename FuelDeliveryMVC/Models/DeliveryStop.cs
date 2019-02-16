using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FuelDeliveryMVC.Models
{
    [Table("DeliveryStop")]
    public class DeliveryStop
    {
        [Key]
        public int deliveryStopId { get; set; }

        public int customerId { get; set; }

        public int deliveryEventId { get; set; }

        public decimal noOfGallons { get; set; }
    }
}

