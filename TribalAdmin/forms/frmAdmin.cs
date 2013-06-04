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
using TribalBrowser.Forms;
using TribalLogin.Helpers;

namespace TribalAdmin.forms
{
    public partial class frmAdmin : Form
    {
        #region Member variables
        
        TribeLogon oTribeLogon = new TribeLogon();

        #endregion

        #region Constructors/ Initialisers

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, System.EventArgs e)
        {
            oTribeLogon.ShowWindowForm(this);
        }

        #endregion

        #region Controls

        private void btnDeleteTribe_Click(object sender, System.EventArgs e)
        {
            _ShowJoinTribeInDeleteMode();
        }

        private void btnDeleteTribeLinks_Click(object sender, System.EventArgs e)
        {
            _ShowAllTribesAndLinks();
        }

        private void btnDeleteTribeMember_Click(object sender, System.EventArgs e)
        {
            _ShowDeleteTribeMember();
        }

        private void btnBlockTribeLinks_Click(object sender, System.EventArgs e)
        {
            _ShowBlockTribeLinks();
        }

        private void btnClearTribeChat_Click(object sender, System.EventArgs e)
        {
            _ShowClearTribeChat();
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            frmBrowser ofrmBrowser = new frmBrowser();
            ofrmBrowser.Show();
            ofrmBrowser.BringToFront();
        }
        #endregion

        #region Private Helpers

        private void _ShowJoinTribeInDeleteMode()
        {
            frmJoinTribe ofrmJoinTribe = new frmJoinTribe();
            ofrmJoinTribe.AllowDelete();
            oTribeLogon.ShowDialogForm(ofrmJoinTribe);
        }

        private void _ShowAllTribesAndLinks()
        {
            //TODO: Create new form with search facility
            frmInsertTribeLinks ofrmInsertTribeLinks = new frmInsertTribeLinks();
            oTribeLogon.ShowWindowForm(ofrmInsertTribeLinks);
            ofrmInsertTribeLinks.ShowAllTribeLinks();
        }

        private void _ShowBlockTribeLinks()
        {
            frmBlockTribeLinks ofrmBlockTribeLinks = new frmBlockTribeLinks();
            oTribeLogon.ShowDialogForm(ofrmBlockTribeLinks);
        }

        private void _ShowClearTribeChat()
        {
            frmClearTribeChat ofrmClearTribeChat = new frmClearTribeChat();
            oTribeLogon.ShowDialogForm(ofrmClearTribeChat);
        }

        private void _ShowDeleteTribeMember()
        {
            frmDeleteTribeMember ofrmDeleteTribeMember = new frmDeleteTribeMember();
            oTribeLogon.ShowDialogForm(ofrmDeleteTribeMember);
        }

        #endregion     
    }
}
