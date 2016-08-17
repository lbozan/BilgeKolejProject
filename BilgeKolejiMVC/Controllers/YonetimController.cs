using BilgeKolejProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKolejProject.Controllers
{
    public class YonetimController : Controller
    {
        //
        // GET: /Yonetim/
        YonetimIsleri _yonetim = new YonetimIsleri();
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult HataBildirimi(string Bilgi)
        {
            ViewBag.bilgi = Bilgi;
            return View();
        }


        #region Öğretmen Durum İşlemleri
        public ActionResult OgretmenDurumListesi()
        {
            return View(_yonetim.OgretmenDurumListesi());
        }
        public ActionResult OgretmenDurumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OgretmenDurumEkle(OgretmenDurum model)
        {
            if (ModelState.IsValid)
            {
                int kontrol = _yonetim.OgretmenDurumEkle(model);
                if (kontrol == 1)
                {
                    return RedirectToAction("OgretmenDurumListesi");
                }
                else if (kontrol == -1)
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Öğretmen Durum Eklenirken Hata Oluştu." });
                }
                ModelState.AddModelError("DurumAdi", "Belirlediğiniz Durum Zaten var");
            }
            return View(model);
        }
        public ActionResult OgretmenDurumSil(int Id)
        {
            return View(_yonetim.OgretmenDurumDetails(Id));
        }
        [HttpPost, ActionName("OgretmenDurumSil")]
        public ActionResult OgretmenDurumSil(OgretmenDurum model)
        {

            bool kontrol = _yonetim.OgretmenDurumSil(model);
            if (kontrol)
            {
                return RedirectToAction("OgretmenDurumListesi");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Öğretmen Durumu Silinirken Hata Oluştu." });
            }

        }
        public ActionResult OgretmenDurumDuzenle(int Id)
        {
            return View(_yonetim.OgretmenDurumDetails(Id));
        }
        [HttpPost]
        public ActionResult OgretmenDurumDuzenle(OgretmenDurum model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.OgretmenDurumDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("OgretmenDurumListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Öğretmen Durumu Güncellenirken Hata Oluştu." });
                }
            }
            return View(model);
        }
        #endregion

        #region Öğretmen Branş İşlemleri

        public ActionResult OgretmenBransListesi()
        {
            return View(_yonetim.OgretmenBransListesi());
        }
        public ActionResult OgretmenBransEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OgretmenBransEkle(Branslar model)
        {
            if (ModelState.IsValid)
            {
                int kontrol = _yonetim.OgretmenBransEkle(model);
                if (kontrol == 1)
                {
                    return RedirectToAction("OgretmenBransListesi");
                }
                else if (kontrol == -1)
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Öğretmen Branş Eklenirken Hata Oluştu." });
                }
                ModelState.AddModelError("BransAdi", "Eklemek istediğiniz Branş zaten var.!");
            }
            return View(model);
        }

        public ActionResult OgretmenBransSil(int Id)
        {
            return View(_yonetim.OgretmenBransDetails(Id));
        }
        [HttpPost, ActionName("OgretmenBransSil")]
        public ActionResult OgretmenBransSil(Branslar model)
        {
            bool kontrol = _yonetim.OgretmenBransSil(model);
            if (kontrol)
            {
                return RedirectToAction("OgretmenBransListesi");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Öğretmen Branş Silirken Hata Oluştu." });
            }

        }

        public ActionResult OgretmenBransDuzenle(int Id)
        {
            return View(_yonetim.OgretmenBransDetails(Id));
        }
        [HttpPost]
        public ActionResult OgretmenBransDuzenle(Branslar model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.OgretmenBransDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("OgretmenBransListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Öğretmen Branş Düzenlenirken Hata Oluştu." });
                }
            }
            return View(model);
        }
        #endregion

        #region Öğrenci Durum İşlemleri

        public ActionResult OgrenciDurumListesi()
        {
            return View(_yonetim.OgrenciDurumListesi());
        }
        public ActionResult OgrenciDurumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OgrenciDurumEkle(OgrenciDurum model)
        {
            if (ModelState.IsValid)
            {
                int kontrol = _yonetim.OgrenciDurumEkle(model);
                if (kontrol == 1)
                {
                    return RedirectToAction("OgrenciDurumListesi");
                }
                else if (kontrol == -1)
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Öğrenci Durumu Eklenirken Hata Oluştu" });
                }
                ModelState.AddModelError("DurumAdi", "Eklemek istediğiniz Durum zaten var.!");
            }
            return View(model);
        }
        public ActionResult OgrenciDurumSil(int Id)
        {
            return View(_yonetim.OgrenciDurumDetails(Id));
        }
        [HttpPost, ActionName("OgrenciDurumSil")]
        public ActionResult OgrenciDurumSil(OgrenciDurum model)
        {
            bool kontrol = _yonetim.OgrenciDurumSil(model);
            if (kontrol)
            {
                return RedirectToAction("OgrenciDurumListesi");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Öğrenci Durumu Silinirken Hata Oluştu." });
            }
        }
        public ActionResult OgrenciDurumDuzenle(int Id)
        {
            return View(_yonetim.OgrenciDurumDetails(Id));
        }
        [HttpPost]
        public ActionResult OgrenciDurumDuzenle(OgrenciDurum model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.OgrenciDurumDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("OgrenciDurumListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Öğrenci Durumu Düzeltilirken Hata Oluştu." });
                }
            }
            return View(model);
        }
        #endregion

        #region Öğrenci Devamsızlık Durumu

        public ActionResult DevamsizlikDurumListesi()
        {
            return View(_yonetim.DevamsizlikDurumListesi());
        }
        public ActionResult DevamsizlikDurumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DevamsizlikDurumEkle(DevamsizlikDurum model)
        {
            if (ModelState.IsValid)
            {
                int kontrol = _yonetim.DevamsizlikDurumEkle(model);
                if (kontrol == 1)
                {
                    return RedirectToAction("DevamsizlikDurumListesi");
                }
                else if (kontrol == -1)
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Devamsızlık Durumu Silinirken hata oluştu." });
                }
                ModelState.AddModelError("DurumAdi", "Belirlediğiniz Devamsızlık Durumu zaten var.!");
            }
            return View(model);
        }
        public ActionResult DevamsizlikDurumSil(int Id)
        {
            return View(_yonetim.DevamsizlikDurumDetails(Id));
        }
        [HttpPost, ActionName("DevamsizlikDurumSil")]
        public ActionResult DevamsizlikDurumSil(DevamsizlikDurum model)
        {
            bool kontrol = _yonetim.DevamsizlikDurumSil(model);
            if (kontrol)
            {
                return RedirectToAction("DevamsizlikDurumListesi");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Devamsuzlık Durumu Silinirken Hata oluştu." });
            }
        }
        public ActionResult DevamsizlikDurumDuzenle(int Id)
        {
            return View(_yonetim.DevamsizlikDurumDetails(Id));
        }
        [HttpPost]
        public ActionResult DevamsizlikDurumDuzenle(DevamsizlikDurum model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.DevamsizlikDurumDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("DevamsizlikDurumListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Devamsızlık Durumu Düzenltilirken Hata oluştu" });
                }
            }
            return View(model);
        }

        #endregion

        #region Diğer Okullar

        public ActionResult BitirdigiOkulListesi()
        {
            return View(_yonetim.BitirdigiOkulListesi());
        }
        public ActionResult BitirdigiOkulEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BitirdigiOkulEkle(BitirdigiOkul model)
        {
            if (ModelState.IsValid)
            {
                int kontrol = _yonetim.BitirdigiOkulEkle(model);
                if (kontrol == 1)
                {
                    return RedirectToAction("BitirdigiOkulListesi");
                }
                else if (kontrol == -1)
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Diğer Okullar Ekleme İşleminde Hata Oluştur" });
                }
                ModelState.AddModelError("OkulAdi", "Girdiğiniz Okul Zaten var.");
            }
            return View(model);
        }
        public ActionResult BitirdigiOkulSil(int Id)
        {
            return View(_yonetim.BitirdigiOkulDetails(Id));
        }
        [HttpPost, ActionName("BitirdigiOkulSil")]
        public ActionResult BitirdigiOkulSil(BitirdigiOkul model)
        {
            bool kontrol = _yonetim.BitirdigiOkulSil(model);
            if (kontrol)
            {
                return RedirectToAction("BitirdigiOkulListesi");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Diğer Okullar silinirken hata Oluştu." });
            }
        }
        public ActionResult BitirdigiOkulDuzenle(int Id)
        {
            return View(_yonetim.BitirdigiOkulDetails(Id));
        }
        [HttpPost]
        public ActionResult BitirdigiOkulDuzenle(BitirdigiOkul model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.BitirdigiOkulDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("BitirdigiOkulListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Diğer Okullar Düzenlenlerken Hata Oluştu." });
                }
            }
            return View(model);
        }
        #endregion

        #region Gün İşlemleri

        public ActionResult GunlerListesi()
        {
            return View(_yonetim.GunlerListesi());
        }
        public ActionResult GunlerEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GunlerEkle(SinifGun model)
        {
            if (ModelState.IsValid)
            {
                int kontrol = _yonetim.GunlerEkle(model);
                if (kontrol == 1)
                {
                    return RedirectToAction("GunlerListesi");
                }
                else if (kontrol == -1)
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Gunler Silinirken Hata Oluştu" });
                }
                ModelState.AddModelError("GunAdi", "Girdiğiniz Gün Zaten var");
            }
            return View(model);
        }
        public ActionResult GunlerSil(int Id)
        {
            return View(_yonetim.GunlerDetails(Id));
        }
        [HttpPost, ActionName("GunlerSil")]
        public ActionResult GunlerSil(SinifGun model)
        {
            bool kontrol = _yonetim.GunlerSil(model);
            if (kontrol)
            {
                return RedirectToAction("GunlerListesi");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Gunler Silinirken Hata Oluştu." });
            }
        }
        public ActionResult GunlerDuzenle(int Id)
        {
            return View(_yonetim.GunlerDetails(Id));
        }
        [HttpPost]
        public ActionResult GunlerDuzenle(SinifGun model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.GunlerDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("GunlerListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Günler Düzenlenirken Hata Oluştu." });
                }
            }
            return View(model);
        }
        #endregion

        #region Siniflar
        public ActionResult Siniflar()
        {
            return View(_yonetim.SinifListesi());
        }
        public ActionResult SinifEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SinifEkle(Siniflar model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.SinifEkle(model);
                if (kontrol)
                {
                    return RedirectToAction("Siniflar");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Sınıf Eklerken Hata Oluştu." });
                }
            }
            return View(model);
        }
        public ActionResult SinifDuzenle(int Id)
        {
            return View(_yonetim.SinifDetails(Id));
        }
        [HttpPost]
        public ActionResult SinifDuzenle(Siniflar model)
        {
            //Todo: yeni kontenjan sınıfta bulunan öğrenci sayısından küçük olamaz.
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.SinifDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("Siniflar");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Sınıf Düzenlerken Bir Hata Oluştu" });
                }
            }
            return View(model);
        }
        public ActionResult SinifSil(int Id)
        {
            return View(_yonetim.SinifDetails(Id));
        }
        [HttpPost, ActionName("SinifSil")]
        public ActionResult SinifSil(Siniflar model)
        {
            bool kontrol = _yonetim.SinifSil(model);
            if (kontrol)
            {
                return RedirectToAction("Siniflar");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Sınıf Silinirken Hata oluştu" });
            }
        }

        #endregion

        #region Eğitim Dersleri

        public ActionResult DersListesi()
        {
            return View(_yonetim.DersListesi());
        }
        public ActionResult DersEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DersEkle(EgitimDersleri model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.DersEkle(model);
                if (kontrol)
                {
                    return RedirectToAction("DersListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Ders Ekleme İşleminde Hata Oluştu." });
                }
            }
            return View(model);
        }
        public ActionResult DersDuzenle(int Id)
        {
            return View(_yonetim.DersDetails(Id));
        }
        [HttpPost]
        public ActionResult DersDuzenle(EgitimDersleri model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.DersDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("DersListesi");
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Ders Düzenleme işleminde Hata Oluştu." });
                }
            }
            return View(model);
        }
        public ActionResult DersSil(int Id)
        {
            return View(_yonetim.DersDetails(Id));
        }
        [HttpPost, ActionName("DersSil")]
        public ActionResult DersSil(EgitimDersleri model)
        {
            bool kontrol = _yonetim.DersSil(model);
            if (kontrol)
            {
                return RedirectToAction("DersListesi");
            }
            else
            {
                return RedirectToAction("HataBildirimi", new { Bilgi = "Ders Silme İşleminde Hata Oluştu." });
            }
        }
        public ActionResult DersDetails(int Id)
        {
            return View(_yonetim.DersDetails(Id));
        }

        public ActionResult AltDersEkle(int Id)
        {

            return View(new EgitimDersleri() { UstID = Id });
        }
        [HttpPost]
        public ActionResult AltDersEkle(EgitimDersleri model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.AltDersEkle(model);
                if (kontrol)
                {
                    return RedirectToAction("DersDetails", new { Id = model.ID });
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Alt Ders Ekleme işleminde Hata Oluştu." });
                }
            }
            return View(model);
        }

        public ActionResult AltDersDuzenle(int Id)
        {
            return View(_yonetim.DersDetails(Id));
        }
        [HttpPost]
        public ActionResult AltDersDuzenle(EgitimDersleri model)
        {
            if (ModelState.IsValid)
            {
                bool kontrol = _yonetim.DersDuzenle(model);
                if (kontrol)
                {
                    return RedirectToAction("DersDetails", new { Id = model.UstID });
                }
                else
                {
                    return RedirectToAction("HataBildirimi", new { Bilgi = "Alt Ders Düzenleme İşleminde Hata Meydana Geldi." });
                }
            }
            return View(model);
        }
        #endregion
    }
}
