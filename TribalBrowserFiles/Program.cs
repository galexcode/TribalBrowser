using System;
using System.Windows.Forms;
using TribalBrowser.forms;
using TribalBrowser.helpers;

namespace TribalBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TribeMisc.GetUserInfo();
            Application.Run(new frmBrowser());
        }
    }
}
