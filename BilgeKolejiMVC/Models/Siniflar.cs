using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class Siniflar
    {
        public int ID { get; set; }
        public string SinifAdi { get; set; }
        public int Kontenjan { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
