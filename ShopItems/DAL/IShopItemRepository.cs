﻿using ShopItems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItems.DAL
{
    public interface IShopItemRepository: IDisposable
    {
        IEnumerable<ShopItem> GetItems();
        ShopItem GetItemByID(int userID);

        void InsertItem(ShopItem Item);
        void UpdateItem(ShopItem Item);
        void DeleteItem(int  ItemID);

        void Save();
    }
}
