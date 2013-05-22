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
        private TribesGrid m_oTribesGrid;

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
            m_oTribesGrid = new TribesGrid(dgMyTribes);
            _AddTooltips();
            _PopulateFields();
        }

        private void dgMySites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_oTribeSitesGrid.ClickCell(e);
        }

        private void dgMySites_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_oTribeSitesGrid.ValidateUrl(e);
        }
                
        private void dgMyTribes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_oTribesGrid.ClickCell(e);
        }

        #region private helper methods

        private void _AddTooltips()
        {


        }

        private void _PopulateFields()
        {
            _ShowMyDetails();
            m_oTribesGrid.ShowAllMyTribes();
            if (dgMyTribes["colTrTbNm", 0].Value != null) m_oTribeSitesGrid.ShowAllMyTribeLinks(dgMyTribes["colTrTbNm", 0].Value.ToString());
        }

        private void _ShowMyDetails()
        {
            TribeMember oTribeMember = new TribeMember();
            oTribeMember = m_oDataAccess.FindTribeMember();
            txtUsrNm.Text = oTribeMember.UsrNm;
            txtPss.Text = oTribeMember.Pss;
            txtConfirmPss.Text = oTribeMember.Pss;
        }

        #endregion
    }
}
