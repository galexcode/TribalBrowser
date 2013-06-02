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
    partial class frmAddFavourite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFavourite));
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDsc = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(9, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 22);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // txtDsc
            // 
            this.txtDsc.Location = new System.Drawing.Point(9, 94);
            this.txtDsc.MaxLength = 300;
            this.txtDsc.Multiline = true;
            this.txtDsc.Name = "txtDsc";
            this.txtDsc.Size = new System.Drawing.Size(485, 151);
            this.txtDsc.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(5, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 22);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Site Name";
            // 
            // txtSt
            // 
            this.txtSt.Location = new System.Drawing.Point(9, 33);
            this.txtSt.MaxLength = 100;
            this.txtSt.Name = "txtSt";
            this.txtSt.Size = new System.Drawing.Size(485, 22);
            this.txtSt.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(163, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 156);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add To Favourites";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddFavourite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(504, 416);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDsc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSt);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddFavourite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDsc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSt;
        private System.Windows.Forms.Button btnAdd;
    }
}