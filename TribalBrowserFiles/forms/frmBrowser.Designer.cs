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

namespace TribalBrowser.forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.txtSt = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnTools = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTribeSites = new System.Windows.Forms.Panel();
            this.dgTribeSites = new System.Windows.Forms.DataGridView();
            this.colSt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wbTribalBrowser = new System.Windows.Forms.WebBrowser();
            this.pnlTribeSites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTribeSites)).BeginInit();
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
            this.txtSt.Size = new System.Drawing.Size(583, 22);
            this.txtSt.TabIndex = 1;
            this.txtSt.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(771, 1);
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
            this.btnTools.Location = new System.Drawing.Point(836, 1);
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
            this.pnlTribeSites.Size = new System.Drawing.Size(910, 417);
            this.pnlTribeSites.TabIndex = 12;
            // 
            // dgTribeSites
            // 
            this.dgTribeSites.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTribeSites.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTribeSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSt,
            this.colDsc,
            this.colId,
            this.colUrl,
            this.colUsrNm,
            this.colTbNm});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTribeSites.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgTribeSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTribeSites.EnableHeadersVisualStyles = false;
            this.dgTribeSites.Location = new System.Drawing.Point(0, 0);
            this.dgTribeSites.Name = "dgTribeSites";
            this.dgTribeSites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTribeSites.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgTribeSites.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgTribeSites.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribeSites.RowTemplate.Height = 24;
            this.dgTribeSites.Size = new System.Drawing.Size(908, 415);
            this.dgTribeSites.TabIndex = 15;
            this.dgTribeSites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTribeSites_CellContentClick);
            // 
            // colSt
            // 
            this.colSt.DataPropertyName = "St";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.colSt.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSt.HeaderText = "Site";
            this.colSt.Name = "colSt";
            this.colSt.Width = 200;
            // 
            // colDsc
            // 
            this.colDsc.DataPropertyName = "Dsc";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.colDsc.DefaultCellStyle = dataGridViewCellStyle3;
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
            // wbTribalBrowser
            // 
            this.wbTribalBrowser.AllowWebBrowserDrop = false;
            this.wbTribalBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTribalBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbTribalBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTribalBrowser.Name = "wbTribalBrowser";
            this.wbTribalBrowser.Size = new System.Drawing.Size(908, 415);
            this.wbTribalBrowser.TabIndex = 14;
            this.wbTribalBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // frmBrowser
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(911, 496);
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
        private System.Windows.Forms.DataGridViewButtonColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.WebBrowser wbTribalBrowser;
    }
}

