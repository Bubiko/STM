using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stm.Login
{
    public partial class Login : Form
    {
        private ChromiumWebBrowser Browser;
        public Login(CefSettings Brosersettings)
        {
            //Cef.Initialize(Brosersettings);
            Browser = new ChromiumWebBrowser("https://help.steampowered.com/en/wizard/Login");
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Browser.Dock = DockStyle.Fill;
            panel1.Controls.Add(Browser);
        }
    }
}
