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

namespace TribalBrowser.Forms
{
    partial class frmBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.txtSt = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnTools = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTribeSites = new System.Windows.Forms.Panel();
            this.dgTribeSites = new System.Windows.Forms.DataGridView();
            this.wbTribalBrowser = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChat = new System.Windows.Forms.Button();
            this.colSt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTribeSites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTribeSites)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(0, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 52);
            this.btnBack.TabIndex = 3;
            this.btnBack.Tag = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForward.BackgroundImage")));
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForward.Location = new System.Drawing.Point(58, 1);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(59, 52);
            this.btnForward.TabIndex = 4;
            this.btnForward.Tag = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtSt
            // 
            this.txtSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSt.Location = new System.Drawing.Point(182, 16);
            this.txtSt.Name = "txtSt";
            this.txtSt.Size = new System.Drawing.Size(444, 22);
            this.txtSt.TabIndex = 1;
            this.txtSt.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(632, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(59, 52);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            // 
            // btnTools
            // 
            this.btnTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTools.BackgroundImage")));
            this.btnTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTools.Location = new System.Drawing.Point(749, 2);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(59, 52);
            this.btnTools.TabIndex = 7;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(117, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(59, 52);
            this.btnHome.TabIndex = 9;
            this.btnHome.Tag = "Forward";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTribeSites
            // 
            this.pnlTribeSites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTribeSites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTribeSites.Controls.Add(this.dgTribeSites);
            this.pnlTribeSites.Controls.Add(this.wbTribalBrowser);
            this.pnlTribeSites.Location = new System.Drawing.Point(0, 59);
            this.pnlTribeSites.Name = "pnlTribeSites";
            this.pnlTribeSites.Size = new System.Drawing.Size(809, 417);
            this.pnlTribeSites.TabIndex = 12;
            // 
            // dgTribeSites
            // 
            this.dgTribeSites.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgTribeSites.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTribeSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSt,
            this.colDsc,
            this.colId,
            this.colUrl,
            this.colUsrNm,
            this.colTbNm,
            this.colFav});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTribeSites.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgTribeSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTribeSites.EnableHeadersVisualStyles = false;
            this.dgTribeSites.Location = new System.Drawing.Point(0, 0);
            this.dgTribeSites.Name = "dgTribeSites";
            this.dgTribeSites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTribeSites.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgTribeSites.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgTribeSites.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.RowTemplate.Height = 24;
            this.dgTribeSites.Size = new System.Drawing.Size(807, 415);
            this.dgTribeSites.TabIndex = 15;
            this.dgTribeSites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTribeSites_CellContentClick);
            // 
            // wbTribalBrowser
            // 
            this.wbTribalBrowser.AllowWebBrowserDrop = false;
            this.wbTribalBrowser.ContextMenuStrip = this.contextMenuStrip;
            this.wbTribalBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTribalBrowser.IsWebBrowserContextMenuEnabled = false;
            this.wbTribalBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbTribalBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTribalBrowser.Name = "wbTribalBrowser";
            this.wbTribalBrowser.Size = new System.Drawing.Size(807, 415);
            this.wbTribalBrowser.TabIndex = 14;
            this.wbTribalBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.wbTribalBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.wbTribalBrowser_NewWindow);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemAdd,
            this.menuItemView});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(219, 76);
            // 
            // menuItemNew
            // 
            this.menuItemNew.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("menuItemNew.Image")));
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(218, 24);
            this.menuItemNew.Text = "Open in new window";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("menuItemAdd.Image")));
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(218, 24);
            this.menuItemAdd.Text = "Add to favourites";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuItemView.Image = ((System.Drawing.Image)(resources.GetObject("menuItemView.Image")));
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(218, 24);
            this.menuItemView.Text = "Show Favourites";
            this.menuItemView.Click += new System.EventHandler(this.menuItemView_Click);
            // 
            // btnChat
            // 
            this.btnChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChat.BackgroundImage")));
            this.btnChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChat.Location = new System.Drawing.Point(690, 2);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(59, 52);
            this.btnChat.TabIndex = 13;
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // colSt
            // 
            this.colSt.DataPropertyName = "St";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            this.colSt.DefaultCellStyle = dataGridViewCellStyle8;
            this.colSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSt.HeaderText = "Site";
            this.colSt.Name = "colSt";
            this.colSt.Width = 200;
            // 
            // colDsc
            // 
            this.colDsc.DataPropertyName = "Dsc";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            this.colDsc.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDsc.HeaderText = "Description";
            this.colDsc.Name = "colDsc";
            this.colDsc.Width = 600;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colUrl
            // 
            this.colUrl.DataPropertyName = "Url";
            this.colUrl.HeaderText = "colUrl";
            this.colUrl.Name = "colUrl";
            this.colUrl.Visible = false;
            // 
            // colUsrNm
            // 
            this.colUsrNm.DataPropertyName = "UsrNm";
            this.colUsrNm.HeaderText = "colUsrNm";
            this.colUsrNm.Name = "colUsrNm";
            this.colUsrNm.Visible = false;
            // 
            // colTbNm
            // 
            this.colTbNm.DataPropertyName = "TbNm";
            this.colTbNm.HeaderText = "colTbNm";
            this.colTbNm.Name = "colTbNm";
            this.colTbNm.Visible = false;
            // 
            // colFav
            // 
            this.colFav.DataPropertyName = "Fav";
            this.colFav.HeaderText = "colFav";
            this.colFav.Name = "colFav";
            this.colFav.Visible = false;
            // 
            // frmBrowser
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(810, 496);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.pnlTribeSites);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSt);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Refresh";
            this.Text = "FD Tribal Browser Lite";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTribeSites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTribeSites)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox txtSt;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTribeSites;
        private System.Windows.Forms.DataGridView dgTribeSites;
        private System.Windows.Forms.WebBrowser wbTribalBrowser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.DataGridViewButtonColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav;
    }
}

