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
using System.Windows.Forms;
using TribalHelper;
using TribeLogon = TribalLogin.Helpers.TribeLogon;

namespace TribalLogin.Forms
{
    public partial class frmTribeMemberDetails : Form
    {
        #region Member variables

        private readonly TribeLogon m_oTribeLogon = new TribeLogon();

        #endregion

        #region Constructors/ Initialisers

        public frmTribeMemberDetails()
        {
            InitializeComponent();
        }

        private void frmTribeMemberDetails_Load(object sender, EventArgs e)
        {
            if (mTribeMember.LgIn)
            {
                txtUsrNm.Text = mTribeMember.UsrNm;
                txtUsrNm.ReadOnly = true;
                txtUsrNm.Enabled = false;
                m_oTribeLogon.ShowMyDetails(txtUsrNm, txtPss, txtConfirmPss);
            }
        }

        #endregion

        #region Controls

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            m_oTribeLogon.SaveTribeMember(this, txtUsrNm.Text, txtPss.Text, txtConfirmPss.Text, txtMl.Text, false);
        }

        #endregion
    }
}
