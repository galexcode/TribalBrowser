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
    partial class frmDetailsSites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailsSites));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUsrNm = new System.Windows.Forms.Label();
            this.txtUsrNm = new System.Windows.Forms.TextBox();
            this.lblPss = new System.Windows.Forms.Label();
            this.txtPss = new System.Windows.Forms.TextBox();
            this.lblConfirmPss = new System.Windows.Forms.Label();
            this.txtConfirmPss = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMyTribes = new System.Windows.Forms.Label();
            this.pnlTribes = new System.Windows.Forms.Panel();
            this.dgMyTribes = new System.Windows.Forms.DataGridView();
            this.colTrTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaveTribe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlMySites = new System.Windows.Forms.Panel();
            this.dgMySites = new System.Windows.Forms.DataGridView();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaveSite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeleteSite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMySites = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblMl = new System.Windows.Forms.Label();
            this.txtMl = new System.Windows.Forms.TextBox();
            this.pnlTribes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyTribes)).BeginInit();
            this.pnlMySites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMySites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsrNm
            // 
            this.lblUsrNm.AutoSize = true;
            this.lblUsrNm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrNm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsrNm.Location = new System.Drawing.Point(8, 6);
            this.lblUsrNm.Name = "lblUsrNm";
            this.lblUsrNm.Size = new System.Drawing.Size(56, 22);
            this.lblUsrNm.TabIndex = 6;
            this.lblUsrNm.Text = "Name";
            // 
            // txtUsrNm
            // 
            this.txtUsrNm.Enabled = false;
            this.txtUsrNm.Location = new System.Drawing.Point(12, 31);
            this.txtUsrNm.MaxLength = 100;
            this.txtUsrNm.Name = "txtUsrNm";
            this.txtUsrNm.ReadOnly = true;
            this.txtUsrNm.Size = new System.Drawing.Size(342, 22);
            this.txtUsrNm.TabIndex = 1;
            // 
            // lblPss
            // 
            this.lblPss.AutoSize = true;
            this.lblPss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPss.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPss.Location = new System.Drawing.Point(8, 56);
            this.lblPss.Name = "lblPss";
            this.lblPss.Size = new System.Drawing.Size(88, 22);
            this.lblPss.TabIndex = 8;
            this.lblPss.Text = "Password";
            // 
            // txtPss
            // 
            this.txtPss.Location = new System.Drawing.Point(12, 81);
            this.txtPss.MaxLength = 100;
            this.txtPss.Name = "txtPss";
            this.txtPss.Size = new System.Drawing.Size(342, 22);
            this.txtPss.TabIndex = 2;
            this.txtPss.UseSystemPasswordChar = true;
            // 
            // lblConfirmPss
            // 
            this.lblConfirmPss.AutoSize = true;
            this.lblConfirmPss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPss.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmPss.Location = new System.Drawing.Point(8, 110);
            this.lblConfirmPss.Name = "lblConfirmPss";
            this.lblConfirmPss.Size = new System.Drawing.Size(158, 22);
            this.lblConfirmPss.TabIndex = 10;
            this.lblConfirmPss.Text = "Confirm Password";
            // 
            // txtConfirmPss
            // 
            this.txtConfirmPss.Location = new System.Drawing.Point(12, 135);
            this.txtConfirmPss.MaxLength = 100;
            this.txtConfirmPss.Name = "txtConfirmPss";
            this.txtConfirmPss.Size = new System.Drawing.Size(342, 22);
            this.txtConfirmPss.TabIndex = 3;
            this.txtConfirmPss.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(360, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 59);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMyTribes
            // 
            this.lblMyTribes.AutoSize = true;
            this.lblMyTribes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyTribes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMyTribes.Location = new System.Drawing.Point(12, 215);
            this.lblMyTribes.Name = "lblMyTribes";
            this.lblMyTribes.Size = new System.Drawing.Size(218, 22);
            this.lblMyTribes.TabIndex = 12;
            this.lblMyTribes.Text = "List of Tribes I\'ve Created";
            // 
            // pnlTribes
            // 
            this.pnlTribes.Controls.Add(this.dgMyTribes);
            this.pnlTribes.Location = new System.Drawing.Point(12, 240);
            this.pnlTribes.Name = "pnlTribes";
            this.pnlTribes.Size = new System.Drawing.Size(1024, 128);
            this.pnlTribes.TabIndex = 13;
            // 
            // dgMyTribes
            // 
            this.dgMyTribes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMyTribes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyTribes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrTbNm,
            this.colTrDsc,
            this.ID,
            this.colTrUsrNm,
            this.colSaveTribe});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMyTribes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgMyTribes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMyTribes.EnableHeadersVisualStyles = false;
            this.dgMyTribes.Location = new System.Drawing.Point(0, 0);
            this.dgMyTribes.Name = "dgMyTribes";
            this.dgMyTribes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMyTribes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMyTribes.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgMyTribes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.RowTemplate.Height = 24;
            this.dgMyTribes.Size = new System.Drawing.Size(1024, 128);
            this.dgMyTribes.TabIndex = 5;
            this.dgMyTribes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMyTribes_CellContentClick);
            // 
            // colTrTbNm
            // 
            this.colTrTbNm.DataPropertyName = "TbNm";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.colTrTbNm.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTrTbNm.HeaderText = "Tribe";
            this.colTrTbNm.MaxInputLength = 100;
            this.colTrTbNm.Name = "colTrTbNm";
            this.colTrTbNm.ReadOnly = true;
            this.colTrTbNm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrTbNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTrTbNm.Width = 200;
            // 
            // colTrDsc
            // 
            this.colTrDsc.DataPropertyName = "Dsc";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.colTrDsc.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTrDsc.HeaderText = "Description";
            this.colTrDsc.MaxInputLength = 300;
            this.colTrDsc.Name = "colTrDsc";
            this.colTrDsc.Width = 700;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // colTrUsrNm
            // 
            this.colTrUsrNm.DataPropertyName = "UsrNm";
            this.colTrUsrNm.HeaderText = "colTrUsrNm";
            this.colTrUsrNm.Name = "colTrUsrNm";
            this.colTrUsrNm.Visible = false;
            // 
            // colSaveTribe
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.colSaveTribe.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSaveTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSaveTribe.HeaderText = "";
            this.colSaveTribe.Name = "colSaveTribe";
            this.colSaveTribe.Text = "Save";
            this.colSaveTribe.UseColumnTextForButtonValue = true;
            // 
            // pnlMySites
            // 
            this.pnlMySites.Controls.Add(this.dgMySites);
            this.pnlMySites.Location = new System.Drawing.Point(12, 396);
            this.pnlMySites.Name = "pnlMySites";
            this.pnlMySites.Size = new System.Drawing.Size(1024, 155);
            this.pnlMySites.TabIndex = 14;
            // 
            // dgMySites
            // 
            this.dgMySites.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgMySites.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMySites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSt,
            this.colUrl,
            this.colDsc,
            this.colSaveSite,
            this.colDeleteSite,
            this.colId,
            this.colUsrNm,
            this.colTbNm});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMySites.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgMySites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMySites.EnableHeadersVisualStyles = false;
            this.dgMySites.Location = new System.Drawing.Point(0, 0);
            this.dgMySites.Name = "dgMySites";
            this.dgMySites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMySites.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgMySites.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgMySites.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.RowTemplate.Height = 24;
            this.dgMySites.Size = new System.Drawing.Size(1024, 155);
            this.dgMySites.TabIndex = 2;
            this.dgMySites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMySites_CellContentClick);
            this.dgMySites.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMySites_CellEndEdit);
            // 
            // colSt
            // 
            this.colSt.DataPropertyName = "St";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            this.colSt.DefaultCellStyle = dataGridViewCellStyle9;
            this.colSt.HeaderText = "Site Name";
            this.colSt.MaxInputLength = 100;
            this.colSt.Name = "colSt";
            this.colSt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSt.Width = 200;
            // 
            // colUrl
            // 
            this.colUrl.DataPropertyName = "Url";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            this.colUrl.DefaultCellStyle = dataGridViewCellStyle10;
            this.colUrl.HeaderText = "Url or IP";
            this.colUrl.MaxInputLength = 100;
            this.colUrl.Name = "colUrl";
            this.colUrl.Width = 200;
            // 
            // colDsc
            // 
            this.colDsc.DataPropertyName = "Dsc";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colDsc.DefaultCellStyle = dataGridViewCellStyle11;
            this.colDsc.HeaderText = "Description";
            this.colDsc.MaxInputLength = 300;
            this.colDsc.Name = "colDsc";
            this.colDsc.Width = 400;
            // 
            // colSaveSite
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.colSaveSite.DefaultCellStyle = dataGridViewCellStyle12;
            this.colSaveSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSaveSite.HeaderText = "";
            this.colSaveSite.Name = "colSaveSite";
            this.colSaveSite.Text = "Save";
            this.colSaveSite.UseColumnTextForButtonValue = true;
            // 
            // colDeleteSite
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.colDeleteSite.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDeleteSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDeleteSite.HeaderText = "";
            this.colDeleteSite.Name = "colDeleteSite";
            this.colDeleteSite.Text = "Delete";
            this.colDeleteSite.UseColumnTextForButtonValue = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "colId";
            this.colId.Name = "colId";
            this.colId.Visible = false;
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
            // lblMySites
            // 
            this.lblMySites.AutoSize = true;
            this.lblMySites.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySites.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMySites.Location = new System.Drawing.Point(12, 371);
            this.lblMySites.Name = "lblMySites";
            this.lblMySites.Size = new System.Drawing.Size(312, 22);
            this.lblMySites.TabIndex = 15;
            this.lblMySites.Text = "My Sites/Links to share with my Tribe";
            // 
            // lblMl
            // 
            this.lblMl.AutoSize = true;
            this.lblMl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMl.Location = new System.Drawing.Point(8, 160);
            this.lblMl.Name = "lblMl";
            this.lblMl.Size = new System.Drawing.Size(297, 22);
            this.lblMl.TabIndex = 21;
            this.lblMl.Text = "Email (in case you forget password)";
            // 
            // txtMl
            // 
            this.txtMl.Location = new System.Drawing.Point(12, 185);
            this.txtMl.MaxLength = 100;
            this.txtMl.Name = "txtMl";
            this.txtMl.Size = new System.Drawing.Size(342, 22);
            this.txtMl.TabIndex = 20;
            // 
            // frmDetailsSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1048, 582);
            this.Controls.Add(this.lblMl);
            this.Controls.Add(this.txtMl);
            this.Controls.Add(this.lblMySites);
            this.Controls.Add(this.pnlMySites);
            this.Controls.Add(this.pnlTribes);
            this.Controls.Add(this.lblMyTribes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblConfirmPss);
            this.Controls.Add(this.txtConfirmPss);
            this.Controls.Add(this.lblPss);
            this.Controls.Add(this.txtPss);
            this.Controls.Add(this.lblUsrNm);
            this.Controls.Add(this.txtUsrNm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetailsSites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDetailsSites_Load);
            this.pnlTribes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyTribes)).EndInit();
            this.pnlMySites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMySites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsrNm;
        private System.Windows.Forms.TextBox txtUsrNm;
        private System.Windows.Forms.Label lblPss;
        private System.Windows.Forms.TextBox txtPss;
        private System.Windows.Forms.Label lblConfirmPss;
        private System.Windows.Forms.TextBox txtConfirmPss;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMyTribes;
        private System.Windows.Forms.Panel pnlTribes;
        private System.Windows.Forms.Panel pnlMySites;
        private System.Windows.Forms.Label lblMySites;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dgMyTribes;
        private System.Windows.Forms.DataGridView dgMySites;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDsc;
        private System.Windows.Forms.DataGridViewButtonColumn colSaveSite;
        private System.Windows.Forms.DataGridViewButtonColumn colDeleteSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrUsrNm;
        private System.Windows.Forms.DataGridViewButtonColumn colSaveTribe;
        private System.Windows.Forms.Label lblMl;
        private System.Windows.Forms.TextBox txtMl;
    }
}