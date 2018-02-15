using ShopItems.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopItems.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository userRepo;
        public UserController(IUserRepository repo)
        {
            userRepo = repo;
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View(userRepo.GetUsers());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(userRepo.GetUserByID(id));
        }

    }
}
