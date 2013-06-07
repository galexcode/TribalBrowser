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
using TribalHelper;
using TribalMessageBox;

namespace TribalAdmin.forms
{
    public partial class frmDeleteTribeMember : Form
    {
        #region Member variable

        private TribeMemberGrid m_oTribeMemberGrid;

        #endregion

        #region Constructors/ Initialisers

        public frmDeleteTribeMember()
        {
            InitializeComponent();
        }

        private void frmDeleteTribeMember_Load(object sender, System.EventArgs e)
        {
            m_oTribeMemberGrid = new TribeMemberGrid(dgTribeMembers);
            m_oTribeMemberGrid.FindAllTribeMembers();
        }

        #endregion

        #region Controls

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            m_oTribeMemberGrid.FindOneTribeMember(txtSearch.Text);
        }

        #endregion

        private void dgTribeMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_oTribeMemberGrid.ClickCell(e);
        }

        #region Private Helpers

     
        #endregion
    }
}
