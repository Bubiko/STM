using HtmlAgilityPack;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UserInfo
{
    public class UserBasicInfo
    {
        public string ProfileName = "";
        public string UserName = "";
        public string UserID = "";
        public string PfpPath = "";
        public void GetUserInfo()
        {
            string TempUserID = ""; string TempUserName = ""; bool MostRecent = false; string TempRecent;
            foreach (var line in File.ReadAllLines("C:/Program Files (x86)/Steam/config/loginusers.vdf"))
            {
                if (line.Contains("\t\"7"))
                {
                    TempUserID = line.Remove(line.Length - line.Length, 2);
                    TempUserID = TempUserID.Remove(TempUserID.Length - 1, 1);
                }
                else if (line.Contains("\t\t\"AccountName\"\t\t"))
                {
                    TempUserName = line.Remove(0, 18);
                    TempUserName = TempUserName.Remove(TempUserName.Length - 1, 1);
                }
                else if (line.Contains("\t\t\"mostrecent\"\t\t"))
                {
                    TempRecent = line.Replace("\t\t\"mostrecent\"\t\t", "");
                    TempRecent = TempRecent.Replace("\"", "");
                    if (TempRecent == "1")
                        MostRecent = true;
                    else MostRecent = false;
                }
                if (MostRecent == true)
                {
                    UserName = TempUserName;
                    PfpPath = "C:/Program Files (x86)/Steam/config/avatarcache/" + TempUserID + ".png";
                    UserID = TempUserID;
                    break;
                }
            }
            /*
            string SteamLookup = "https://steamid.io/lookup/" + UserID;
            var webclient = new HtmlWeb();
            var SteamidContent = webclient.Load(SteamLookup);
            string content = SteamidContent.ParsedText;
            if(content.Contains("\"name\" \""))
            {

            }*/
        }
    }

}