using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopItems.Models
{
    public enum ItemClass
    {
        Health,
        Magic,
        Stamina
    }

    public class ShopItems
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public double Cost { get; set; }
        public ItemClass Class { get; set; }

        public string ImageUrl { get; set; }
    }
}