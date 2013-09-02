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
using TribalHelper;
using TribalMessageBox;

namespace TribalBrowser.Forms
{
    public partial class frmCreateProfile : Form
    {
        #region Member variables

        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();
        private string _sPfNm = "";

        #endregion

        #region Constructors/ Initialisers

        public frmCreateProfile()
        {
            InitializeComponent();
        }

        public frmCreateProfile(string sPfNm)
        {
            InitializeComponent();
            _sPfNm = sPfNm;
        }

        private void frmCreateProfile_Load(object sender, EventArgs e)
        {
            _LoadProfile();
            _ResetComment();
        }

        #endregion

        #region Controls

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                var img = Image.FromFile(openFileDialog.FileName).GetThumbnailImage(500, 500, null, IntPtr.Zero);
                picPfImg.Image = img;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bmpPfImg = new Bitmap(picPfImg.Image);
            if (m_oDataAccess.TribeProfileExists(txtPfNm.Text))
            {
                m_oDataAccess.UpdateTribeProfile(txtPfNm.Text, txtPfAbt.Text, bmpPfImg, mTribeMember.UsrNm);
            }
            else
            {
                m_oDataAccess.InsertTribeProfile(txtPfNm.Text, txtPfAbt.Text, bmpPfImg, mTribeMember.UsrNm);
            }
            Cursor.Current = Cursors.Default;
            m_oMessageBox.Show(StringProvider.sProfileSaved);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ResetComment();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _SendComment();
        }

        #endregion

        #region Private Helpers

        private void _LoadProfile()
        {
            if (_sPfNm == "") return;
            TribeProfile oTribeProfile = m_oDataAccess.FindTribeProfile(_sPfNm);
            txtPfNm.Text = oTribeProfile.PfNm.ToLower();
            txtPfAbt.Text = oTribeProfile.PfAbt.ToLower();
            picPfImg.Image = oTribeProfile.PfImg;
            if (mTribeMember.UsrNm != oTribeProfile.UsrNm) _DisableFields();
        }

        private void _DisableFields()
        {
            txtPfNm.ReadOnly = true;
            txtPfNm.ReadOnly = true;
            btnSave.Enabled = false;
            btnUploadImg.Enabled = false;
        }

        private void _ResetComment()
        {
            _ShowTribeComment();
            txtPfCmt.Text = ">";
            txtPfCmt.SelectionStart = txtPfCmt.Text.Length;
            if (dgPfCmts.RowCount > 0) dgPfCmts.FirstDisplayedScrollingRowIndex = dgPfCmts.RowCount - 1;
        }

        private void _SendComment()
        {
            m_oDataAccess.InsertTribeProfileComment(txtPfNm.Text,txtPfCmt.Text + Environment.NewLine, DateTime.Now);
            _ResetComment();
        }

        private void _ShowTribeComment()
        {
            dgPfCmts.DataSource = m_oDataAccess.FindAllTribeProfileComment(txtPfNm.Text);
        }

        #endregion
    }
}
