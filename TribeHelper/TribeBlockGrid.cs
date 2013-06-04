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
using System;
using MongoDB.Bson;


namespace TribalHelper
{
    public class TribeBlockGrid
    {
        #region Member Variables

        private readonly DataGridView m_oDataGridView;
        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        #endregion

        #region Constructors/ Initialisers

        public TribeBlockGrid(DataGridView oDataGridView)
        {
            m_oDataGridView = oDataGridView;
        }

        #endregion

        #region Public methods

        public void SaveTribeBlock(DataGridViewCellEventArgs e)
        {
            if (m_oDataGridView["colTbNm", e.RowIndex].Value == null) return;
            if (String.IsNullOrEmpty(m_oDataGridView["colTbNm", e.RowIndex].Value.ToString().Trim()))
            {
                m_oMessageBox.Show(StringProvider.sTribeLinkBlank);
                return;
            }

            if (TribeMisc.CheckUrlExists(m_oDataGridView["colUrl", e.RowIndex].Value.ToString()) == false)
            {
                m_oMessageBox.Show(StringProvider.sTribeLinkUrlBad);
                return;
            }

            ObjectId oRowID = (ObjectId)m_oDataGridView["colId", e.RowIndex].Value; //Get the row id if it exists
            if (oRowID == ObjectId.Empty)
            {
                _InsertTribeBlock(e);
            }
            else
            {
                _UpdateTribeBlock(e);
            }
        }

        public void DeleteTribeBlock(DataGridViewCellEventArgs e)
        {
            if (m_oMessageBox.ShowCancel(StringProvider.sConfirmDeleteTribeSite + m_oDataGridView["colUrl", e.RowIndex].Value.ToString().Trim()) == DialogResult.OK)
            {
                m_oDataAccess.DeleteTribeLinks(m_oDataGridView["colSt", e.RowIndex].Value.ToString().Trim(), mTribeMember.TbNm);
                RefreshGrid();
            }
        }

        public void RefreshGrid()
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindAllTribeBlocks();
        }

        public void ClickCell(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == m_oDataGridView.Columns["colSaveUrl"].Index && e.RowIndex >= 0)
            {
                SaveTribeBlock(e);
            }

            if (e.ColumnIndex == m_oDataGridView.Columns["colDeleteUrl"].Index && e.RowIndex >= 0)
            {
                DeleteTribeBlock(e);
            }
        }

        public void ValidateUrl(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == m_oDataGridView.Columns["colUrl"].Index && e.RowIndex >= 0)
            {
                if (m_oDataGridView["colUrl", e.RowIndex].Value == null) return;
                m_oDataGridView["colUrl", e.RowIndex].Value = TribeMisc.StripHttp(m_oDataGridView["colUrl", e.RowIndex].Value.ToString());
            }
        }

        public void FindTribeBlocks(string sSearch)
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindTribeBlocks(sSearch.Trim());
        }

        #endregion

        #region Private methods

        private void _UpdateTribeBlock(DataGridViewCellEventArgs e)
        {
            m_oDataAccess.UpdateTribeBlock((ObjectId)m_oDataGridView["colId", e.RowIndex].Value,
                  m_oDataGridView["colTbNm", e.RowIndex].Value.ToString().Trim(),
                  m_oDataGridView["colUrl", e.RowIndex].Value.ToString().Trim());
            m_oMessageBox.Show(StringProvider.sTribeLinkSaved);
        }

        private void _InsertTribeBlock(DataGridViewCellEventArgs e)
        {
            m_oDataAccess.InsertTribeBlock(m_oDataGridView["colTbNm", e.RowIndex].Value.ToString().Trim(),
                   m_oDataGridView["colUrl", e.RowIndex].Value.ToString().Trim());
            m_oMessageBox.Show(StringProvider.sTribeLinkSaved);
        }
        
        #endregion
    }
}
