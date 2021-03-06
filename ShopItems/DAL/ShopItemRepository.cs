﻿using ShopItems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ShopItems.DAL
{
    public class ShopItemRepository : IShopItemRepository, IDisposable
    {
        ShopItemsContext context;

        public ShopItemRepository(ShopItemsContext context)
        {
            this.context = context;
        }

        //•	DeleteItem should delete the user with the matching ID
        public void DeleteItem (int ItemID)
        {
            ShopItem shopItem = context.ShopItems.Find(ItemID);
            context.ShopItems.Remove(shopItem);
            context.SaveChanges();
        }

        //•	GetItemByID should get the specified user with the matching ID
        public ShopItem GetItemByID(int itemID)
        {
            return context.ShopItems.Find(itemID);
        }

        //•	GetItems should return all Users
        public IEnumerable<ShopItem> GetItems()
        {
            return context.ShopItems.ToList();
        }

        //•	InsertItem should insert a new user
        public void InsertItem (ShopItem item)
        {
            context.ShopItems.Add(item);
            context.SaveChanges();

        }

        //•	Save should call context.SaveChanges
        public void Save()
        {
            context.SaveChanges();
        }

        //•	UpdateItem should set the state of the selected user to Modified
        public void UpdateItem (ShopItem item)
        {
            ShopItem shopItem = context.ShopItems.Find(item);

        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}