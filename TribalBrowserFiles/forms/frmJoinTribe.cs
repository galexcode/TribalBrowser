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
    public partial class frmJoinTribe : Form
    {
        readonly DataAccess m_oDataAccess = new DataAccess();
        readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        public frmJoinTribe()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            _JoinTribe();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgTribes.DataSource = m_oDataAccess.FindTribeAndTop20(txtSearch.Text);
        }

        private void frmJoinTribe_Load(object sender, EventArgs e)
        {
            dgTribes.DataSource = m_oDataAccess.FindTop20Tribes();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgTribes.DataSource = m_oDataAccess.FindTribeAndTop20(txtSearch.Text);
        }

        #region Private Helper Methods

        private void _AddTooltips()
        {


        }

        private void _JoinTribe()
        {
            string sTbNm = dgTribes["colTbNm", dgTribes.CurrentRow.Index].Value.ToString();
            if (sTbNm != "")
            {
                m_oDataAccess.UpdateTribeMemberTribe(sTbNm);
                TribeMisc.SaveUserInfo(sTbNm);
                m_oMessageBox.Show(StringProvider.sTribeJoined + sTbNm);
                this.Close();
            }
            else
            {
                m_oMessageBox.Show(StringProvider.sTribeNameBlank);
            }
        }

        #endregion
    }
}
