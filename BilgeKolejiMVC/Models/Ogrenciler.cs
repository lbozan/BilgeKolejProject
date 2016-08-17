using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class Ogrenciler
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BitirdigiOkulID { get; set; }
        public int VeliBilgiID { get; set; }
        public Nullable<int> SinifID { get; set; }
        public string OkulNo { get; set; }
        public int TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yas { get; set; }
        public string Eposta { get; set; }
        public string Cinsiyet { get; set; }
        public decimal NotOrtalamasi { get; set; }
        public int DurumID { get; set; }
        public string DurumBilgi { get; set; }
        public System.DateTime KayitTarihi { get; set; }
        public Nullable<System.DateTime> MezuniyetTarihi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
  }
}
