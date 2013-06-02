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
    partial class frmJoinTribe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJoinTribe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnJoin = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dgTribes = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colTbNm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTribes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJoin
            // 
            this.btnJoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJoin.BackgroundImage")));
            this.btnJoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJoin.Location = new System.Drawing.Point(228, 425);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(165, 155);
            this.btnJoin.TabIndex = 4;
            this.btnJoin.Text = "Join Tribe";
            this.btnJoin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(12, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(530, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(548, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 52);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 22);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search for a Tribe";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.dgTribes);
            this.panel.Location = new System.Drawing.Point(12, 79);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(614, 340);
            this.panel.TabIndex = 7;
            // 
            // dgTribes
            // 
            this.dgTribes.AllowUserToAddRows = false;
            this.dgTribes.AllowUserToDeleteRows = false;
            this.dgTribes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTribes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTribes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTribes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTbNm,
            this.colDsc,
            this.ID,
            this.colUsrNm,
            this.colDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTribes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgTribes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTribes.EnableHeadersVisualStyles = false;
            this.dgTribes.Location = new System.Drawing.Point(0, 0);
            this.dgTribes.Name = "dgTribes";
            this.dgTribes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTribes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgTribes.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgTribes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgTribes.RowTemplate.Height = 24;
            this.dgTribes.Size = new System.Drawing.Size(614, 340);
            this.dgTribes.TabIndex = 3;
            // 
            // colTbNm
            // 
            this.colTbNm.DataPropertyName = "TbNm";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTbNm.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTbNm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTbNm.HeaderText = "Tribe";
            this.colTbNm.Name = "colTbNm";
            this.colTbNm.Width = 200;
            // 
            // colDsc
            // 
            this.colDsc.DataPropertyName = "Dsc";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colDsc.DefaultCellStyle = dataGridViewCellStyle3;
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
            // colUsrNm
            // 
            this.colUsrNm.DataPropertyName = "UsrNm";
            this.colUsrNm.HeaderText = "colUsrNm";
            this.colUsrNm.Name = "colUsrNm";
            this.colUsrNm.Visible = false;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Visible = false;
            // 
            // frmJoinTribe
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(638, 583);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnJoin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJoinTribe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmJoinTribe_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTribes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgTribes;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewButtonColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}