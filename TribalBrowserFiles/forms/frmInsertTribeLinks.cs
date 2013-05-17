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
using TribalBrowser.helpers;
using System.Net;

namespace TribalBrowser.forms
{
    public partial class frmInsertTribeLinks : Form
    {
        readonly DataAccess m_oDataAccess = new DataAccess();
        readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        public frmInsertTribeLinks()
        {
            InitializeComponent();
        }

        private void frmInsertTribeLinks_Load(object sender, EventArgs e)
        {
           _RefreshGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dgMySites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgMySites.Columns["colSaveSite"].Index && e.RowIndex >= 0)
            {
                _SaveTribeLink(e);
            }

            if (e.ColumnIndex == dgMySites.Columns["colDeleteSite"].Index && e.RowIndex >= 0)
            {
                _DeleteTribeLink(e);
            }
        }

        private void dgMySites_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgMySites.Columns["colUrl"].Index && e.RowIndex >= 0)
            {
                if (dgMySites["colUrl", e.RowIndex].Value == null) return;
                dgMySites["colUrl", e.RowIndex].Value = TribeMisc.StripHttp( dgMySites["colUrl", e.RowIndex].Value.ToString());
            }
        }

        #region Private Helper methods

        private void _DeleteTribeLink(DataGridViewCellEventArgs e)
        {
            if (_CheckIfAnyFieldsNull(e)) return;
            if (m_oMessageBox.ShowCancel(StringProvider.sConfirmDeleteTribeSite + dgMySites["colSt", e.RowIndex].Value.ToString().Trim()) == DialogResult.OK)
            {
                m_oDataAccess.DeleteTribeLinks(dgMySites["colSt", e.RowIndex].Value.ToString().Trim(), mTribeMember.TbNm);
                _RefreshGrid();
            }
        }

        private void _SaveTribeLink(DataGridViewCellEventArgs e)
        {
            if (_CheckIfAnyFieldsNull(e) == true)
            {
                m_oMessageBox.Show(StringProvider.sTribeSiteUrlNull);
                return;
            }

            if (String.IsNullOrEmpty(dgMySites["colSt", e.RowIndex].Value.ToString().Trim()))
            {
                m_oMessageBox.Show(StringProvider.sTribeLinkBlank);
                return;
            }

            if (m_oDataAccess.DoesTribeLinkExist(dgMySites["colSt", e.RowIndex].Value.ToString(),
                    mTribeMember.TbNm) == true)
            {
                m_oMessageBox.Show(StringProvider.sTribeLinkExists);
                return;
            }

            if (_CheckUrlExists(dgMySites["colUrl", e.RowIndex].Value.ToString()) == false)
            {
                m_oMessageBox.Show(StringProvider.sTribeLinkUrlBad);
                return;
            }

            m_oDataAccess.InsertTribeLinks(dgMySites["colSt", e.RowIndex].Value.ToString().Trim(),
                   dgMySites["colUrl", e.RowIndex].Value.ToString().Trim(),
                   TribeMisc.ConvertIfNull(dgMySites["colDsc", e.RowIndex].Value),
                   mTribeMember.TbNm, mTribeMember.UsrNm);
            m_oMessageBox.Show(StringProvider.sTribeLinkSaved);
        }

        private bool _CheckUrlExists(string sUrl)
        {
            bool bExists = true;

            try
            {
                WebRequest webRequest = WebRequest.Create(TribeMisc.AddHttp(sUrl));
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

        private bool _CheckIfAnyFieldsNull(DataGridViewCellEventArgs e)
        {
            bool bFieldsAreNull = (dgMySites["colSt", e.RowIndex].Value == null);

            if (dgMySites["colUrl", e.RowIndex].Value == null)
            {
                bFieldsAreNull = true;
            }

            return bFieldsAreNull;
        }

        private void _RefreshGrid()
        {
            dgMySites.DataSource = m_oDataAccess.FindAllMyTribeLinks(mTribeMember.UsrNm, mTribeMember.TbNm);
        }

        #endregion
    }
}
