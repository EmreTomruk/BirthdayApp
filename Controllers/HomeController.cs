using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DavetiyeFormu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DavetiyeFormu(Davetiye  model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);

                return View("Thanks", model);
            }
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Katilanlar()
        {
            var katilanlar = Veritabani.Liste.Where(k => k.KatilmaDurumu == true);   

            return PartialView(katilanlar);
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