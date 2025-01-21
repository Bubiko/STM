using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CefSharp;
using CefSharp.WinForms;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace stm.Friends
{
    public partial class Friends : Form
    {
        ChromiumWebBrowser FriendsBrowser;
        public Friends(string UserID)
        {
            FriendsBrowser = new ChromiumWebBrowser("https://steamcommunity.com/profiles/" + UserID + "/friends");
            InitializeComponent();
            GetFriendsData(UserID);
        }

        private void GetFriendsData(string UserID)
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://steamcommunity.com/profiles/" + UserID + "/friends");
            var Noduri = doc.DocumentNode.SelectNodes("//a[contains(@class, '{selectable friend_block_v2 persona in-game}')]");
            if (Noduri != null)
            {
                foreach (var node in Noduri)
                {

                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            FriendsBrowser.Dock = DockStyle.Fill;
            panel1.Controls.Add(FriendsBrowser);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
