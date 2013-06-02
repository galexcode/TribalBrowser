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
    partial class frmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.pnlTribeChat = new System.Windows.Forms.Panel();
            this.dgTribeChat = new System.Windows.Forms.DataGridView();
            this.Msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsrNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTbNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTribeChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTribeChat)).BeginInit();
            this.pnlChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTribeChat
            // 
            this.pnlTribeChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTribeChat.Controls.Add(this.dgTribeChat);
            this.pnlTribeChat.Location = new System.Drawing.Point(2, 2);
            this.pnlTribeChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTribeChat.Name = "pnlTribeChat";
            this.pnlTribeChat.Size = new System.Drawing.Size(606, 284);
            this.pnlTribeChat.TabIndex = 0;
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
            this.dgTribeChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgTribeChat.Name = "dgTribeChat";
            this.dgTribeChat.ReadOnly = true;
            this.dgTribeChat.RowHeadersVisible = false;
            this.dgTribeChat.RowTemplate.Height = 24;
            this.dgTribeChat.Size = new System.Drawing.Size(606, 284);
            this.dgTribeChat.TabIndex = 0;
            this.dgTribeChat.SizeChanged += new System.EventHandler(this.dgTribeChat_SizeChanged);
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
            // pnlChat
            // 
            this.pnlChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChat.Controls.Add(this.txtChat);
            this.pnlChat.Location = new System.Drawing.Point(2, 323);
            this.pnlChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(606, 89);
            this.pnlChat.TabIndex = 1;
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChat.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.ForeColor = System.Drawing.Color.Lime;
            this.txtChat.Location = new System.Drawing.Point(0, 0);
            this.txtChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(606, 89);
            this.txtChat.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(572, 287);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(36, 35);
            this.btnSend.TabIndex = 14;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(536, 287);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(610, 411);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlTribeChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tribe Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChat_FormClosed);
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.pnlTribeChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTribeChat)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTribeChat;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgTribeChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsrNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTbNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldt;
    }
}