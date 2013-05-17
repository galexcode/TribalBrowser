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

namespace TribalBrowser.forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMyTribes = new System.Windows.Forms.Label();
            this.pnlTribes = new System.Windows.Forms.Panel();
            this.pnlMySites = new System.Windows.Forms.Panel();
            this.lblMySites = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colSaveTribe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMyTribes = new System.Windows.Forms.DataGridView();
            this.dgMySites = new System.Windows.Forms.DataGridView();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaveSite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeleteSite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTribes.SuspendLayout();
            this.pnlMySites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyTribes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMySites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Location = new System.Drawing.Point(8, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 22);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 31);
            this.txtUserName.MaxLength = 100;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(342, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(8, 56);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(88, 22);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 81);
            this.txtPass.MaxLength = 100;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(342, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmPass.Location = new System.Drawing.Point(8, 110);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(158, 22);
            this.lblConfirmPass.TabIndex = 10;
            this.lblConfirmPass.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(12, 135);
            this.txtConfirmPass.MaxLength = 100;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(342, 22);
            this.txtConfirmPass.TabIndex = 3;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(360, 110);
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
            this.lblMyTribes.Location = new System.Drawing.Point(12, 170);
            this.lblMyTribes.Name = "lblMyTribes";
            this.lblMyTribes.Size = new System.Drawing.Size(218, 22);
            this.lblMyTribes.TabIndex = 12;
            this.lblMyTribes.Text = "List of Tribes I\'ve Created";
            // 
            // pnlTribes
            // 
            this.pnlTribes.Controls.Add(this.dgMyTribes);
            this.pnlTribes.Location = new System.Drawing.Point(12, 195);
            this.pnlTribes.Name = "pnlTribes";
            this.pnlTribes.Size = new System.Drawing.Size(1024, 128);
            this.pnlTribes.TabIndex = 13;
            // 
            // pnlMySites
            // 
            this.pnlMySites.Controls.Add(this.dgMySites);
            this.pnlMySites.Location = new System.Drawing.Point(12, 351);
            this.pnlMySites.Name = "pnlMySites";
            this.pnlMySites.Size = new System.Drawing.Size(1024, 155);
            this.pnlMySites.TabIndex = 14;
            // 
            // lblMySites
            // 
            this.lblMySites.AutoSize = true;
            this.lblMySites.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySites.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMySites.Location = new System.Drawing.Point(12, 326);
            this.lblMySites.Name = "lblMySites";
            this.lblMySites.Size = new System.Drawing.Size(312, 22);
            this.lblMySites.TabIndex = 15;
            this.lblMySites.Text = "My Sites/Links to share with my Tribe";
            // 
            // colSaveTribe
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.colSaveTribe.DefaultCellStyle = dataGridViewCellStyle17;
            this.colSaveTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSaveTribe.HeaderText = "";
            this.colSaveTribe.Name = "colSaveTribe";
            this.colSaveTribe.Text = "Save";
            this.colSaveTribe.UseColumnTextForButtonValue = true;
            // 
            // colDsc
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            this.colDsc.DefaultCellStyle = dataGridViewCellStyle18;
            this.colDsc.HeaderText = "Description";
            this.colDsc.MaxInputLength = 300;
            this.colDsc.Name = "colDsc";
            this.colDsc.Width = 700;
            // 
            // colTbNm
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver;
            this.colTbNm.DefaultCellStyle = dataGridViewCellStyle19;
            this.colTbNm.HeaderText = "Tribe";
            this.colTbNm.MaxInputLength = 100;
            this.colTbNm.Name = "colTbNm";
            this.colTbNm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTbNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTbNm.Width = 200;
            // 
            // dgMyTribes
            // 
            this.dgMyTribes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgMyTribes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyTribes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTbNm,
            this.colDsc,
            this.colSaveTribe});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMyTribes.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgMyTribes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMyTribes.EnableHeadersVisualStyles = false;
            this.dgMyTribes.Location = new System.Drawing.Point(0, 0);
            this.dgMyTribes.Name = "dgMyTribes";
            this.dgMyTribes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMyTribes.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgMyTribes.RowHeadersVisible = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgMyTribes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMyTribes.RowTemplate.Height = 24;
            this.dgMyTribes.Size = new System.Drawing.Size(1024, 128);
            this.dgMyTribes.TabIndex = 5;
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
            this.dataGridViewTextBoxColumn1,
            this.colSaveSite,
            this.colDeleteSite,
            this.colId,
            this.colUsrNm,
            this.dataGridViewTextBoxColumn2});
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dsc";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 300;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TbNm";
            this.dataGridViewTextBoxColumn2.HeaderText = "colTbNm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // frmDetailsSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1048, 528);
            this.Controls.Add(this.lblMySites);
            this.Controls.Add(this.pnlMySites);
            this.Controls.Add(this.pnlTribes);
            this.Controls.Add(this.lblMyTribes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetailsSites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDetailsSites_Load);
            this.pnlTribes.ResumeLayout(false);
            this.pnlMySites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyTribes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMySites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMyTribes;
        private System.Windows.Forms.Panel pnlTribes;
        private System.Windows.Forms.Panel pnlMySites;
        private System.Windows.Forms.Label lblMySites;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dgMyTribes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDsc;
        private System.Windows.Forms.DataGridViewButtonColumn colSaveTribe;
        private System.Windows.Forms.DataGridView dgMySites;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn colSaveSite;
        private System.Windows.Forms.DataGridViewButtonColumn colDeleteSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}