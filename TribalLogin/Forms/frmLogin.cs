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

using System;
using System.Drawing;
using System.Windows.Forms;
using TribalHelper;
using TribalMessageBox;

namespace TribalLogin.Forms
{
    public partial class frmLogin : Form
    {
        #region Member variables

        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_ofrmMessageBox = new frmMessageBox();
        private readonly Form m_oOpeningForm;
        private readonly bool m_bAdminMode = false;

        #endregion

        #region Constructors/ Initialisers

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(bool bAdminMode)
        {
            InitializeComponent();
            m_bAdminMode = bAdminMode;
        }

        public frmLogin(Form oOpeningForm)
        {
            m_oOpeningForm = oOpeningForm;
            InitializeComponent();
        }

        public frmLogin(Form oOpeningForm, bool bAdminMode)
        {
            m_oOpeningForm = oOpeningForm;
            InitializeComponent();
            m_bAdminMode = bAdminMode;
        }

        #endregion

        #region Controls

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Login();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmTribeMemberDetails ofrmTM = new frmTribeMemberDetails();
            ofrmTM.ShowDialog();
            ofrmTM.BringToFront();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            _ForgotPassword();
        }

        #endregion

        #region Private Helpers

        private void _ForgotPassword()
        {
            if (String.IsNullOrEmpty(txtUsrNm.Text.Trim()))
            {
                m_ofrmMessageBox.Show(StringProvider.sEnterUserName);
                return;
            }

            TribeMember oTribeMember = m_oDataAccess.FindTribeMember(txtUsrNm.Text.Trim());

            if (oTribeMember == null)
            {
                m_ofrmMessageBox.Show(StringProvider.sUsernameNotFound);
                return;
            }

            if (String.IsNullOrEmpty(oTribeMember.Ml))
            {
                m_ofrmMessageBox.Show(StringProvider.sNoEmail);
                return;
            }

            TribeEmail.SendMail(oTribeMember.Ml, StringProvider.sForgotPssSubj, StringProvider.sForgotPssMssg + oTribeMember.Pss);
        }

        private void _AddTooltips()
        {
        }

        private bool _PasswordCorrect()
        {
            lblCheckPass.Visible = true;

            if (m_oDataAccess.PasswordCorrect(txtUsrNm.Text, txtPss.Text))
            {
                _CorrectLogin();
                if (m_bAdminMode)
                {
                    return _IsTribalElder();
                }
                return true;
            }
            else
            {
                _IncorrectLogin();
                return false;
            }
        }

        private bool _IsTribalElder()
        {
            if (!TribalElders.UserNames.Contains(txtUsrNm.Text.Trim()))
            {
                _IncorrectLogin();
                lblCheckPass.Text = StringProvider.sNotTribalElder;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void _IncorrectLogin()
        {
            lblCheckPass.Text = StringProvider.sInCorrect;
            lblCheckPass.ForeColor = Color.OrangeRed;
        }

        private void _CorrectLogin()
        {
            lblCheckPass.Text = StringProvider.sCorrect;
            lblCheckPass.ForeColor = Color.LawnGreen;
        }

        private void _Login()
        {
            if (_PasswordCorrect())
            {
                mTribeMember.UsrNm = txtUsrNm.Text;
                m_oDataAccess.Login();
                Visible = false;
                Hide();
                if (m_oOpeningForm != null)
                {
                    m_oOpeningForm.ShowDialog();
                    m_oOpeningForm.BringToFront();
                }
                Close();
            }
        }

        #endregion
    }
}
