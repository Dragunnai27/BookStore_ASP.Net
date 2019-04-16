using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;
using BookStore.DatabaseContext;
using System.Data.Entity;


namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registry(string UserName, string Password)
        {
            User user = new User() { UserName = UserName, Password = Password };
            using (var db = new BookStoreContext())
            {
                db.TbUser.Add(user);
                db.SaveChanges();
                db.Dispose();
            }
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}