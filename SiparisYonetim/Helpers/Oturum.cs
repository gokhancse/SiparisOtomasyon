using SiparisYonetim;
using SiparisYonetim.Tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetim.Helpers
{
   public static class Oturum
    {
        public static Sirket Sirket { get; set; }
        public static Kullanici User { get; set; }
        //public static DB_Context db { get; set; } = DB_Context.Instance;

        public static bool SirketSec()
        {
            if (Oturum.Sirket.UstSirketId == 0)
                return true;
            else
                return false;
        }

        public static bool IsAuth
        {
            get
            {
                return (User != null);
            }
        }
    }
}
