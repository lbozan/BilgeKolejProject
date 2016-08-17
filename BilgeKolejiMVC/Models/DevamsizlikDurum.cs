using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class DevamsizlikDurum
    {
        public int ID { get; set; }
        public string DurumAdi { get; set; }
        public bool? Aktif { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
