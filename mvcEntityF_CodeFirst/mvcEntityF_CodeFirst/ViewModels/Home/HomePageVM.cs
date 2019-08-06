using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcEntityF_CodeFirst.Models;
namespace mvcEntityF_CodeFirst.ViewModels.Home
{
    public class HomePageVM
    {
        public List<Kisi> Kisiler { get; set; }
        public List<Adres> Adresler { get; set; }
    }
}