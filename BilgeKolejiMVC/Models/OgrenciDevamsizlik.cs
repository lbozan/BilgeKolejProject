using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class OgrenciDevamsizlik
    {
        public int ID { get; set; }
        public int OgrenciID { get; set; }
        public int DurumID { get; set; }
        public int OgretmenID { get; set; }
        public string Bilgi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
