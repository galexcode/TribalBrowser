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

namespace TribalAdmin.forms
{
    partial class frmClearTribeChat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClearTribeChat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.dgTribeChat = new System.Windows.Forms.DataGridView();
            this.Msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlTribe = new System.Windows.Forms.Panel();
            this.dgTribes = new System.Windows.Forms.DataGridView();
            this.colTrTbNm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTribeChat)).BeginInit();
            this.pnlTribe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTribes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.Controls.Add(this.dgTribeChat);
            this.pnlChat.Location = new System.Drawing.Point(-1, 178);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(812, 190);
            this.pnlChat.TabIndex = 0;
            // 
            // dgTribeChat
            // 
            this.dgTribeChat.AllowUserToAddRows = false;
            this.dgTribeChat.AllowUserToDeleteRows = false;
            this.dgTribeChat.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgTribeChat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgTribeChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTribeChat.ColumnHeadersVisible = false;
            this.dgTribeChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Msg,
            this.colID,
            this.colUsrNm,
            this.colTbNm,
            this.coldt});
            this.dgTribeChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTribeChat.Location = new System.Drawing.Point(0, 0);
            this.dgTribeChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgTribeChat.Name = "dgTribeChat";
            this.dgTribeChat.ReadOnly = true;
            this.dgTribeChat.RowHeadersVisible = false;
            this.dgTribeChat.RowTemplate.Height = 24;
            this.dgTribeChat.Size = new System.Drawing.Size(812, 190);
            this.dgTribeChat.TabIndex = 1;
            // 
            // Msg
            // 
            this.Msg.DataPropertyName = "Msg";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Msg.DefaultCellStyle = dataGridViewCellStyle1;
            this.Msg.HeaderText = "Msg";
            this.Msg.Name = "Msg";
            this.Msg.ReadOnly = true;
            this.Msg.Width = 800;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "Id";
            this.colID.HeaderText = "colID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colUsrNm
            // 
            this.colUsrNm.DataPropertyName = "UsrNm";
            this.colUsrNm.HeaderText = "colUsrNm";
            this.colUsrNm.Name = "colUsrNm";
            this.colUsrNm.ReadOnly = true;
            this.colUsrNm.Visible = false;
            // 
            // colTbNm
            // 
            this.colTbNm.DataPropertyName = "TbNm";
            this.colTbNm.HeaderText = "colTbNm";
            this.colTbNm.Name = "colTbNm";
            this.colTbNm.ReadOnly = true;
            this.colTbNm.Visible = false;
            // 
            // coldt
            // 
            this.coldt.DataPropertyName = "dt";
            this.coldt.HeaderText = "coldt";
            this.coldt.Name = "coldt";
            this.coldt.ReadOnly = true;
            this.coldt.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(2, 1);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 22);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search for a Tribe";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(553, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 42);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(2, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(545, 22);
            this.txtSearch.TabIndex = 7;
            // 
            // pnlTribe
            // 
            this.pnlTribe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTribe.Controls.Add(this.dgTribes);
            this.pnlTribe.Location = new System.Drawing.Point(2, 60);
            this.pnlTribe.Name = "pnlTribe";
            this.pnlTribe.Size = new System.Drawing.Size(806, 113);
            this.pnlTribe.TabIndex = 10;
            // 
            // dgTribes
            // 
            this.dgTribes.AllowUserToAddRows = false;
            this.dgTribes.AllowUserToDeleteRows = false;
            this.dgTribes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTribes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTribes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTribes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrTbNm,
            this.colDsc,
            this.ID,
            this.colTrUsrNm,
            this.colClear});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTribes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgTribes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTribes.EnableHeadersVisualStyles = false;
            this.dgTribes.Location = new System.Drawing.Point(0, 0);
            this.dgTribes.Name = "dgTribes";
            this.dgTribes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTribes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgTribes.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgTribes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.RowTemplate.Height = 24;
            this.dgTribes.Size = new System.Drawing.Size(806, 113);
            this.dgTribes.TabIndex = 3;
            this.dgTribes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTribes_CellContentClick);
            // 
            // colTrTbNm
            // 
            this.colTrTbNm.DataPropertyName = "TbNm";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrTbNm.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTrTbNm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTrTbNm.HeaderText = "Tribe";
            this.colTrTbNm.Name = "colTrTbNm";
            this.colTrTbNm.Width = 200;
            // 
            // colDsc
            // 
            this.colDsc.DataPropertyName = "Dsc";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colDsc.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDsc.HeaderText = "Description";
            this.colDsc.Name = "colDsc";
            this.colDsc.Width = 400;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // colTrUsrNm
            // 
            this.colTrUsrNm.DataPropertyName = "UsrNm";
            this.colTrUsrNm.HeaderText = "colUsrNm";
            this.colTrUsrNm.Name = "colTrUsrNm";
            this.colTrUsrNm.Visible = false;
            // 
            // colClear
            // 
            this.colClear.HeaderText = "";
            this.colClear.Name = "colClear";
            this.colClear.Text = "Clear";
            this.colClear.UseColumnTextForButtonValue = true;
            // 
            // frmClearTribeChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(811, 368);
            this.Controls.Add(this.pnlTribe);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClearTribeChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmClearTribeChat_Load);
            this.pnlChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTribeChat)).EndInit();
            this.pnlTribe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTribes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.DataGridView dgTribeChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldt;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlTribe;
        private System.Windows.Forms.DataGridView dgTribes;
        private System.Windows.Forms.DataGridViewButtonColumn colTrTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrUsrNm;
        private System.Windows.Forms.DataGridViewButtonColumn colClear;
    }
}