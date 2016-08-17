using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKolejProject.Controllers
{
    public class AnasayfaController : Controller
    {   /* 1-Giriş
         * 2-Çıkış
         * 3-Hatalar
         */
        //
        // GET: /Anasayfa/
        public ActionResult Index()
        {
            //Eğer Giriş Yapmışsa Yönlendirilecektir
            return View();
        }
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(FormCollection Model)
        {
            return View();
        }
        public ActionResult Cikis()
        {
            // OutLog
            return View();
        }

        public ActionResult Hata(Exception ex)
        {
            string hata = ex.Message;
            return View();
        }
        public ActionResult Hata404()
        {
            return View();
        }
        public ActionResult Hata403()
        {
            return View();
        }
        public ActionResult Hata500()
        {
            return View();
        }
    }
}
