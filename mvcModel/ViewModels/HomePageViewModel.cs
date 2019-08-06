using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcModel.Models;

namespace mvcModel.ViewModels
{
    public class HomePageViewModel
    {
        public Kisi KisiNesnesi { get; set; }
        public Adres AdresNesnesi { get; set; }
    }
}