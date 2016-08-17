using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{

    public  class OkulDonemleri
    {
        public int ID { get; set; }
        public System.DateTime Yili { get; set; }
        public System.DateTime ilkDonemGiris { get; set; }
        public System.DateTime ilkDonemBitis { get; set; }
        public System.DateTime ikinciDonemGiris { get; set; }
        public System.DateTime ikinciDonemBitis { get; set; }
    }
}
