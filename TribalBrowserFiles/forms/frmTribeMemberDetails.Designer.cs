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
            this.lblConfirmPss = new System.Windows.Forms.Label();
            this.txtConfirmPss = new System.Windows.Forms.TextBox();
            this.lblPss = new System.Windows.Forms.Label();
            this.txtPss = new System.Windows.Forms.TextBox();
            this.lblUsrNm = new System.Windows.Forms.Label();
            this.txtUsrNm = new System.Windows.Forms.TextBox();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmPss
            // 
            this.lblConfirmPss.AutoSize = true;
            this.lblConfirmPss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPss.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmPss.Location = new System.Drawing.Point(8, 111);
            this.lblConfirmPss.Name = "lblConfirmPss";
            this.lblConfirmPss.Size = new System.Drawing.Size(158, 22);
            this.lblConfirmPss.TabIndex = 17;
            this.lblConfirmPss.Text = "Confirm Password";
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
            // lblPss
            // 
            this.lblPss.AutoSize = true;
            this.lblPss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPss.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPss.Location = new System.Drawing.Point(8, 57);
            this.lblPss.Name = "lblPss";
            this.lblPss.Size = new System.Drawing.Size(88, 22);
            this.lblPss.TabIndex = 15;
            this.lblPss.Text = "Password";
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
            // lblUsrNm
            // 
            this.lblUsrNm.AutoSize = true;
            this.lblUsrNm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrNm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsrNm.Location = new System.Drawing.Point(8, 7);
            this.lblUsrNm.Name = "lblUsrNm";
            this.lblUsrNm.Size = new System.Drawing.Size(56, 22);
            this.lblUsrNm.TabIndex = 13;
            this.lblUsrNm.Text = "Name";
            // 
            // txtUsrNm
            // 
            this.txtUsrNm.Location = new System.Drawing.Point(12, 32);
            this.txtUsrNm.MaxLength = 100;
            this.txtUsrNm.Name = "txtUsrNm";
            this.txtUsrNm.Size = new System.Drawing.Size(342, 22);
            this.txtUsrNm.TabIndex = 1;
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveDetails.BackgroundImage")));
            this.btnSaveDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveDetails.Location = new System.Drawing.Point(113, 164);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(140, 144);
            this.btnSaveDetails.TabIndex = 4;
            this.btnSaveDetails.Text = "Save My Details";
            this.btnSaveDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveDetails.UseVisualStyleBackColor = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // frmTribeMemberDetails
            // 
            this.AcceptButton = this.btnSaveDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(372, 315);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.lblConfirmPss);
            this.Controls.Add(this.txtConfirmPss);
            this.Controls.Add(this.lblPss);
            this.Controls.Add(this.txtPss);
            this.Controls.Add(this.lblUsrNm);
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

        private System.Windows.Forms.Label lblConfirmPss;
        private System.Windows.Forms.TextBox txtConfirmPss;
        private System.Windows.Forms.Label lblPss;
        private System.Windows.Forms.TextBox txtPss;
        private System.Windows.Forms.Label lblUsrNm;
        private System.Windows.Forms.TextBox txtUsrNm;
        private System.Windows.Forms.Button btnSaveDetails;
    }
}