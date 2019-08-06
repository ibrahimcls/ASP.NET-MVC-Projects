using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcModel.Models;

namespace mvcModel.Models
{
    public class Adres
    {
        public string il { get; set; }
        public string ilce { get; set; }
        public Kisi adresKisi { get; set; }
    }
}