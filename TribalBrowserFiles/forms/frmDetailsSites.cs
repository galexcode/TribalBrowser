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

namespace TribalBrowser.forms
{
    public partial class frmDetailsSites : Form
    {
        readonly DataAccess m_oDataAccess = new DataAccess();
        readonly frmMessageBox m_oMessageBox = new frmMessageBox();
        private TribeSitesGrid m_oTribeSitesGrid;

        public frmDetailsSites()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmDetailsSites_Load(object sender, EventArgs e)
        {
            m_oTribeSitesGrid = new TribeSitesGrid(dgMySites);
            _AddTooltips();
            _PopulateFields();
        }

        private void dgMySites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgMySites.Columns["colSaveSite"].Index && e.RowIndex >= 0)
            {
                m_oTribeSitesGrid.SaveTribeLink(e);
            }

            if (e.ColumnIndex == dgMySites.Columns["colDeleteSite"].Index && e.RowIndex >= 0)
            {
                m_oTribeSitesGrid.DeleteTribeLink(e);
            }
        }

        private void dgMySites_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_oTribeSitesGrid.ValidateUrl(e);
        }
                
        private void dgMyTribes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgMyTribes.Columns["colSaveTribe"].Index && e.RowIndex >= 0)
            {
                _UpdateTribe(e);
            }
        }

        #region private helper methods

        private void _AddTooltips()
        {


        }

        private void _UpdateTribe(DataGridViewCellEventArgs e)
        {
            if (_MyTribeFieldsNull(e))
            {
                m_oMessageBox.Show(StringProvider.sTribeBlank);
                return;
            }

            m_oDataAccess.UpdateTribe(dgMyTribes["colTrTbNm", e.RowIndex].Value.ToString().Trim(),
                                dgMyTribes["colTrDsc", e.RowIndex].Value.ToString().Trim());
            m_oMessageBox.Show(StringProvider.sTribeDetailsSaved);
        }

        private bool _MyTribeFieldsNull(DataGridViewCellEventArgs e)
        {
            bool bFieldsAreNull = (dgMyTribes["colTrTbNm", e.RowIndex].Value == null);

            if (dgMyTribes["colTrDsc", e.RowIndex].Value == null)
            {
                bFieldsAreNull = true;
            }

            return bFieldsAreNull;
        }

        private void _PopulateFields()
        {
            _ShowMyDetails();
            _ShowTribeList();
        }

        private void _ShowMyDetails()
        {
            TribeMember oTribeMember = new TribeMember();
            oTribeMember = m_oDataAccess.FindTribeMember();
            txtUsrNm.Text = oTribeMember.UsrNm;
            txtPss.Text = oTribeMember.Pss;
            txtConfirmPss.Text = oTribeMember.Pss;
        }

        private void _ShowTribeList()
        {
            dgMyTribes.DataSource = m_oDataAccess.FindAllMyTribes(mTribeMember.UsrNm);
            if (dgMyTribes["colTrTbNm", 0].Value != null) _ShowSiteList(dgMyTribes["colTrTbNm", 0].Value.ToString());
        }

        private void _ShowSiteList(string sTbNm)
        {
            dgMySites.DataSource = m_oDataAccess.FindAllMyTribeLinks(mTribeMember.UsrNm, sTbNm);
        }

        #endregion

    }
}
