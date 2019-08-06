using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using System.Text;

namespace mvcResult.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Dosyalar()
        {
            return View();
        }
        public FileResult pdfdosyaindir()
        {
            string dosyayolu = Server.MapPath("~/Files/asp_net_mvc_poster.pdf");
            return new FilePathResult(dosyayolu,"application/pdf");
        }
        public FileStreamResult metindosyaindir()
        {
            string metin = "bu bir deneme metinidir";
            MemoryStream mem = new MemoryStream();
            byte[] bytes = Encoding.UTF8.GetBytes(metin);
            mem.Write(bytes,0,bytes.Length);
            mem.Position = 0;
            FileStreamResult result = new FileStreamResult(mem,"text/plain");
            result.FileDownloadName = "deneme.txt";
            return result;
        }
    }
}