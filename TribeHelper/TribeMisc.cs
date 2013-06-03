using System;
using System.IO;
using System.Net;

namespace TribalHelper
{
    public static class TribeMisc
    {
        #region Member variables

        private const string m_sFilename = "UserInfo.ini";

        #endregion

        #region inifile methods

        public static void GetUserInfo()
        {
            if (File.Exists(m_sFilename))
            {
                StreamReader oReader = new StreamReader(m_sFilename);
                string sLine = "";
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

        #endregion
        
        #region String Methods

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

        #endregion

        #region Url Methods

        public static bool CheckUrlExists(string sUrl)
        {
            bool bExists = true;

            try
            {
                WebRequest webRequest = WebRequest.Create(TribeMisc.AddHttp(sUrl.Trim().ToLower()));
                webRequest.Timeout = 1200; // miliseconds
                webRequest.Method = WebRequestMethods.Http.Head;
                webRequest.GetResponse();
            }
            catch
            {
                bExists = false;
            }

            return bExists;
        }

        #endregion
    }
}
