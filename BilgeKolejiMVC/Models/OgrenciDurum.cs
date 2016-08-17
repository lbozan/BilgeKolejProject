using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class OgrenciDurum
    {
        public int ID { get; set; }
        public string DurumAdi { get; set; }
        public Nullable<bool> Aktifmi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
