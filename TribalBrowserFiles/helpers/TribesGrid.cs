﻿#region GPL Licence

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
using TribalBrowser.forms;
namespace TribalBrowser.helpers
{
    public class TribesGrid
    {
        private DataGridView m_oDataGridView;
        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        public TribesGrid(DataGridView oDataGridView)
        {
            m_oDataGridView = oDataGridView;
        }

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

        #region Private Helper Methods

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