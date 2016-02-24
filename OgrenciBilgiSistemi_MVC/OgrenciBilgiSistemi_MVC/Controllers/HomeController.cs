using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciBilgiSistemi_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Trakya Üniversitesi";
            return View();
        }

        public ActionResult GirisYap()
        {
            return View();
        }       
    }
}