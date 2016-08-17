using System;
using System.Collections.Generic;
    
namespace BilgeKolejProject
{
    public  class Users
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Aktifmi { get; set; }
    }
}
