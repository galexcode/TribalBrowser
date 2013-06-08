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
    partial class frmInsertTribeLinks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertTribeLinks));
            this.lblMySites = new System.Windows.Forms.Label();
            this.pnlMySites = new System.Windows.Forms.Panel();
            this.dgMySites = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaveSite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeleteSite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMySites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMySites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMySites
            // 
            this.lblMySites.AutoSize = true;
            this.lblMySites.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySites.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMySites.Location = new System.Drawing.Point(8, 9);
            this.lblMySites.Name = "lblMySites";
            this.lblMySites.Size = new System.Drawing.Size(312, 22);
            this.lblMySites.TabIndex = 17;
            this.lblMySites.Text = "My Sites/Links to share with my Tribe";
            // 
            // pnlMySites
            // 
            this.pnlMySites.Controls.Add(this.dgMySites);
            this.pnlMySites.Location = new System.Drawing.Point(12, 34);
            this.pnlMySites.Name = "pnlMySites";
            this.pnlMySites.Size = new System.Drawing.Size(1024, 296);
            this.pnlMySites.TabIndex = 16;
            // 
            // dgMySites
            // 
            this.dgMySites.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMySites.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMySites.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMySites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSt,
            this.colUrl,
            this.colDsc,
            this.colTbNm,
            this.colSaveSite,
            this.colDeleteSite,
            this.colId,
            this.colUsrNm,
            this.colFav});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMySites.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgMySites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMySites.EnableHeadersVisualStyles = false;
            this.dgMySites.Location = new System.Drawing.Point(0, 0);
            this.dgMySites.Name = "dgMySites";
            this.dgMySites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMySites.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgMySites.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgMySites.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMySites.RowTemplate.Height = 24;
            this.dgMySites.Size = new System.Drawing.Size(1024, 296);
            this.dgMySites.TabIndex = 1;
            this.dgMySites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMySites_CellContentClick);
            this.dgMySites.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMySites_CellEndEdit);
            // 
            // colSt
            // 
            this.colSt.DataPropertyName = "St";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSt.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.colUrl.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUrl.HeaderText = "Url or IP";
            this.colUrl.MaxInputLength = 100;
            this.colUrl.Name = "colUrl";
            this.colUrl.Width = 200;
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
            this.colDsc.MaxInputLength = 300;
            this.colDsc.Name = "colDsc";
            this.colDsc.Width = 400;
            // 
            // colTbNm
            // 
            this.colTbNm.DataPropertyName = "TbNm";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            this.colTbNm.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTbNm.HeaderText = "Tribe Name";
            this.colTbNm.Name = "colTbNm";
            this.colTbNm.Visible = false;
            // 
            // colSaveSite
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.colSaveSite.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSaveSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSaveSite.HeaderText = "";
            this.colSaveSite.Name = "colSaveSite";
            this.colSaveSite.Text = "Save";
            this.colSaveSite.UseColumnTextForButtonValue = true;
            // 
            // colDeleteSite
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.colDeleteSite.DefaultCellStyle = dataGridViewCellStyle7;
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
            // colFav
            // 
            this.colFav.DataPropertyName = "Fav";
            this.colFav.HeaderText = "colFav";
            this.colFav.Name = "colFav";
            this.colFav.Visible = false;
            // 
            // frmInsertTribeLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1048, 338);
            this.Controls.Add(this.lblMySites);
            this.Controls.Add(this.pnlMySites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsertTribeLinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInsertTribeLinks_Load);
            this.pnlMySites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMySites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMySites;
        private System.Windows.Forms.Panel pnlMySites;
        private System.Windows.Forms.DataGridView dgMySites;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewButtonColumn colSaveSite;
        private System.Windows.Forms.DataGridViewButtonColumn colDeleteSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFav;
    }
}