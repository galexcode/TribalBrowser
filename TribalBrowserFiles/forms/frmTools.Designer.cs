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

namespace TribalBrowser.forms
{
    partial class frmTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTools));
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnCreateTribe = new System.Windows.Forms.Button();
            this.btnJoinTribe = new System.Windows.Forms.Button();
            this.btnDetailsSites = new System.Windows.Forms.Button();
            this.btnCreateLinks = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowser.BackgroundImage")));
            this.btnBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowser.Location = new System.Drawing.Point(404, 203);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(200, 200);
            this.btnBrowser.TabIndex = 6;
            this.btnBrowser.Text = "Browse";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnCreateTribe
            // 
            this.btnCreateTribe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateTribe.BackgroundImage")));
            this.btnCreateTribe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateTribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateTribe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTribe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateTribe.Location = new System.Drawing.Point(1, 2);
            this.btnCreateTribe.Name = "btnCreateTribe";
            this.btnCreateTribe.Size = new System.Drawing.Size(200, 200);
            this.btnCreateTribe.TabIndex = 1;
            this.btnCreateTribe.Text = "Create Tribe";
            this.btnCreateTribe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateTribe.UseVisualStyleBackColor = true;
            this.btnCreateTribe.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnJoinTribe
            // 
            this.btnJoinTribe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJoinTribe.BackgroundImage")));
            this.btnJoinTribe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoinTribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoinTribe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinTribe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJoinTribe.Location = new System.Drawing.Point(202, 2);
            this.btnJoinTribe.Name = "btnJoinTribe";
            this.btnJoinTribe.Size = new System.Drawing.Size(200, 200);
            this.btnJoinTribe.TabIndex = 2;
            this.btnJoinTribe.Text = "Join Tribe";
            this.btnJoinTribe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJoinTribe.UseVisualStyleBackColor = true;
            this.btnJoinTribe.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnDetailsSites
            // 
            this.btnDetailsSites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetailsSites.BackgroundImage")));
            this.btnDetailsSites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetailsSites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetailsSites.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsSites.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetailsSites.Location = new System.Drawing.Point(202, 203);
            this.btnDetailsSites.Name = "btnDetailsSites";
            this.btnDetailsSites.Size = new System.Drawing.Size(200, 200);
            this.btnDetailsSites.TabIndex = 5;
            this.btnDetailsSites.Text = "My Details/Sites/Tribes";
            this.btnDetailsSites.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetailsSites.UseVisualStyleBackColor = true;
            this.btnDetailsSites.Click += new System.EventHandler(this.myDetails_Click);
            // 
            // btnCreateLinks
            // 
            this.btnCreateLinks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateLinks.BackgroundImage")));
            this.btnCreateLinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateLinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateLinks.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLinks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateLinks.Location = new System.Drawing.Point(404, 2);
            this.btnCreateLinks.Name = "btnCreateLinks";
            this.btnCreateLinks.Size = new System.Drawing.Size(200, 200);
            this.btnCreateLinks.TabIndex = 3;
            this.btnCreateLinks.Text = "Create your links";
            this.btnCreateLinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateLinks.UseVisualStyleBackColor = true;
            this.btnCreateLinks.Click += new System.EventHandler(this.btnCreateLinks_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.BackgroundImage")));
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetails.Location = new System.Drawing.Point(1, 203);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(200, 200);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "My Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // frmTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(607, 404);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnCreateLinks);
            this.Controls.Add(this.btnDetailsSites);
            this.Controls.Add(this.btnJoinTribe);
            this.Controls.Add(this.btnCreateTribe);
            this.Controls.Add(this.btnBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnCreateTribe;
        private System.Windows.Forms.Button btnJoinTribe;
        private System.Windows.Forms.Button btnDetailsSites;
        private System.Windows.Forms.Button btnCreateLinks;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ToolTip toolTip;
    }
}