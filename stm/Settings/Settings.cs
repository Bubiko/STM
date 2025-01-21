using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using UserInfo;

namespace stm.Settings
{
    public partial class Settings : Form
    {
        private bool AccountBox = true;
        private bool DownloadBox = false;
        private bool CloudBox = false;
        ChromiumWebBrowser browser_Settings;
        UserInfo.UserBasicInfo User_Settings;
        public Settings(UserInfo.UserBasicInfo User, ChromiumWebBrowser browser)
        {
            InitializeComponent(User);
            Cloud_Panel.Hide();
            Download_Panel.Hide();
            User_Settings = User;
            browser_Settings = browser;
        }

        private void Settings_Account_Click(object sender, EventArgs e)
        {
            if(DownloadBox == true)
            {
                Account_Panel.Show();
                Download_Panel.Hide();
                AccountBox = true;
                DownloadBox = false;
                Settings_Account.BackColor = System.Drawing.ColorTranslator.FromHtml("#2a2d34");
            }
            if(CloudBox == true)
            {
                Account_Panel.Show();
                Cloud_Panel.Hide();
                AccountBox = true;
                CloudBox = false;
                Settings_Cloud.BackColor = System.Drawing.ColorTranslator.FromHtml("#2a2d34");
            }
        }
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = System.Drawing.ColorTranslator.FromHtml("#dcdedf");
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = this.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AccountBox == true) 
            {
                Account_Panel.Hide();
                Download_Panel.Show();
                AccountBox = false;
                DownloadBox = true;
            }
            if(CloudBox ==true)
            {
                Cloud_Panel.Hide();
                Download_Panel.Show();
                DownloadBox = true;
                CloudBox = false;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            browser_Settings.Load("https://steamcommunity.com/profiles/"+User_Settings.UserID);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DownloadSpeed_Click(object sender, EventArgs e)
        {
            if (DownloadSpeed.Text == "Nu")
            {
                DownloadSpeed.Text = "Da";
            }
            else DownloadSpeed.Text = "Nu";
        }

        private void DownloadGameplay_Click(object sender, EventArgs e)
        {
            if (DownloadGameplay.Text == "Nu")
            {
                DownloadGameplay.Text = "Da";
            }
            else DownloadGameplay.Text = "Nu";
        }

        private void Settings_Cloud_Click(object sender, EventArgs e)
        {
            if(AccountBox == true)
            {
                AccountBox = false;
                Account_Panel.Hide();
                Cloud_Panel.Show();
                CloudBox = true;
            }
            if(DownloadBox == true)
            {
                DownloadBox = false;
                Download_Panel.Hide();
                Cloud_Panel.Show();
                CloudBox = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
   
}
