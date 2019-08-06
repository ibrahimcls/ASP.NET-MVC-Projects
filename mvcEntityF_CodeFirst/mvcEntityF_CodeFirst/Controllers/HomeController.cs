using mvcEntityF_CodeFirst.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcEntityF_CodeFirst.Models;
using mvcEntityF_CodeFirst.ViewModels.Home;

namespace mvcEntityF_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        //private int kisiler;

        // GET: Home
        public ActionResult HomePage()
        {
            DatabaseContext db = new DatabaseContext();
            //List<Kisi> kisiler = db.kisiler.ToList();
            //List<Adres> adresler = db.adresler.ToList();

            HomePageVM model = new HomePageVM();

            model.Adresler = db.adresler.ToList(); ;
            model.Kisiler = db.kisiler.ToList(); ;

            return View(model);
        }
        public ActionResult YeniAdres()
        {
            return View();
        }
    }
}