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

namespace TribalAdmin.forms
{
    public partial class frmClearTribeChat : Form
    {
        #region Member Variables

        private TribesGrid m_oTribesGrid;
        private TribeChatGrid m_oTribeChat;

        #endregion

        #region Constructors/ Initialisers

        public frmClearTribeChat()
        {
            InitializeComponent();
        }

        private void frmClearTribeChat_Load(object sender, System.EventArgs e)
        {
            m_oTribesGrid = new TribesGrid(dgTribes);
            m_oTribesGrid.FindTop20Tribes();
            m_oTribeChat = new TribeChatGrid(dgTribeChat);
        }

        #endregion

        #region Controls

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            m_oTribesGrid.FindTribeAndTop20(txtSearch.Text);
        }

        #endregion

        private void dgTribes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTribes["colTrTbNm", dgTribes.CurrentRow.Index].Value == null) return;
            string sTbNm = dgTribes["colTrTbNm", dgTribes.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == dgTribes.Columns["colClear"].Index && e.RowIndex >= 0) m_oTribeChat.DeleteTribeChat(sTbNm);
            m_oTribeChat.FindTribeChat(sTbNm);
        }
               
        #region Private Helpers
                
        #endregion
    }
}
