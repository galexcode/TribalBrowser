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

namespace TribalHelper
{
    public class TribesGrid
    {
        #region Member Variables

        private readonly DataGridView m_oDataGridView;
        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        #endregion

        #region Constructors/ Initialisers

        public TribesGrid(DataGridView oDataGridView)
        {
            m_oDataGridView = oDataGridView;
        }

        #endregion

        #region Public methods

        public void ClickCell(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == m_oDataGridView.Columns["colSaveTribe"].Index && e.RowIndex >= 0)
            {
                _UpdateTribe(e);
            }
        }

        public void ShowAllMyTribes()
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindAllMyTribes(mTribeMember.UsrNm);
        }

        public void JoinTribe(Form oParent)
        {
            string sTbNm = m_oDataGridView["colTbNm", m_oDataGridView.CurrentRow.Index].Value.ToString();
            if (sTbNm != "")
            {
                m_oDataAccess.UpdateTribeMemberTribe(sTbNm);
                TribeMisc.SaveUserInfo(sTbNm);
                m_oMessageBox.Show(StringProvider.sTribeJoined + sTbNm);
                oParent.Close();
            }
            else
            {
                m_oMessageBox.Show(StringProvider.sTribeNameBlank);
            }
        }

        public void FindTop20Tribes()
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindTop20Tribes();
        }

        public void FindTribeAndTop20(string sSearch)
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindTribeAndTop20(sSearch.Trim());
        }

        #endregion

        #region Private Helpers

        private void _UpdateTribe(DataGridViewCellEventArgs e)
        {
            if (_MyTribeFieldsNull(e))
            {
                m_oMessageBox.Show(StringProvider.sTribeBlank);
                return;
            }

            m_oDataAccess.UpdateTribe(m_oDataGridView["colTrTbNm", e.RowIndex].Value.ToString().Trim(),
                                m_oDataGridView["colTrDsc", e.RowIndex].Value.ToString().Trim());
            m_oMessageBox.Show(StringProvider.sTribeDetailsSaved);
        }

        private bool _MyTribeFieldsNull(DataGridViewCellEventArgs e)
        {
            bool bFieldsAreNull = (m_oDataGridView["colTrTbNm", e.RowIndex].Value == null);

            if (m_oDataGridView["colTrDsc", e.RowIndex].Value == null)
            {
                bFieldsAreNull = true;
            }

            return bFieldsAreNull;
        }

        #endregion
    }
}
