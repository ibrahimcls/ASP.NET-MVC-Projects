using mvcModel.Models;
using mvcModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace mvcModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            Kisi admin = new Kisi();
            admin.Ad = "ibrahim";
            admin.Soyad = "calis";
            admin.yas = 21;
            Adres ev = new Adres();
            ev.il = "istanbul";
            ev.ilce = "bagcilar";
            ev.adresKisi = admin;
            HomePageViewModel newmodel = new HomePageViewModel();
            newmodel.KisiNesnesi = admin;
            newmodel.AdresNesnesi = ev;
            return View(newmodel);
        }

        [HttpPost]
        public ActionResult HomePage(HomePageViewModel model)
        {
            return RedirectToAction("HomePage");
        }
    }
}