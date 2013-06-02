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
    public partial class frmInsertTribe : Form
    {
        #region Member variables

        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();
        
        #endregion

        #region Constructors/ Initialisers

        public frmInsertTribe()
        {
            InitializeComponent();
        }

        #endregion

        #region Controls

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _CreateTribe();
        }

        #endregion

        #region Private Helpers

        private void _CreateTribe()
        {
            if (m_oDataAccess.TribeExists(txtTbNm.Text))
            {
                m_oMessageBox.Show(StringProvider.sTribeExists);
                return;
            }

            if (txtTbNm.Text == "" || txtDsc.Text == "")
            {
                m_oMessageBox.Show(StringProvider.sTribeBlank);
                return;
            }

            m_oDataAccess.InsertTribe(txtTbNm.Text, txtDsc.Text,mTribeMember.UsrNm);
            m_oDataAccess.UpdateTribeMemberTribe(txtTbNm.Text);
            m_oMessageBox.Show(StringProvider.sTribeCreated);
        }

        #endregion
    }
}
