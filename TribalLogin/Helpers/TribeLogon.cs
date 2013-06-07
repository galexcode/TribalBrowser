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

using System.Windows.Forms;
using TribalHelper;
using TribalLogin.Forms;
using TribalMessageBox;

namespace TribalLogin.Helpers
{
    public class TribeLogon
    {
        #region Member variables

        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        #endregion

        #region Public Methods

        public void ShowDialogForm<T1>(T1 oForm, bool bAdminMode = false) where T1 : Form
        {
            if (mTribeMember.LgIn)
            {
                oForm.ShowDialog();
            }
            else
            {
                m_oMessageBox.Show(StringProvider.sPleaseLogin);
                frmLogin ofrmLogin = null;
                if (bAdminMode == false)
                {
                    ofrmLogin = new frmLogin(oForm);
                }
                else
                {
                    ofrmLogin = new frmLogin(oForm, bAdminMode);
                }  
                ofrmLogin.ShowDialog();
            }
        }
        public void ShowWindowForm<T>(T oForm, bool bAdminMode = false) where T : Form
        {
            if (mTribeMember.LgIn)
            {
                oForm.Show();
                oForm.BringToFront();
            }
            else
            {
                m_oMessageBox.Show(StringProvider.sPleaseLogin);
                frmLogin ofrmLogin = null;
                if (bAdminMode == false) 
                {
                    ofrmLogin = new frmLogin(oForm);
                }
                else
                {
                    ofrmLogin = new frmLogin(oForm, bAdminMode);
                }  
                ofrmLogin.ShowDialog();
            }
        }

        public void ShowLogin()
        {
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.ShowDialog();
        }

        public void ShowLogin(bool bAdminMode)
        {
            frmLogin ofrmLogin = new frmLogin(bAdminMode);
            ofrmLogin.ShowDialog();
        }
        public void SaveTribeMember(Form oParentForm, string sUsrNm, string sPss, string sConfirmPss, string sMl, bool bCloseParent = true)
        {
            if (_PasswordsMatch(sPss, sConfirmPss))
            {
                _SaveTribeMemberToDatabase(oParentForm, sUsrNm, sPss, sMl, bCloseParent);
            }
            else
            {
                m_oMessageBox.Show("Passwords do not match");
            }
        }

        public void ShowMyDetails(TextBox txtUsrNm, TextBox txtPss, TextBox txtConfirmPss)
        {
            TribeMember oTribeMember = m_oDataAccess.FindTribeMember();
            txtUsrNm.Text = oTribeMember.UsrNm;
            txtPss.Text = oTribeMember.Pss;
            txtConfirmPss.Text = oTribeMember.Pss;
        }

        #endregion

        #region Private Helper Methods

        private bool _PasswordsMatch(string sPss, string sConfirmPss)
        {
            return (sPss.Trim() == sConfirmPss.Trim());
        }

        private void _SaveTribeMemberToDatabase(Form oParentForm, string sUsrNm, string sPss, string sMl, bool bCloseParent = true)
        {
            if (mTribeMember.LgIn)
            {
                m_oDataAccess.UpdateTribeMemberPasswd(sPss.Trim());
                m_oMessageBox.Show(StringProvider.sTribeMemberAmended);
                if (bCloseParent) oParentForm.Close();
                return;
            }

            if (m_oDataAccess.TribeMemberExists(sUsrNm))
            {
                m_oMessageBox.Show(StringProvider.sTribeMemberExists);
            }
            else
            {
                m_oDataAccess.InsertTribeMember(sUsrNm.Trim(), sPss.Trim(), mTribeMember.DefaultTbNm.Trim(), sMl.Trim());
                m_oMessageBox.Show(StringProvider.sTribeMemberCreated);
                if (bCloseParent) oParentForm.Close();
            }
        }

        #endregion
    }
}
