using ShopItems.DAL;
using ShopItems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopItems.Controllers
{
    public class ShopItemsController : Controller
    {
        private IShopItemRepository repo;

        public ShopItemsController(IShopItemRepository shopRepo)
        {
            repo = shopRepo;
        }
        // GET: ShopItems
        public ActionResult Index()
        {
            return View(repo.GetItems());
        }

        // GET: ShopItems/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.GetItemByID(id));
        }

    }
}
