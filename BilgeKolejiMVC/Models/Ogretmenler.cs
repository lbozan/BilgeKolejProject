using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class Ogretmenler
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BransID { get; set; }
        public int DurumID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gorevi { get; set; }
        public int Telefon { get; set; }
        public string Eposta { get; set; }
        public string Cinsiyet { get; set; }
        public string DurumBilgi { get; set; }
        public Nullable<bool> Aktifmi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
