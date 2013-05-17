using System;
using System.IO;

namespace TribalBrowser.helpers
{
    public static class TribeMisc
    {
        private static string m_sFilename = "UserInfo.ini";
        
        public static void GetUserInfo()
        {
            string sLine = "";
            if (File.Exists(m_sFilename))
            {
                StreamReader oReader = new StreamReader(m_sFilename);
                while ((sLine = oReader.ReadLine()) != null)
                {
                    mTribeMember.TbNm = sLine;
                }
            }
        }

        public static void SaveUserInfo(string sTbNm)
        {
            using (StreamWriter writer = new StreamWriter(m_sFilename))
            {
                writer.WriteLine(sTbNm);
            }
        }

        public static string StripHttp(string sUrl)
        {
            return sUrl.Replace("http://","");
        }

        public static string AddHttp(string sUrl)
        {
            if (!sUrl.Contains("http://"))
            {
                return "http://" + sUrl;
            }
            return sUrl;
        }

        public static string ConvertIfNull(Object o)
        {
            if (o == null)
            {
                return "";
            }
            return o.ToString().Trim();
        }
    }
}
