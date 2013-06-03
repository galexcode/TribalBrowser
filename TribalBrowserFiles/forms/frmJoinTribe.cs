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

namespace TribalBrowser.Forms
{
    public partial class frmJoinTribe : Form
    {
        #region Member variables

        private TribesGrid m_oTribesGrid;

        #endregion

        #region Constructors/ Initialisers

        public frmJoinTribe()
        {
            InitializeComponent();
        }

        private void frmJoinTribe_Load(object sender, EventArgs e)
        {
            m_oTribesGrid = new TribesGrid(dgTribes);
            m_oTribesGrid.FindTop20Tribes();
        }

        #endregion

        #region public Methods

        public void AllowDelete()
        {
            dgTribes.Columns["colDelete"].Visible = true;
            Width = Width + 100;
            btnJoin.Visible = false;
        }

        #endregion

        #region Controls

        private void btnJoin_Click(object sender, EventArgs e)
        {
            m_oTribesGrid.JoinTribe(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            m_oTribesGrid.FindTribeAndTop20(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            m_oTribesGrid.FindTribeAndTop20(txtSearch.Text);
        }

        #endregion

        #region Private Helpers

        private void _AddTooltips()
        {
        }

        #endregion
    }
}
