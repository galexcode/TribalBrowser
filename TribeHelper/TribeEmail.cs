﻿#region GPL Licence

/*
    Tribal Browser: A web browser that allows you to share your personal sites and 
    interact with your Tribe, bypassing search engines and ICANN.
    Copyright (C) 2012 Darren Udaiyan, Frugal Disruptive ltd, darren@frugaldisruptive.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program - See LICENCE.TXT in the root directory.  
    If not, see http://www.gnu.org/licenses/.
    */

#endregion

using System.Net.Mail;
using System.Net;
using TribalMessageBox;

namespace TribalHelper
{
    public static class TribeEmail
    {
        #region Member variables

        private static readonly frmMessageBox m_ofrmMessageBox = new frmMessageBox();

        #endregion

        #region Public Methods

        public static void SendMail(string sEmailAdd, string sSubj, string sMssg)
        {
            m_ofrmMessageBox.Show(StringProvider.sEmailServerNotSetup);
            return;

            //SmtpClient oClient = new SmtpClient("smtp.gmail.com", 587)
            //{
            //    Credentials = new NetworkCredential("Username@gmail.com", "Psswd"),
            //    EnableSsl = true
            //};
            //oClient.Send("Username@gmail.com", sEmailAdd, sSubj, sMssg);
        }

        #endregion
    }
}
