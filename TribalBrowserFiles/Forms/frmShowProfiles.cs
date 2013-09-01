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
using TribalMessageBox;

namespace TribalBrowser.Forms
{
    public partial class frmShowProfiles : Form
    {
        #region Member variables

        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        #endregion

        #region Constructors/ Initialisers

        public frmShowProfiles()
        {
            InitializeComponent();
        }

        private void frmShowProfiles_Load(object sender, EventArgs e)
        {
            _ShowProfiles();
        }

        #endregion

        #region Controls

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgProfiles.DataSource = m_oDataAccess.FindTribeProfilesAndTop20(txtSearch.Text);
        }

        private void dgProfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _ShowProfile(e);
        }

        #endregion

        #region Private Helpers

        private void _ShowProfiles()
        {
            dgProfiles.DataSource = m_oDataAccess.FindAllTribeProfiles();
        }

        private void _ShowProfile(DataGridViewCellEventArgs e)
        {
            string sPfNm = "";
            if (e.ColumnIndex == dgProfiles.Columns["colPfNm"].Index && e.RowIndex >= 0)
            {
                 sPfNm = dgProfiles["colPfNm", dgProfiles.CurrentRow.Index].Value.ToString();
            }
            if (sPfNm != "")
            {
                frmCreateProfile ofrmCreateProfile = new frmCreateProfile(sPfNm);
                ofrmCreateProfile.Show();
                ofrmCreateProfile.BringToFront();
                ofrmCreateProfile.Focus();
            }
        }
        #endregion
    }
}
