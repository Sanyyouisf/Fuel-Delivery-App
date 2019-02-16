using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FuelDeliveryMVC.Models
{
    [Table("DeliveryEvent")]
    public class DeliveryEvent
    {
        [Key]
        public int deliveryEventId { get; set; }

        public int truckId { get; set; }

        public DateTime eventDate { get; set; }
    }
}
