using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class EditButtonModel
    {
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public int SubscriptionId { get; set; }
        public string Link { get
            {
                //? - URL parameters begin
                var s = new StringBuilder("?");
                if (ItemId > 0) s.Append(String.Format("{0}={1}&", "itemId", ItemId));
                if (ProductId > 0) s.Append(String.Format("{0}={1}&", "productId", ProductId));
                if (SubscriptionId > 0) s.Append(String.Format("{0}={1}&", "subscriptionId", SubscriptionId));
                //removing last "&"
                return s.ToString().Substring(s.Length - 1);

            } }
    }
}