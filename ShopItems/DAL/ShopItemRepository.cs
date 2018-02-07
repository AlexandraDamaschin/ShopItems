using ShopItems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopItems.DAL
{
    public class ShopItemRepository :IShopItemRepository, IDisposable
    {
        ShopItemsContext context;
        
        public ShopItemRepository(ShopItemsContext context)
        {
            this.context = context;
        }

        public void DeleteItem (int ItemID)
        {

        }

        public ShopItem GetItemByID(int itemID)
        {

        }

        public  IEnumerable<ShopItem> GetItems()
        {

        }

        public void InsertItem (ShopItem item)
        {

        }

        public void Save()
        {
          
        }

        public void UpdateItem (ShopItem item)
        {

        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}