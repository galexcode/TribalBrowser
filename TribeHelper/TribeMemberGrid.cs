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
using TribalMessageBox;
using MongoDB.Bson;
namespace TribalHelper
{
    public class TribeMemberGrid
    {
        #region Member Variables

        private readonly DataGridView m_oDataGridView;
        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        #endregion

        #region Constructors/ Initialisers

        public TribeMemberGrid(DataGridView oDataGridView)
        {
            m_oDataGridView = oDataGridView;
        }

        #endregion

        #region Public methods

        public void ClickCell(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == m_oDataGridView.Columns["colDelete"].Index && e.RowIndex >= 0)
            {
                _DeleteTribeMember(e);
            }
        }

        public void FindAllTribeMembers()
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindAllTribeMembers();
        }

        public void FindOneTribeMember(string sUsrNm)
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindOneTribeMember(sUsrNm);
        }

        #endregion

        #region Private Helpers

        private void _DeleteTribeMember(DataGridViewCellEventArgs e)
        {
            if (m_oMessageBox.ShowCancel(StringProvider.sConfirmDeleteTribeMember + m_oDataGridView["colUsrNm", e.RowIndex].Value.ToString().Trim()) == DialogResult.OK)
            {
                m_oDataAccess.DeleteTribeMember((ObjectId)m_oDataGridView["colId", e.RowIndex].Value);
                FindAllTribeMembers();
            }
        }

        #endregion
    }
}
