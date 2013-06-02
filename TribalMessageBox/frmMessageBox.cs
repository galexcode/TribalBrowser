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

using System.Drawing;
using System.Windows.Forms;

namespace TribalMessageBox
{
    public partial class frmMessageBox : Form
    {
        #region Constructors/ Initialisers

        public frmMessageBox()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Methods

        public DialogResult Show(string text, Color foreColour)
        {
            lblText.Text = text;
            lblText.ForeColor = foreColour;
            return ShowDialog();
        }

        public DialogResult Show(string text)
        {
            lblText.Text = text;
            return ShowDialog();
        }

        public DialogResult ShowCancel(string text)
        {
            btnCancel.Visible = true;
            btnOK.Left = 100;
            btnCancel.Left = 170;
            lblText.Text = text;
            return ShowDialog();
        }

        #endregion
    }
}
