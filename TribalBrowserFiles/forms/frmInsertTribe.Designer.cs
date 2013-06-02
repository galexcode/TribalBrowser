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
    partial class frmInsertTribe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertTribe));
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtTbNm = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDsc = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(166, 252);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(167, 156);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create Tribe";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtTbNm
            // 
            this.txtTbNm.Location = new System.Drawing.Point(12, 34);
            this.txtTbNm.MaxLength = 100;
            this.txtTbNm.Name = "txtTbNm";
            this.txtTbNm.Size = new System.Drawing.Size(485, 22);
            this.txtTbNm.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(8, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 22);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Tribe Name";
            // 
            // txtDsc
            // 
            this.txtDsc.Location = new System.Drawing.Point(12, 95);
            this.txtDsc.MaxLength = 300;
            this.txtDsc.Multiline = true;
            this.txtDsc.Name = "txtDsc";
            this.txtDsc.Size = new System.Drawing.Size(485, 151);
            this.txtDsc.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(12, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 22);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // frmInsertTribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(509, 410);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDsc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTbNm);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsertTribe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtTbNm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDsc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ToolTip toolTip;
    }
}