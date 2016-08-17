using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class VeliBilgileri
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Nullable<int> EvTelefon { get; set; }
        public Nullable<int> CepTelefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
