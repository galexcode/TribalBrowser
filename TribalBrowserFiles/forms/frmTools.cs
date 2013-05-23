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

namespace TribalBrowser.forms
{
    public partial class frmTools : Form
    {
        #region Constructors/ Initialisers

        public frmTools()
        {
            InitializeComponent();
        }

        #endregion

        #region Controls

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmInsertTribe ofrmCreate = new frmInsertTribe();
            ofrmCreate.ShowDialog();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            frmJoinTribe ofrmJoin = new frmJoinTribe();
            ofrmJoin.ShowDialog();
        }

        private void myDetails_Click(object sender, EventArgs e)
        {
            frmDetailsSites ofrmDetailSites = new frmDetailsSites();
            ofrmDetailSites.ShowDialog();
        }

        private void btnCreateLinks_Click(object sender, EventArgs e)
        {
            frmInsertTribeLinks ofrmSites = new frmInsertTribeLinks();
            ofrmSites.ShowDialog();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmTribeMemberDetails ofrmDetails = new frmTribeMemberDetails();
            ofrmDetails.ShowDialog();
        }

        #endregion
    }
}
