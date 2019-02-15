using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FuelDeliveryMVC.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int customerId { get; set; }

        public int regionId { get; set; }

        public string customerName { get; set; }

        public string customerAddress { get; set; }

        public decimal maxNoOfGallons { get; set; }
    }
}