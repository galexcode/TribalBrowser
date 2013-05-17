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
using TribalBrowser.helpers;

namespace TribalBrowser.forms
{
    public partial class frmBrowser : Form
    {
        #region Member variables

        readonly DataAccess m_oDataAccess = new DataAccess();
        readonly frmMessageBox m_oMessageBox = new frmMessageBox();

        #endregion

        #region Constructors/ Initialisers

        public frmBrowser()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _Initialise();
        }

        #endregion

        #region Controls

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            _GetGridValues();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _FindAndNavigate();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _GetGridValues();
        }
        
        private void btnTools_Click(object sender, EventArgs e)
        {
            _ShowToolsDialog();
        }

        private void dgTribeSites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==dgTribeSites.Columns["colSt"].Index && e.RowIndex >= 0)
            {
                if (dgTribeSites["colUrl", dgTribeSites.CurrentRow.Index].Value == null) return;
                string sUrl = dgTribeSites["colUrl", dgTribeSites.CurrentRow.Index].Value.ToString();
                _NavigateToUrl(sUrl);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wbTribalBrowser.CanGoBack)
            {
                wbTribalBrowser.GoBack();
            }
            else
            {
                _GetGridValues();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (wbTribalBrowser.CanGoForward)
            {
                wbTribalBrowser.GoForward();
            }
        }

        #endregion

        #region Private Helpers

        private void _FindAndNavigate()
        {
            if (String.IsNullOrEmpty(txtUrl.Text.Trim())) return;
            dgTribeSites.DataSource= m_oDataAccess.FindTribeLinksAndTop20(txtUrl.Text.Trim(),mTribeMember.TbNm);
        }

        private void _ShowToolsDialog()
        {
            if (mTribeMember.LgIn == true)
            {
                frmTools ofrmMain = new frmTools();
                ofrmMain.ShowDialog();
            }
            else
            {
                m_oMessageBox.Show(StringProvider.sPleaseLogin);
                frmLogin ofrmLogin = new frmLogin();
                ofrmLogin.ShowDialog();
            }
        }

        private void _Initialise()
        {
            _AddTooltips();
            _ShowTribeLinks();
        }

        private void _ShowTribeLinks()
        {
            dgTribeSites.DataSource = m_oDataAccess.FindAllTribeLinks(mTribeMember.TbNm);
        }

        private void _AddTooltips()
        {
            toolTip.SetToolTip(btnBack, StringProvider.sBack);
            toolTip.SetToolTip(btnForward, StringProvider.sForward);
            toolTip.SetToolTip(btnLoad, StringProvider.sLoad);
            toolTip.SetToolTip(btnTools, StringProvider.sTools);
            toolTip.SetToolTip(txtUrl, StringProvider.sUrl);
        }
              
        private void _GetGridValues()
        {
            dgTribeSites.Visible = true;
            if (String.IsNullOrEmpty(txtUrl.Text.Trim()))
            {
                dgTribeSites.DataSource = m_oDataAccess.FindAllTribeLinks(mTribeMember.TbNm);
            }
            else
            {
                dgTribeSites.DataSource = m_oDataAccess.FindTribeLinksAndTop20(txtUrl.Text.Trim(),mTribeMember.TbNm);
            }
        }

        private void _NavigateToUrl(string sUrl)
        {
            wbTribalBrowser.Url = new Uri(TribeMisc.AddHttp(sUrl));
            dgTribeSites.Visible = false;
        }

        #endregion
    }
}
