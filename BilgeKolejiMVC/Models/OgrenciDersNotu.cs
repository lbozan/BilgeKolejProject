using System;
using System.Collections.Generic;
   
namespace BilgeKolejProject
{
    public  class OgrenciDersNotu
    {
        public int ID { get; set; }
        public int OgrenciID { get; set; }
        public int OgretmenID { get; set; }
        public int DersID { get; set; }
        public Nullable<decimal> Sinav1 { get; set; }
        public Nullable<decimal> Sinav2 { get; set; }
        public Nullable<decimal> Sozlu { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
