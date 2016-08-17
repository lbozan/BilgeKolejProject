using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class DonemOdevi
    {
        public int ID { get; set; }
        public int OgrenciID { get; set; }
        public int DersID { get; set; }
        public string OdevAdi { get; set; }
        public string Konu { get; set; }
        public string DosyaPath { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
