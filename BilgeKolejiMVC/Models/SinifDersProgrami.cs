using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    
    public   class SinifDersProgrami
    {
        public int ID { get; set; }
        public int SinifID { get; set; }
        public int GunID { get; set; }
        public int DersID { get; set; }
        public int HocaID { get; set; }
        public System.TimeSpan BaslangicSaat { get; set; }
        public System.TimeSpan BitisSaat { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
     }
}
