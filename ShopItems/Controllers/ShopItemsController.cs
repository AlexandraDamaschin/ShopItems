using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopItems.DAL;
using ShopItems.Models;

namespace ShopItems.Controllers
{
    public class ShopItemsController : Controller
    {
        //private ShopItemsContext db = new ShopItemsContext();

        private IShopItemRepository shopRepo;

        public ShopItemsController()
        {
            shopRepo = new ShopItemRepository(new ShopItemsContext());
        }

        // GET: ShopItems
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShopItems/Details/5
        public ActionResult Details(int id)
        {
            return View(shopRepo.GetItemByID(id));

        }

        // GET: ShopItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Cost,Class,ImageUrl")] ShopItem shopItem)
        {
            return View();

        }

        // GET: ShopItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View();

        }

        // POST: ShopItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Cost,Class,ImageUrl")] ShopItem shopItem)
        {
            return View(shopItem);
        }

        // GET: ShopItems/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: ShopItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            return View();

        }

        protected override void Dispose(bool disposing)
        {
        }
    }
}
