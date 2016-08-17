using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilgeKolejProject.Business
{
    internal class YonetimIsleri
    {
        private BilgeKolejDbEntities _db;
        public YonetimIsleri()
        {
            _db = new BilgeKolejDbEntities();
        }


        internal List<OgretmenDurum> OgretmenDurumListesi()
        {
            return _db.OgretmenDurum.ToList();
        }
        internal int OgretmenDurumEkle(OgretmenDurum model)
        {
            try
            {
                model.DurumAdi = model.DurumAdi.Trim();
                var kontrol = _db.OgretmenDurum.SingleOrDefault(x => x.DurumAdi == model.DurumAdi);
                if (kontrol != null)
                    return 0;
                model.Tarih = DateTime.Today;
                model.Aktifmi = true;
                _db.OgretmenDurum.Add(model);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        internal bool OgretmenDurumSil(OgretmenDurum model)
        {
            try
            {
                var durum = _db.OgretmenDurum.First(x => x.ID == model.ID);
                _db.OgretmenDurum.Remove(durum);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal OgretmenDurum OgretmenDurumDetails(int Id)
        {
            return _db.OgretmenDurum.SingleOrDefault(x => x.ID == Id);
        }
        internal bool OgretmenDurumDuzenle(OgretmenDurum model)
        {
            try
            {
                var durum = _db.OgretmenDurum.First(x => x.ID == model.ID);
                durum.DurumAdi = model.DurumAdi.Trim();
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }




        internal List<Branslar> OgretmenBransListesi()
        {
            return _db.Branslar.ToList();
        }
        internal int OgretmenBransEkle(Branslar model)
        {
            try
            {
                model.BransAdi = model.BransAdi.Trim();
                var brans = _db.Branslar.SingleOrDefault(x => x.BransAdi == model.BransAdi);
                if (brans != null)
                    return 0;
                model.Aktifmi = true;
                model.Tarih = DateTime.Today;
                _db.Branslar.Add(model);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        internal Branslar OgretmenBransDetails(int Id)
        {
            return _db.Branslar.SingleOrDefault(x => x.ID == Id);
        }
        internal bool OgretmenBransSil(Branslar model)
        {
            try
            {
                var brans = _db.Branslar.First(x => x.ID == model.ID);
                _db.Branslar.Remove(brans);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool OgretmenBransDuzenle(Branslar model)
        {
            try
            {
                var brans = _db.Branslar.First(x => x.ID == model.ID);
                brans.BransAdi = model.BransAdi.Trim();
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        internal List<OgrenciDurum> OgrenciDurumListesi()
        {
            return _db.OgrenciDurum.ToList();
        }
        internal int OgrenciDurumEkle(OgrenciDurum model)
        {
            try
            {
                model.DurumAdi = model.DurumAdi.Trim();
                var durum = _db.OgrenciDurum.SingleOrDefault(x => x.DurumAdi == model.DurumAdi);
                if (durum != null)
                    return 0;
                model.Aktifmi = true;
                model.Tarih = DateTime.Today;
                _db.OgrenciDurum.Add(model);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        internal OgrenciDurum OgrenciDurumDetails(int Id)
        {
            return _db.OgrenciDurum.SingleOrDefault(x => x.ID == Id);
        }
        internal bool OgrenciDurumSil(OgrenciDurum model)
        {
            try
            {
                var durum = _db.OgrenciDurum.First(x => x.ID == model.ID);
                _db.OgrenciDurum.Remove(durum);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool OgrenciDurumDuzenle(OgrenciDurum model)
        {
            try
            {
                model.DurumAdi = model.DurumAdi.Trim();
                var durum = _db.OgrenciDurum.First(x => x.ID == model.ID);
                durum.DurumAdi = model.DurumAdi;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        internal List<DevamsizlikDurum> DevamsizlikDurumListesi()
        {
            return _db.DevamsizlikDurum.ToList();
        }
        internal int DevamsizlikDurumEkle(DevamsizlikDurum model)
        {
            try
            {
                model.DurumAdi = model.DurumAdi.Trim();
                var durum = _db.DevamsizlikDurum.SingleOrDefault(x => x.DurumAdi == model.DurumAdi);
                if (durum != null)
                    return 0;
                model.Aktif = true;
                model.Tarih = DateTime.Today;
                _db.DevamsizlikDurum.Add(model);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }

        }
        internal DevamsizlikDurum DevamsizlikDurumDetails(int Id)
        {
            return _db.DevamsizlikDurum.SingleOrDefault(x => x.ID == Id);
        }
        internal bool DevamsizlikDurumSil(DevamsizlikDurum model)
        {
            try
            {
                var durum = _db.DevamsizlikDurum.First(x => x.ID == model.ID);
                _db.DevamsizlikDurum.Remove(durum);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool DevamsizlikDurumDuzenle(DevamsizlikDurum model)
        {
            try
            {
                model.DurumAdi = model.DurumAdi.Trim();
                var durum = _db.DevamsizlikDurum.First(x => x.ID == model.ID);
                durum.DurumAdi = model.DurumAdi;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }




        internal List<BitirdigiOkul> BitirdigiOkulListesi()
        {
            return _db.BitirdigiOkul.ToList();
        }
        internal int BitirdigiOkulEkle(BitirdigiOkul model)
        {
            try
            {
                model.OkulAdi = model.OkulAdi.Trim();
                var okul = _db.BitirdigiOkul.SingleOrDefault(x => x.OkulAdi == model.OkulAdi);
                if (okul != null)
                    return 0;
                model.Tarih = DateTime.Today;
                _db.BitirdigiOkul.Add(model);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        internal BitirdigiOkul BitirdigiOkulDetails(int Id)
        {
            return _db.BitirdigiOkul.SingleOrDefault(x => x.ID == Id);
        }
        internal bool BitirdigiOkulSil(BitirdigiOkul model)
        {
            try
            {
                var sil = _db.BitirdigiOkul.First(x => x.ID == model.ID);
                _db.BitirdigiOkul.Remove(sil);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool BitirdigiOkulDuzenle(BitirdigiOkul model)
        {
            try
            {
                var okul = _db.BitirdigiOkul.First(x => x.ID == model.ID);

                okul.OkulAdi = model.OkulAdi.Trim();
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }




        internal List<SinifGun> GunlerListesi()
        {
            return _db.SinifGun.ToList();
        }
        internal int GunlerEkle(SinifGun model)
        {
            try
            {
                model.GunAdi = model.GunAdi.Trim();
                var gun = _db.SinifGun.SingleOrDefault(x => x.GunAdi == model.GunAdi);
                if (gun != null)
                    return 0;

                _db.SinifGun.Add(model);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        internal SinifGun GunlerDetails(int Id)
        {
            return _db.SinifGun.SingleOrDefault(x => x.ID == Id);
        }
        internal bool GunlerSil(SinifGun model)
        {
            try
            {
                var sil = _db.SinifGun.First(x => x.ID == model.ID);

                _db.SinifGun.Remove(sil);
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool GunlerDuzenle(SinifGun model)
        {
            try
            {
                var gun = _db.SinifGun.First(x => x.ID == model.ID);
                gun.GunAdi = model.GunAdi;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        internal List<Siniflar> SinifListesi()
        {
            return _db.Siniflar.ToList();
        }
        internal bool SinifEkle(Siniflar model)
        {
            try
            {
                model.SinifAdi = model.SinifAdi.Trim();
                var sinif = _db.Siniflar.SingleOrDefault(x => x.SinifAdi == model.SinifAdi);
                if (sinif != null)
                    return true;

                _db.Siniflar.Add(new Siniflar() { Kontenjan = model.Kontenjan, SinifAdi = model.SinifAdi, Aktif = true, Tarih = DateTime.Today });
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal Siniflar SinifDetails(int Id)
        {
            return _db.Siniflar.SingleOrDefault(x => x.ID == Id);
        }
        internal bool SinifDuzenle(Siniflar model)
        {
            try
            {
                var sinif = _db.Siniflar.First(x => x.ID == model.ID);
                sinif.SinifAdi = model.SinifAdi.Trim();
                sinif.Kontenjan = model.Kontenjan;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool SinifSil(Siniflar model)
        {
            try
            {
                var sinif = _db.Siniflar.First(x => x.ID == model.ID);
                _db.Siniflar.Remove(sinif);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }




        internal List<EgitimDersleri> DersListesi()
        {
            return _db.EgitimDersleri.Where(x => x.UstID == null).ToList();
        }
        internal bool DersEkle(EgitimDersleri model)
        {
            try
            {
                model.DersAdi = model.DersAdi.Trim();
                var ders = _db.EgitimDersleri.SingleOrDefault(x => x.DersAdi == model.DersAdi);
                if (ders != null)
                    return false;

                _db.EgitimDersleri.Add(new EgitimDersleri() { UstID = null, DersAdi = model.DersAdi, DersKodu = model.DersKodu.Trim(), Hd = model.Hd, Sirasi = model.Sirasi });
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal EgitimDersleri DersDetails(int Id)
        {
            return _db.EgitimDersleri.SingleOrDefault(x => x.ID == Id);
        }
        internal bool DersDuzenle(EgitimDersleri model)
        {
            try
            {
                var ders = _db.EgitimDersleri.First(x => x.ID == model.ID);

                ders.DersAdi = model.DersAdi.Trim();
                ders.DersKodu = model.DersKodu;
                ders.Hd = model.Hd;
                ders.Sirasi = model.Sirasi;

                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool DersSil(EgitimDersleri model)
        {
            try
            {
                var sil = _db.EgitimDersleri.First(x => x.ID == model.ID);
                _db.EgitimDersleri.Remove(sil);
                _db.SaveChanges();
                var altsil = _db.EgitimDersleri.Where(x => x.UstID == model.ID);
                if (altsil.Count() > 0)
                {
                    _db.EgitimDersleri.RemoveRange(altsil);
                    _db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal bool AltDersEkle(EgitimDersleri model)
        {
            try
            {
                model.DersAdi = model.DersAdi.Trim();
                var alt = _db.EgitimDersleri.SingleOrDefault(x => x.DersAdi == model.DersAdi);
                if (alt != null)
                    return false;
                _db.EgitimDersleri.Add(new EgitimDersleri() { DersAdi = model.DersAdi, UstID = model.ID, Sirasi = model.Sirasi, Hd = model.Hd, DersKodu = model.DersKodu.Trim() });
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
