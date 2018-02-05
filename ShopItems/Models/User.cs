using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopItems.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Username { get; set; }
        public double Balance { get; set; }

        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}