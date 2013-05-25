#region GPL Licence

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

using TribalBrowser.forms;
using System;

namespace TribalBrowser.helpers
{
    public class TribeMemberFavourites
    {
        #region Member variables

        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        #endregion

        #region Public methods

        public void AddFavourite(string sSt, string sUrl, string sDsc)
        {
            if (_SiteDscNull(sSt,sDsc))
            {
                m_oMessageBox.Show(StringProvider.sTribeSiteDscNull);
                return;
            }

            sSt = mTribeMember.UsrNm + StringProvider.sFavourites + sSt;

            if (_TribeFavouriteExists(sSt, mTribeMember.TbNm, mTribeMember.UsrNm))
            {
                m_oMessageBox.Show(StringProvider.sTribeFavouriteExists + sSt);
                return;
            }

            m_oDataAccess.InsertTribeLink(sSt, sUrl, sDsc, mTribeMember.TbNm, mTribeMember.UsrNm, "Yes");
            m_oMessageBox.Show(StringProvider.sTribeFavouriteAdded);
        }

        #endregion

        #region Private Helpers

        private bool _SiteDscNull(string sSt, string sDsc)
        {
            return (String.IsNullOrEmpty(sSt.Trim()) || String.IsNullOrEmpty(sDsc.Trim()));
        }

        private bool _TribeFavouriteExists(string sSt, string sTbNm, string sUsrNm)
        {
            return m_oDataAccess.TribeFavouriteExists(sSt, sTbNm, sUsrNm);
        }

        #endregion
    }
}
