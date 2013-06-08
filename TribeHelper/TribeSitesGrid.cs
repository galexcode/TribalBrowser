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
using System.Net;
using System.Windows.Forms;
using TribalMessageBox;
using MongoDB.Bson;

namespace TribalHelper
{
    public class TribeSitesGrid
    {
        #region Member Variables

        private readonly frmMessageBox m_oMessageBox = new frmMessageBox();
        private readonly DataAccess m_oDataAccess = new DataAccess();
        private readonly DataGridView m_oDataGridView;
        private bool bAdminMode = false;

        #endregion

        #region Public Properties

        public bool AdminMode
        {
            get
            {
                return bAdminMode;
            }
            set
            {
                bAdminMode = value;
            }
        }

        #endregion

        #region Constructors/ Initialisers

        public TribeSitesGrid(DataGridView oDataGridView)
        {
            m_oDataGridView = oDataGridView;
        }

        #endregion

        #region Public methods

        public void GetBrowserLinks(string sUrl)
        {
            m_oDataGridView.Visible = true;
            if (String.IsNullOrEmpty(sUrl))
            {
                m_oDataGridView.DataSource = m_oDataAccess.FindAllTribeLinks(mTribeMember.TbNm);
            }
            else
            {
                m_oDataGridView.DataSource = m_oDataAccess.FindTribeLinksAndTop20(sUrl, mTribeMember.TbNm);
            }
        }

        public void BrowserFindAndNavigate(string sSt)
        {
            if (String.IsNullOrEmpty(sSt.Trim())) return;
            m_oDataGridView.DataSource = m_oDataAccess.FindTribeLinksAndTop20(sSt.Trim(), mTribeMember.TbNm);
        }

        public bool MatchesFirstGridValue(string sSt)
        {
            if (m_oDataGridView.RowCount == 0) return false;
            if (m_oDataGridView["colSt", 0].Value == null) return false;
            return m_oDataGridView["colSt", 0].Value.ToString().Trim() == sSt.Trim();
        }

        public string FirstGridValue()
        {
            return m_oDataGridView["colUrl", 0].Value.ToString().Trim();
        }

        public string BrowserClickNavigate(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == m_oDataGridView.Columns["colSt"].Index && e.RowIndex >= 0)
            {
                if (m_oDataGridView["colUrl", m_oDataGridView.CurrentRow.Index].Value == null) return "";
                return m_oDataGridView["colUrl", m_oDataGridView.CurrentRow.Index].Value.ToString();
            }
            return "";
        }

        public void DeleteTribeLink(DataGridViewCellEventArgs e)
        {
            if (_CheckIfAnyFieldsNull(e)) return;
            if (m_oMessageBox.ShowCancel(StringProvider.sConfirmDeleteTribeSite + m_oDataGridView["colSt", e.RowIndex].Value.ToString().Trim()) == DialogResult.OK)
            {
                if (AdminMode)
                {
                    m_oDataAccess.DeleteTribeLinks((ObjectId)m_oDataGridView["colId", e.RowIndex].Value);
                }
                else
                {
                    m_oDataAccess.DeleteTribeLinks(m_oDataGridView["colSt", e.RowIndex].Value.ToString().Trim(), mTribeMember.TbNm);
                }
                RefreshGrid();
            }
        }

        public void ClickCell(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == m_oDataGridView.Columns["colSaveSite"].Index && e.RowIndex >= 0)
            {
                SaveTribeLink(e);
            }

            if (e.ColumnIndex == m_oDataGridView.Columns["colDeleteSite"].Index && e.RowIndex >= 0)
            {
                DeleteTribeLink(e);
            }
        }

        public void RefreshGrid()
        {
            if (AdminMode)
            {
                FindAllTribeLinksAdmin();
            }
            else
            {
                m_oDataGridView.DataSource = m_oDataAccess.FindAllMyTribeLinks(mTribeMember.UsrNm, mTribeMember.TbNm);
            }
        }

        public void RefreshFavGrid()
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindAllMyFavouriteLinks(mTribeMember.UsrNm, mTribeMember.TbNm);
        }

        public void SaveTribeLink(DataGridViewCellEventArgs e)
        {
            if (_CheckIfAnyFieldsNull(e) == true)
            {
                m_oMessageBox.Show(StringProvider.sTribeSiteUrlNull);
                return;
            }

            if (String.IsNullOrEmpty(m_oDataGridView["colSt", e.RowIndex].Value.ToString().Trim()))
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
                _InsertTribeLink(e);
            }
            else
            {
                _UpdateTribeLink(e);
            }
        }

        public void FindAllMyTribeLinks(string sTbNm)
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindAllMyTribeLinks(mTribeMember.UsrNm, sTbNm);
        }

        public void FindAllTribeLinksAdmin()
        {
            m_oDataGridView.DataSource = m_oDataAccess.FindAllTribeLinks();
            m_oDataGridView.Columns["colTbNm"].Visible = true;
        }

        public void ValidateUrl(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == m_oDataGridView.Columns["colUrl"].Index && e.RowIndex >= 0)
            {
                if (m_oDataGridView["colUrl", e.RowIndex].Value == null) return;
                m_oDataGridView["colUrl", e.RowIndex].Value = TribeMisc.StripHttp(m_oDataGridView["colUrl", e.RowIndex].Value.ToString());
            }
        }

        #endregion

        #region Private Helpers

        private void _UpdateTribeLink(DataGridViewCellEventArgs e)
        {
            m_oDataAccess.UpdateTribeLink((ObjectId)m_oDataGridView["colId", e.RowIndex].Value,
                    m_oDataGridView["colSt", e.RowIndex].Value.ToString().Trim(),
                    m_oDataGridView["colUrl", e.RowIndex].Value.ToString().Trim(),
                    TribeMisc.ConvertIfNull(m_oDataGridView["colDsc", e.RowIndex].Value),
                    _GetTribeName(e), mTribeMember.UsrNm);
            m_oMessageBox.Show(StringProvider.sTribeLinkSaved);
        }

        private void _InsertTribeLink(DataGridViewCellEventArgs e)
        {
            if (m_oDataAccess.TribeLinkExists(m_oDataGridView["colSt", e.RowIndex].Value.ToString(), _GetTribeName(e)))
            {
                m_oMessageBox.Show(StringProvider.sTribeLinkExists);
                return;
            }

            m_oDataAccess.InsertTribeLink(m_oDataGridView["colSt", e.RowIndex].Value.ToString().Trim(),
                   m_oDataGridView["colUrl", e.RowIndex].Value.ToString().Trim(),
                   TribeMisc.ConvertIfNull(m_oDataGridView["colDsc", e.RowIndex].Value),
                   mTribeMember.TbNm, mTribeMember.UsrNm);
            m_oMessageBox.Show(StringProvider.sTribeLinkSaved);
        }

        private bool _CheckIfAnyFieldsNull(DataGridViewCellEventArgs e)
        {
            bool bFieldsAreNull = (m_oDataGridView["colSt", e.RowIndex].Value == null);

            if (m_oDataGridView["colUrl", e.RowIndex].Value == null)
            {
                bFieldsAreNull = true;
            }

            return bFieldsAreNull;
        }

        private string _GetTribeName(DataGridViewCellEventArgs e)
        {
            string sTbNm = "";
            if (m_oDataGridView["colTbNm", e.RowIndex].Value != null)
            {
                sTbNm = m_oDataGridView["colTbNm", e.RowIndex].Value.ToString().Trim();
            }
            else
            {
                sTbNm = mTribeMember.TbNm;
            }
            return sTbNm;
        }
        #endregion
    }
}
