using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        static List<string> liste = new List<string>();
        public ActionResult MyPage()
        {
            ViewBag.List = liste;
            return View();
        }
        [HttpPost]
        public ActionResult MyPage(string ad,string soyad)
        {
            liste.Add(ad + " " + soyad);
            return new RedirectToRouteResult(
                new System.Web.Routing.RouteValueDictionary(
                    new
                    {
                        action = "MyPage",
                        controller = "Home",
                        kod = Guid.NewGuid().ToString()
                    }));
        }

       
    }
}