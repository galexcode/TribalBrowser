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
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnDelTb = new System.Windows.Forms.Button();
            this.btnDelTbSt = new System.Windows.Forms.Button();
            this.btnBlockTbSt = new System.Windows.Forms.Button();
            this.btnClearTbChat = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDelTbUsr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelTb
            // 
            this.btnDelTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelTb.BackgroundImage")));
            this.btnDelTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelTb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelTb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTb.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelTb.Location = new System.Drawing.Point(0, 2);
            this.btnDelTb.Name = "btnDelTb";
            this.btnDelTb.Size = new System.Drawing.Size(200, 200);
            this.btnDelTb.TabIndex = 2;
            this.btnDelTb.Text = "Delete Tribe";
            this.btnDelTb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelTb.UseVisualStyleBackColor = true;
            this.btnDelTb.Click += new System.EventHandler(this.btnDelTb_Click);
            // 
            // btnDelTbSt
            // 
            this.btnDelTbSt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelTbSt.BackgroundImage")));
            this.btnDelTbSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelTbSt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelTbSt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTbSt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelTbSt.Location = new System.Drawing.Point(195, 2);
            this.btnDelTbSt.Name = "btnDelTbSt";
            this.btnDelTbSt.Size = new System.Drawing.Size(200, 200);
            this.btnDelTbSt.TabIndex = 3;
            this.btnDelTbSt.Text = "Delete Tribe Links";
            this.btnDelTbSt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelTbSt.UseVisualStyleBackColor = true;
            this.btnDelTbSt.Click += new System.EventHandler(this.btnDelTbSt_Click);
            // 
            // btnBlockTbSt
            // 
            this.btnBlockTbSt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlockTbSt.BackgroundImage")));
            this.btnBlockTbSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlockTbSt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlockTbSt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockTbSt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBlockTbSt.Location = new System.Drawing.Point(0, 202);
            this.btnBlockTbSt.Name = "btnBlockTbSt";
            this.btnBlockTbSt.Size = new System.Drawing.Size(200, 200);
            this.btnBlockTbSt.TabIndex = 4;
            this.btnBlockTbSt.Text = "Block Tribe Links";
            this.btnBlockTbSt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBlockTbSt.UseVisualStyleBackColor = true;
            this.btnBlockTbSt.Click += new System.EventHandler(this.btnBlockTbSt_Click);
            // 
            // btnClearTbChat
            // 
            this.btnClearTbChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearTbChat.BackgroundImage")));
            this.btnClearTbChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearTbChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearTbChat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTbChat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearTbChat.Location = new System.Drawing.Point(195, 202);
            this.btnClearTbChat.Name = "btnClearTbChat";
            this.btnClearTbChat.Size = new System.Drawing.Size(200, 200);
            this.btnClearTbChat.TabIndex = 5;
            this.btnClearTbChat.Text = "Clear Tribe Chat";
            this.btnClearTbChat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearTbChat.UseVisualStyleBackColor = true;
            this.btnClearTbChat.Click += new System.EventHandler(this.btnClearTbChat_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.Location = new System.Drawing.Point(395, 202);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(200, 200);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDelTbUsr
            // 
            this.btnDelTbUsr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelTbUsr.BackgroundImage")));
            this.btnDelTbUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelTbUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelTbUsr.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTbUsr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelTbUsr.Location = new System.Drawing.Point(395, 2);
            this.btnDelTbUsr.Name = "btnDelTbUsr";
            this.btnDelTbUsr.Size = new System.Drawing.Size(200, 200);
            this.btnDelTbUsr.TabIndex = 7;
            this.btnDelTbUsr.Text = "Delete Tribe Member";
            this.btnDelTbUsr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelTbUsr.UseVisualStyleBackColor = true;
            this.btnDelTbUsr.Click += new System.EventHandler(this.btnDelTbUsr_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(597, 405);
            this.Controls.Add(this.btnDelTbUsr);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnClearTbChat);
            this.Controls.Add(this.btnBlockTbSt);
            this.Controls.Add(this.btnDelTbSt);
            this.Controls.Add(this.btnDelTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.Text = "Tribal Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelTb;
        private System.Windows.Forms.Button btnDelTbSt;
        private System.Windows.Forms.Button btnBlockTbSt;
        private System.Windows.Forms.Button btnClearTbChat;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDelTbUsr;
    }
}

