using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _44Resources.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Default controller...
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
        public ActionResult login()
        {
            return View();
        }

        public ActionResult newassociate()
        {
            return View();
        }
        public ActionResult Associates()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult login()
        //{
        //    //Account createAccount = new Account();

        //    //createAccount.Username = userName;
        //    //createAccount.Email = email;
        //    //createAccount.Password = password;

        //    return View("Index");

        //}
    }
}