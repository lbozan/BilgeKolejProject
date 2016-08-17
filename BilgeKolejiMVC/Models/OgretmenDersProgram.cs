using System;
using System.Collections.Generic;
  
namespace BilgeKolejProject
{
    public  class OgretmenDersProgram
    {
        public int ID { get; set; }
        public int OgretmenID { get; set; }
        public int GunID { get; set; }
        public int EgitimVerilenDerslerID { get; set; }
        public Nullable<System.DateTime> Kayit { get; set; }
    }
}
