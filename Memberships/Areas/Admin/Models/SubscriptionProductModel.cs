using Memberships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class SubscriptionProductModel
    {
        [DisplayName("Product ID")]
        public int ProductId { get; set; }
        [DisplayName("Item ID")]
        public int SubscriptionId { get; set; }
        [DisplayName("Product Title")]
        public string ProductTitle { get; set; }
        [DisplayName("Subscription Title")]
        public string SubscriptionTitle { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}