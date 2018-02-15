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
            if (ModelState.IsValid)
            {
                db.ShopItems.Add(shopItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopItem);
        }

        // GET: ShopItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopItem shopItem = db.ShopItems.Find(id);
            if (shopItem == null)
            {
                return HttpNotFound();
            }
            return View(shopItem);
        }

        // POST: ShopItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Cost,Class,ImageUrl")] ShopItem shopItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopItem);
        }

        // GET: ShopItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopItem shopItem = db.ShopItems.Find(id);
            if (shopItem == null)
            {
                return HttpNotFound();
            }
            return View(shopItem);
        }

        // POST: ShopItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShopItem shopItem = db.ShopItems.Find(id);
            db.ShopItems.Remove(shopItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
