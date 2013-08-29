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
    partial class frmCreateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateProfile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picPfImg = new System.Windows.Forms.PictureBox();
            this.lblPfNm = new System.Windows.Forms.Label();
            this.txtPfNm = new System.Windows.Forms.TextBox();
            this.lblPfImg = new System.Windows.Forms.Label();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPfAbt = new System.Windows.Forms.TextBox();
            this.lblPfAbt = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlPfCm = new System.Windows.Forms.Panel();
            this.txtPfCmt = new System.Windows.Forms.TextBox();
            this.pnlPfCms = new System.Windows.Forms.Panel();
            this.dgPfCmts = new System.Windows.Forms.DataGridView();
            this.Msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPfCms = new System.Windows.Forms.Label();
            this.lblAddPfCm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPfImg)).BeginInit();
            this.pnlPfCm.SuspendLayout();
            this.pnlPfCms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPfCmts)).BeginInit();
            this.SuspendLayout();
            // 
            // picPfImg
            // 
            this.picPfImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPfImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPfImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picPfImg.ErrorImage")));
            this.picPfImg.Image = ((System.Drawing.Image)(resources.GetObject("picPfImg.Image")));
            this.picPfImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPfImg.InitialImage")));
            this.picPfImg.Location = new System.Drawing.Point(12, 90);
            this.picPfImg.Name = "picPfImg";
            this.picPfImg.Size = new System.Drawing.Size(200, 200);
            this.picPfImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPfImg.TabIndex = 0;
            this.picPfImg.TabStop = false;
            // 
            // lblPfNm
            // 
            this.lblPfNm.AutoSize = true;
            this.lblPfNm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfNm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPfNm.Location = new System.Drawing.Point(8, 9);
            this.lblPfNm.Name = "lblPfNm";
            this.lblPfNm.Size = new System.Drawing.Size(116, 22);
            this.lblPfNm.TabIndex = 6;
            this.lblPfNm.Text = "Profile Name";
            // 
            // txtPfNm
            // 
            this.txtPfNm.Location = new System.Drawing.Point(12, 34);
            this.txtPfNm.MaxLength = 100;
            this.txtPfNm.Name = "txtPfNm";
            this.txtPfNm.Size = new System.Drawing.Size(639, 22);
            this.txtPfNm.TabIndex = 1;
            // 
            // lblPfImg
            // 
            this.lblPfImg.AutoSize = true;
            this.lblPfImg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfImg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPfImg.Location = new System.Drawing.Point(12, 65);
            this.lblPfImg.Name = "lblPfImg";
            this.lblPfImg.Size = new System.Drawing.Size(117, 22);
            this.lblPfImg.TabIndex = 7;
            this.lblPfImg.Text = "Profile Image";
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadImg.BackgroundImage")));
            this.btnUploadImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadImg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUploadImg.Location = new System.Drawing.Point(154, 238);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(54, 50);
            this.btnUploadImg.TabIndex = 2;
            this.btnUploadImg.Tag = "Upload Image";
            this.btnUploadImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Image files| *.png;*.gif;*.jpg;*.bmp\"";
            // 
            // txtPfAbt
            // 
            this.txtPfAbt.Location = new System.Drawing.Point(220, 90);
            this.txtPfAbt.MaxLength = 100;
            this.txtPfAbt.Multiline = true;
            this.txtPfAbt.Name = "txtPfAbt";
            this.txtPfAbt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPfAbt.Size = new System.Drawing.Size(431, 129);
            this.txtPfAbt.TabIndex = 3;
            this.txtPfAbt.Text = "Enter some info about your profile...";
            // 
            // lblPfAbt
            // 
            this.lblPfAbt.AutoSize = true;
            this.lblPfAbt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfAbt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPfAbt.Location = new System.Drawing.Point(217, 65);
            this.lblPfAbt.Name = "lblPfAbt";
            this.lblPfAbt.Size = new System.Drawing.Size(58, 22);
            this.lblPfAbt.TabIndex = 9;
            this.lblPfAbt.Text = "About";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(552, 636);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 43);
            this.btnClear.TabIndex = 17;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(606, 636);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 43);
            this.btnSend.TabIndex = 16;
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // pnlPfCm
            // 
            this.pnlPfCm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPfCm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPfCm.Controls.Add(this.txtPfCmt);
            this.pnlPfCm.Location = new System.Drawing.Point(12, 683);
            this.pnlPfCm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPfCm.Name = "pnlPfCm";
            this.pnlPfCm.Size = new System.Drawing.Size(646, 71);
            this.pnlPfCm.TabIndex = 18;
            // 
            // txtPfCmt
            // 
            this.txtPfCmt.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtPfCmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPfCmt.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPfCmt.ForeColor = System.Drawing.Color.Lime;
            this.txtPfCmt.Location = new System.Drawing.Point(0, 0);
            this.txtPfCmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPfCmt.Multiline = true;
            this.txtPfCmt.Name = "txtPfCmt";
            this.txtPfCmt.Size = new System.Drawing.Size(646, 71);
            this.txtPfCmt.TabIndex = 2;
            // 
            // pnlPfCms
            // 
            this.pnlPfCms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPfCms.Controls.Add(this.dgPfCmts);
            this.pnlPfCms.Location = new System.Drawing.Point(12, 317);
            this.pnlPfCms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPfCms.Name = "pnlPfCms";
            this.pnlPfCms.Size = new System.Drawing.Size(642, 315);
            this.pnlPfCms.TabIndex = 19;
            // 
            // dgPfCmts
            // 
            this.dgPfCmts.AllowUserToAddRows = false;
            this.dgPfCmts.AllowUserToDeleteRows = false;
            this.dgPfCmts.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgPfCmts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPfCmts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPfCmts.ColumnHeadersVisible = false;
            this.dgPfCmts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Msg,
            this.colID,
            this.colUsrNm,
            this.colTbNm,
            this.coldt});
            this.dgPfCmts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPfCmts.Location = new System.Drawing.Point(0, 0);
            this.dgPfCmts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPfCmts.Name = "dgPfCmts";
            this.dgPfCmts.ReadOnly = true;
            this.dgPfCmts.RowHeadersVisible = false;
            this.dgPfCmts.RowTemplate.Height = 24;
            this.dgPfCmts.Size = new System.Drawing.Size(642, 315);
            this.dgPfCmts.TabIndex = 0;
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
            this.Msg.Width = 600;
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
            // lblPfCms
            // 
            this.lblPfCms.AutoSize = true;
            this.lblPfCms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfCms.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPfCms.Location = new System.Drawing.Point(12, 293);
            this.lblPfCms.Name = "lblPfCms";
            this.lblPfCms.Size = new System.Drawing.Size(183, 22);
            this.lblPfCms.TabIndex = 20;
            this.lblPfCms.Text = "All Profile Comments";
            // 
            // lblAddPfCm
            // 
            this.lblAddPfCm.AutoSize = true;
            this.lblAddPfCm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPfCm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddPfCm.Location = new System.Drawing.Point(12, 657);
            this.lblAddPfCm.Name = "lblAddPfCm";
            this.lblAddPfCm.Size = new System.Drawing.Size(191, 22);
            this.lblAddPfCm.TabIndex = 21;
            this.lblAddPfCm.Text = "Add Profile Comments";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(592, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 59);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(666, 765);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddPfCm);
            this.Controls.Add(this.lblPfCms);
            this.Controls.Add(this.pnlPfCms);
            this.Controls.Add(this.pnlPfCm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblPfAbt);
            this.Controls.Add(this.txtPfAbt);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.lblPfImg);
            this.Controls.Add(this.lblPfNm);
            this.Controls.Add(this.txtPfNm);
            this.Controls.Add(this.picPfImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCreateProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPfImg)).EndInit();
            this.pnlPfCm.ResumeLayout(false);
            this.pnlPfCm.PerformLayout();
            this.pnlPfCms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPfCmts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPfImg;
        private System.Windows.Forms.Label lblPfNm;
        private System.Windows.Forms.TextBox txtPfNm;
        private System.Windows.Forms.Label lblPfImg;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtPfAbt;
        private System.Windows.Forms.Label lblPfAbt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlPfCm;
        private System.Windows.Forms.Panel pnlPfCms;
        private System.Windows.Forms.DataGridView dgPfCmts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldt;
        private System.Windows.Forms.Label lblPfCms;
        private System.Windows.Forms.TextBox txtPfCmt;
        private System.Windows.Forms.Label lblAddPfCm;
        private System.Windows.Forms.Button btnSave;
    }
}