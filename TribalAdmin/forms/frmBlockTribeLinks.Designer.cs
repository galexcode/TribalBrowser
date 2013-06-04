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
    partial class frmBlockTribeLinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlockTribeLinks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgBlockUrls = new System.Windows.Forms.DataGridView();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaveUrl = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeleteUrl = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBlockUrls)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(12, 8);
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
            this.btnSearch.Location = new System.Drawing.Point(548, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 52);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(12, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(530, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgBlockUrls);
            this.pnlGrid.Location = new System.Drawing.Point(12, 63);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(595, 315);
            this.pnlGrid.TabIndex = 10;
            // 
            // dgBlockUrls
            // 
            this.dgBlockUrls.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgBlockUrls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgBlockUrls.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgBlockUrls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBlockUrls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTbNm,
            this.colUrl,
            this.colSaveUrl,
            this.colDeleteUrl,
            this.colId});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBlockUrls.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgBlockUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBlockUrls.EnableHeadersVisualStyles = false;
            this.dgBlockUrls.Location = new System.Drawing.Point(0, 0);
            this.dgBlockUrls.Name = "dgBlockUrls";
            this.dgBlockUrls.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBlockUrls.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgBlockUrls.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgBlockUrls.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgBlockUrls.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgBlockUrls.RowTemplate.Height = 24;
            this.dgBlockUrls.Size = new System.Drawing.Size(595, 315);
            this.dgBlockUrls.TabIndex = 2;
            this.dgBlockUrls.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBlockUrls_CellClick);
            this.dgBlockUrls.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBlockUrls_CellEndEdit);
            // 
            // colTbNm
            // 
            this.colTbNm.DataPropertyName = "TbNm";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            this.colTbNm.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTbNm.HeaderText = "Tribe Name";
            this.colTbNm.Name = "colTbNm";
            this.colTbNm.Width = 150;
            // 
            // colUrl
            // 
            this.colUrl.DataPropertyName = "Url";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            this.colUrl.DefaultCellStyle = dataGridViewCellStyle11;
            this.colUrl.HeaderText = "Url or IP";
            this.colUrl.MaxInputLength = 100;
            this.colUrl.Name = "colUrl";
            this.colUrl.Width = 200;
            // 
            // colSaveUrl
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.colSaveUrl.DefaultCellStyle = dataGridViewCellStyle12;
            this.colSaveUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSaveUrl.HeaderText = "";
            this.colSaveUrl.Name = "colSaveUrl";
            this.colSaveUrl.Text = "Save";
            this.colSaveUrl.UseColumnTextForButtonValue = true;
            // 
            // colDeleteUrl
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.colDeleteUrl.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDeleteUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDeleteUrl.HeaderText = "";
            this.colDeleteUrl.Name = "colDeleteUrl";
            this.colDeleteUrl.Text = "Delete";
            this.colDeleteUrl.UseColumnTextForButtonValue = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "colId";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // frmBlockTribeLinks
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(617, 378);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBlockTribeLinks";
            this.Load += new System.EventHandler(this.frmBlockTribeLinks_Load);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBlockUrls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgBlockUrls;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewButtonColumn colSaveUrl;
        private System.Windows.Forms.DataGridViewButtonColumn colDeleteUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}