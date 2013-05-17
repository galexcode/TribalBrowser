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
    partial class frmTribeMemberDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTribeMemberDetails));
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPss = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPss = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsrNm = new System.Windows.Forms.TextBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmPass.Location = new System.Drawing.Point(8, 111);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(158, 22);
            this.lblConfirmPass.TabIndex = 17;
            this.lblConfirmPass.Text = "Confirm Password";
            // 
            // txtConfirmPss
            // 
            this.txtConfirmPss.Location = new System.Drawing.Point(12, 136);
            this.txtConfirmPss.MaxLength = 100;
            this.txtConfirmPss.Name = "txtConfirmPss";
            this.txtConfirmPss.Size = new System.Drawing.Size(342, 22);
            this.txtConfirmPss.TabIndex = 3;
            this.txtConfirmPss.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(8, 57);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(88, 22);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Password";
            // 
            // txtPss
            // 
            this.txtPss.Location = new System.Drawing.Point(12, 82);
            this.txtPss.MaxLength = 100;
            this.txtPss.Name = "txtPss";
            this.txtPss.Size = new System.Drawing.Size(342, 22);
            this.txtPss.TabIndex = 2;
            this.txtPss.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Location = new System.Drawing.Point(8, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 22);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "Name";
            // 
            // txtUsrNm
            // 
            this.txtUsrNm.Location = new System.Drawing.Point(12, 32);
            this.txtUsrNm.MaxLength = 100;
            this.txtUsrNm.Name = "txtUsrNm";
            this.txtUsrNm.Size = new System.Drawing.Size(342, 22);
            this.txtUsrNm.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.BackgroundImage")));
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetails.Location = new System.Drawing.Point(113, 164);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(140, 144);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Save My Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // frmTribeMemberDetails
            // 
            this.AcceptButton = this.btnDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(372, 315);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.txtConfirmPss);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPss);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUsrNm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTribeMemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTribeMemberDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPss;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPss;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsrNm;
        private System.Windows.Forms.Button btnDetails;
    }
}