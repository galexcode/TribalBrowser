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
    public partial class frmInsertTribeLinks : Form
    {
        #region Member variables

        private TribeSitesGrid m_oTribeSitesGrid;

        #endregion

        #region Constructors/ Initialisers

        public frmInsertTribeLinks()
        {
            InitializeComponent();
        }

        private void frmInsertTribeLinks_Load(object sender, EventArgs e)
        {
            m_oTribeSitesGrid = new TribeSitesGrid(dgMySites);
            m_oTribeSitesGrid.RefreshGrid();
        }

        #endregion

        #region Public Methods

        public void ShowAllTribeLinks()
        {
            if (m_oTribeSitesGrid == null) m_oTribeSitesGrid = new TribeSitesGrid(dgMySites);
            m_oTribeSitesGrid.AdminMode = true;
            m_oTribeSitesGrid.FindAllTribeLinks();
        }

        #endregion

        #region Controls

        private void dgMySites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_oTribeSitesGrid.ClickCell(e);
        }

        private void dgMySites_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_oTribeSitesGrid.ValidateUrl(e);
        }
       
        #endregion
    }
}
