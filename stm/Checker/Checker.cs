

using System.IO;

namespace Checker
{
   class EsentialFileCheck
   { 
        public static bool SteamFileCheck()
        {
            if (File.Exists("C:/Program Files (x86)/Steam/steam.exe")&& File.Exists("C:/Program Files (x86)/Steam/config/loginusers.vdf"))
            { 
                return true; 
            }
            else return false;
        }
    }

}
