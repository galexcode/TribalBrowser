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

using System;
using System.Drawing;
using System.Windows.Forms;
using TribalBrowser.helpers;

namespace TribalBrowser.forms
{
    public partial class frmLogin : Form
    {
        readonly DataAccess m_oDataAccess = new DataAccess();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mTribeMember.UsrNm = txtUsrNm.Text;
            m_oDataAccess.Login();
            Visible = false;
            frmTools ofrmTools = new frmTools();
            ofrmTools.ShowDialog();
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmTribeMemberDetails ofrmTM = new frmTribeMemberDetails();
            ofrmTM.ShowDialog();
        }

        private void txtPss_TextChanged(object sender, EventArgs e)
        {
            _CheckPassword();
        }

        private void txtUsrNm_TextChanged(object sender, EventArgs e)
        {
            _CheckPassword();
        }

        #region Private Helper methods

        private void _AddTooltips()
        {
            
        }

        private void _CheckPassword()
        {
            lblCheckPass.Visible = true;
            if (m_oDataAccess.PasswordCorrect(txtUsrNm.Text, txtPss.Text))
            {
                btnLogin.Enabled = true;
                lblCheckPass.Text = StringProvider.sCorrect;
                lblCheckPass.ForeColor = Color.LawnGreen;
                btnLogin.BackgroundImage = Properties.Resources.tick;
            }
            else
            {
                btnLogin.Enabled = false;
                lblCheckPass.Text = StringProvider.sInCorrect; ;
                lblCheckPass.ForeColor = Color.OrangeRed;
                btnLogin.BackgroundImage = Properties.Resources.cross;
            }
        }

        #endregion
    }
}
