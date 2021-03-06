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
            this.btnDeleteTribe = new System.Windows.Forms.Button();
            this.btnDeleteTribeLinks = new System.Windows.Forms.Button();
            this.btnBlockTribeLinks = new System.Windows.Forms.Button();
            this.btnClearTribeChat = new System.Windows.Forms.Button();
            this.btnClearDatabase = new System.Windows.Forms.Button();
            this.btnDeleteTribeMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteTribe
            // 
            this.btnDeleteTribe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTribe.BackgroundImage")));
            this.btnDeleteTribe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTribe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTribe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTribe.Location = new System.Drawing.Point(0, 2);
            this.btnDeleteTribe.Name = "btnDeleteTribe";
            this.btnDeleteTribe.Size = new System.Drawing.Size(200, 200);
            this.btnDeleteTribe.TabIndex = 0;
            this.btnDeleteTribe.Text = "Delete Tribe";
            this.btnDeleteTribe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteTribe.UseVisualStyleBackColor = true;
            this.btnDeleteTribe.Click += new System.EventHandler(this.btnDeleteTribe_Click);
            // 
            // btnDeleteTribeLinks
            // 
            this.btnDeleteTribeLinks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTribeLinks.BackgroundImage")));
            this.btnDeleteTribeLinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTribeLinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTribeLinks.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTribeLinks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTribeLinks.Location = new System.Drawing.Point(195, 2);
            this.btnDeleteTribeLinks.Name = "btnDeleteTribeLinks";
            this.btnDeleteTribeLinks.Size = new System.Drawing.Size(200, 200);
            this.btnDeleteTribeLinks.TabIndex = 1;
            this.btnDeleteTribeLinks.Text = "Delete Tribe Links";
            this.btnDeleteTribeLinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteTribeLinks.UseVisualStyleBackColor = true;
            this.btnDeleteTribeLinks.Click += new System.EventHandler(this.btnDeleteTribeLinks_Click);
            // 
            // btnBlockTribeLinks
            // 
            this.btnBlockTribeLinks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlockTribeLinks.BackgroundImage")));
            this.btnBlockTribeLinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlockTribeLinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlockTribeLinks.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockTribeLinks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBlockTribeLinks.Location = new System.Drawing.Point(0, 201);
            this.btnBlockTribeLinks.Name = "btnBlockTribeLinks";
            this.btnBlockTribeLinks.Size = new System.Drawing.Size(200, 200);
            this.btnBlockTribeLinks.TabIndex = 3;
            this.btnBlockTribeLinks.Text = "Block Tribe Links";
            this.btnBlockTribeLinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBlockTribeLinks.UseVisualStyleBackColor = true;
            this.btnBlockTribeLinks.Click += new System.EventHandler(this.btnBlockTribeLinks_Click);
            // 
            // btnClearTribeChat
            // 
            this.btnClearTribeChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearTribeChat.BackgroundImage")));
            this.btnClearTribeChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearTribeChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearTribeChat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTribeChat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearTribeChat.Location = new System.Drawing.Point(195, 201);
            this.btnClearTribeChat.Name = "btnClearTribeChat";
            this.btnClearTribeChat.Size = new System.Drawing.Size(200, 200);
            this.btnClearTribeChat.TabIndex = 4;
            this.btnClearTribeChat.Text = "Clear Tribe Chat";
            this.btnClearTribeChat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearTribeChat.UseVisualStyleBackColor = true;
            this.btnClearTribeChat.Click += new System.EventHandler(this.btnClearTribeChat_Click);
            // 
            // btnClearDatabase
            // 
            this.btnClearDatabase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearDatabase.BackgroundImage")));
            this.btnClearDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearDatabase.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDatabase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearDatabase.Location = new System.Drawing.Point(394, 201);
            this.btnClearDatabase.Name = "btnClearDatabase";
            this.btnClearDatabase.Size = new System.Drawing.Size(200, 200);
            this.btnClearDatabase.TabIndex = 5;
            this.btnClearDatabase.Text = "Clear Database";
            this.btnClearDatabase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearDatabase.UseVisualStyleBackColor = true;
            this.btnClearDatabase.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDeleteTribeMember
            // 
            this.btnDeleteTribeMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTribeMember.BackgroundImage")));
            this.btnDeleteTribeMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTribeMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTribeMember.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTribeMember.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTribeMember.Location = new System.Drawing.Point(394, 2);
            this.btnDeleteTribeMember.Name = "btnDeleteTribeMember";
            this.btnDeleteTribeMember.Size = new System.Drawing.Size(200, 200);
            this.btnDeleteTribeMember.TabIndex = 2;
            this.btnDeleteTribeMember.Text = "Delete Tribe Member";
            this.btnDeleteTribeMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteTribeMember.UseVisualStyleBackColor = true;
            this.btnDeleteTribeMember.Click += new System.EventHandler(this.btnDeleteTribeMember_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(595, 403);
            this.Controls.Add(this.btnDeleteTribeMember);
            this.Controls.Add(this.btnClearDatabase);
            this.Controls.Add(this.btnClearTribeChat);
            this.Controls.Add(this.btnBlockTribeLinks);
            this.Controls.Add(this.btnDeleteTribeLinks);
            this.Controls.Add(this.btnDeleteTribe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tribal Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteTribe;
        private System.Windows.Forms.Button btnDeleteTribeLinks;
        private System.Windows.Forms.Button btnBlockTribeLinks;
        private System.Windows.Forms.Button btnClearTribeChat;
        private System.Windows.Forms.Button btnClearDatabase;
        private System.Windows.Forms.Button btnDeleteTribeMember;
    }
}

