using ShopItems.DAL;
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
        // GET: Customer
        public ActionResult Index()
        {
            return View(repo.GetItems());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.GetItemByID(id));
        }
    }
}
