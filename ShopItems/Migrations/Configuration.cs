namespace ShopItems.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopItems.Models.ShopItemsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopItems.Models.ShopItemsContext context)
        {
            //users
            var users = new List<User>
            {
                new User() { Username = "JSmith", Balance = 200 },
                new User() { Username = "NGannon", Balance = 100 },
                new User() { Username = "SDoe", Balance = 1000 },
                new User() { Username = "MReilly", Balance = 750 }
            };

            //shop items
            var items = new List<ShopItem>
            {
                new ShopItem() { Name = "Small Health", Cost = 50, Class = ItemClass.Health, ImageUrl = "~/Content/Images/health_icon.png" },
                new ShopItem() { Name = "Big Health", Cost = 100, Class = ItemClass.Health, ImageUrl = "~/Content/Images/health_icon.png" },
                new ShopItem() { Name = "Small Magic", Cost = 50, Class = ItemClass.Magic, ImageUrl = "~/Content/Images/magic_icon.png" },
                new ShopItem() { Name = "Big Magic", Cost = 100, Class = ItemClass.Magic, ImageUrl = "~/Content/Images/magic_icon.png" },
                new ShopItem() { Name = "Small Stamina", Cost = 50, Class = ItemClass.Stamina, ImageUrl = "~/Content/Images/stamina_icon.png" },
                new ShopItem() { Name = "Big Stamina", Cost = 100, Class = ItemClass.Stamina, ImageUrl = "~/Content/Images/stamina_icon.png" }
            };

            users.ForEach(u => context.Users.Add(u));
            items.ForEach(i => context.ShopItems.Add(i));

            context.SaveChanges();
        }
    }
}
