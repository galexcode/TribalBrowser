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
using System;
using TribalHelper;

namespace TribalBrowser.Forms
{
    public partial class frmChat : Form
    {
        //TODO: Put this in the TribeChat class

        #region Member variables

        private readonly DataAccess m_oDataAccess = new DataAccess();

        #endregion

        #region Constructors/ Initialisers

        public frmChat()
        {
            InitializeComponent();
        }

        private void frmChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            _EndChat();
        }

        #endregion

        private void frmChat_Load(object sender, System.EventArgs e)
        {
            _JoinChat();
            _ResetChat();
        }

        #region Controls

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            _ResetChat();
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            _SendMsg();
        }

        private void dgTribeChat_SizeChanged(object sender, EventArgs e)
        {
            dgTribeChat.Columns["Msg"].Width = dgTribeChat.Width - 10;
        }

        #endregion

        #region Private Helpers

        private void _ShowTribeChat()
        {
            dgTribeChat.DataSource = m_oDataAccess.FindTop50TribeChat(mTribeMember.TbNm);
        }

        private void _SendMsg()
        {
            m_oDataAccess.InsertTribeChat(mTribeMember.UsrNm, mTribeMember.TbNm,
               mTribeMember.UsrNm + txtChat.Text + Environment.NewLine, DateTime.Now);
            _ResetChat();
        }

        private void _ResetChat()
        {
            _ShowTribeChat();
            txtChat.Text = ">";
            txtChat.SelectionStart = txtChat.Text.Length;
            dgTribeChat.FirstDisplayedScrollingRowIndex = dgTribeChat.RowCount - 1;
        }

        private void _JoinChat()
        {
            m_oDataAccess.InsertTribeChat(mTribeMember.UsrNm, mTribeMember.TbNm,
             "{" + mTribeMember.UsrNm + StringProvider.sJoinChat + "}" + Environment.NewLine, DateTime.Now);
        }

        private void _EndChat()
        {
            m_oDataAccess.InsertTribeChat(mTribeMember.UsrNm, mTribeMember.TbNm,
           "{" + mTribeMember.UsrNm + StringProvider.sEndChat + "}" + Environment.NewLine, DateTime.Now);
        }

        #endregion

    }
}
