using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace BT2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult BaiBao()
        {
            return View();
        }
        public ActionResult CongThuc()
        {
            return View();
        }
        public ActionResult Bai3()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Intro()
        {
            return View();
        }
        public ActionResult Bai2Lap1b()
        {
            return View();
        }
        public ActionResult Bai3Lab1b()
        {
            return View();
        }
        public ActionResult Bai2Lab1c() 
        {
            return View();
        }
        public ActionResult Bai3Lap1c()
        {
            return View();
        }
        public ActionResult Bai4Lap1c()
        {
            return View();
        }

    }
}