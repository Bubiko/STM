using stm.Properties;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;
using UserInfo;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MainW
{
    public partial class MainWindow : Form
    {
        public UserInfo.UserBasicInfo User = new UserBasicInfo();
        private Library library = new Library();
        private ChromiumWebBrowser browser;
        private ChromiumWebBrowser GameNews;
        private ChromiumWebBrowser GameFriends;
        private ChromiumWebBrowser GameScreens;
        CefSettings Brosersettings = new CefSettings();
        private bool LibraryWin = false;
        private bool WebWin = true;
        private bool FirstTimeGamePanel = false;
        private int KKTDElimba = 0;

        private static stm.Login.Login Login;
        private static stm.Settings.Settings SettingsWindow;
        private static stm.Friends.Friends FriendsWindow;

        private List<Button> Library_Buttons = new List<Button>();
        public MainWindow()
        {
            //Int browser
            //string SteamCache = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+ "/Steam/htmlcache";
            //CefSettings Brosersettings = new CefSettings();
            Brosersettings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; Valve Steam Client/1709846872) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.5414.120 Safari/537.36";
            Brosersettings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "cache";
            Cef.Initialize(Brosersettings);       
            browser = new ChromiumWebBrowser("https://store.steampowered.com");
            GameFriends = new ChromiumWebBrowser();
            GameNews = new ChromiumWebBrowser();
            GameScreens = new ChromiumWebBrowser();
            //Brosersettings.UserAgent = "";
            //Int lirary
            library.LibraryIntializa();
            //Int User acc info
            User.GetUserInfo();
            //wait browser to load
            System.Threading.Thread.Sleep(2000);
            InitializeComponent();
            CreateLeftLibraryButtons();
            //Set runtimevars
            UserNameLabel.Text = User.UserName;
            UserProfile_Putton.Text = User.UserName;
            pictureBox1.ImageLocation = "C:/Program Files (x86)/Steam/config/avatarcache/" + User.UserID + ".png";
            //Hide all the bullshit
            UserButton_SubPanel.Hide(); 
            Library_Panel.Hide();
            ActivateProductPanel.Hide();
            Library_SubPanel_GamePanel.Hide();
            UrlLabelUpdater.RunWorkerAsync();
        }

        private void CreateLeftLibraryButtons()
        {
            int Y = LibraryPanel_Subpanel_Stanga.Location.Y;
            int X = LibraryPanel_Subpanel_Stanga.Location.X;
            for (int i = 0; i < library.GamesAppID.Count; i++)
            {//si asa am stricat search la jocuri ;(
                /*GroupBox groupBox = new GroupBox();
                groupBox.Left = X;
                groupBox.Top = Y;
                groupBox.Size = new Size(211, 25);
                groupBox.Name = i.ToString();

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(6, 5);
                pictureBox1.Size = new Size(20,20);
                string Icon = "C:/Program Files (x86)/Steam/appcache/librarycache/" + library.GamesAppID[int.Parse(groupBox.Name)] + "_icon.jpg";
                if (!File.Exists(Icon))
                    Icon = "C:/Program Files (x86)/Steam/steamui/images/glyph_x.png";
                pictureBox1.ImageLocation = Icon;
                Label label = new Label();
                label.Location = new Point(32, 9);
                label.Text = library.GameName[i];

                LibraryPanel_Subpanel_Stanga.Controls.Add(b);
                Library_Buttons.Add(b);*/


                Button b = new Button();
                b.Left = X;
                b.Top = Y;
                Y +=30;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
                b.ForeColor = System.Drawing.Color.LightGray;
                b.Size = new System.Drawing.Size(230, 25);
                b.Name = i.ToString();
                string Icon = "C:/Program Files (x86)/Steam/appcache/librarycache/" + library.GamesAppID[int.Parse(b.Name)] + "_icon.jpg";
                if (!File.Exists(Icon))
                    Icon = "C:/Program Files (x86)/Steam/steamui/images/glyph_x.png";
                pictureBox1.ImageLocation = Icon;
                b.Image = Image.FromFile(Icon);
                b.TextAlign = ContentAlignment.MiddleRight;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.Text = library.GameName[i];
                b.Click += new EventHandler(ClickLaButon);
                LibraryPanel_Subpanel_Stanga.Controls.Add(b);
                Library_Buttons.Add(b);
            }
        }

        private void ClickLaButon(object sender, EventArgs e)
        {  
            if(FirstTimeGamePanel == false)
            {
                Library_SubPanel_GamePanel.Show();
                FirstTimeGamePanel = true;
            }
            Button Send = sender as Button;
            Game_Header.ImageLocation = "C:/Program Files (x86)/Steam/appcache/librarycache/"+library.GamesAppID[int.Parse(Send.Name)]+ "_library_hero.jpg";
            GamePanel_GameLogo.ImageLocation = "C:/Program Files (x86)/Steam/appcache/librarycache/" + library.GamesAppID[int.Parse(Send.Name)] + "_logo.png";
            KKTDElimba = int.Parse(Send.Name);
            GamePanel_StoreButton.Click += new EventHandler(GamePanel_StoreButton_Click);
            GamePanel_Discussions.Click += new EventHandler(GamePanel_Discussions_Click);
            GamePanel_CominityHub.Click += new EventHandler(GamePanel_CommunityHub_Click);
            GamePanel_Guides.Click += new EventHandler(GamePanel_Guides_Click);
            GamePanel_Support.Click += new EventHandler(GamePanel_Support_Click);
            GameFriends.Load("https://steamcommunity.com/my/friendsthatplay/"+ library.GamesAppID[int.Parse(Send.Name)]);
            GameNews.Load("https://steamcommunity.com/app/" + library.GamesAppID[int.Parse(Send.Name)] + "/allnews");
            GameScreens.Load("https://steamcommunity.com/app/"+ library.GamesAppID[int.Parse(Send.Name)] + "/screenshots/");
            if (User.UserID == library.GameOwner[int.Parse(Send.Name)] && library.GameState[int.Parse(Send.Name)] == 4)
            {
                PlayButton.Text = "Play";
                PlayButton.BackColor = Color.Green;
                PlayButton.Click += new EventHandler(PlayToPlay);
            }
            else if (library.GameState[int.Parse(Send.Name)] != 4)
            {
                PlayButton.BackColor = Color.Blue;
                PlayButton.Text = "Install";
            }
            else if (User.UserID != library.GameOwner[int.Parse(Send.Name)])
            {
                PlayButton.BackColor = Color.Gray;
                PlayButton.Text = "Purchase";
                PlayButton.Click += new EventHandler(PlayToPurchase);
            }

        }

        private void GamePanel_Support_Click(object sender, EventArgs e)
        {
            Library_Panel.Hide();
            WebStorePanel.Show();
            LibraryWin = false;
            WebWin = true;
            browser.Load("https://help.steampowered.com/en/wizard/HelpWithGame/?appid=" + library.GamesAppID[KKTDElimba]);
        }

        private void GamePanel_Guides_Click(object sender, EventArgs e)
        {
            Library_Panel.Hide();
            WebStorePanel.Show();
            LibraryWin = false;
            WebWin = true;
            browser.Load("https://steamcommunity.com/app/" + library.GamesAppID[KKTDElimba] + "/guides");
        }
        private void GamePanel_Discussions_Click(object sender, EventArgs e)
        {
            Library_Panel.Hide();
            WebStorePanel.Show();
            LibraryWin = false;
            WebWin = true;
            browser.Load("https://steamcommunity.com/app/" + library.GamesAppID[KKTDElimba]+ "/discussions");
        }
        private void GamePanel_CommunityHub_Click(object sender, EventArgs e)
        {
            Library_Panel.Hide();
            WebStorePanel.Show();
            LibraryWin = false;
            WebWin = true;
            browser.Load("https://steamcommunity.com/app/" + library.GamesAppID[KKTDElimba]);
        }
        private void GamePanel_StoreButton_Click(object sender, EventArgs e)
        {
            Library_Panel.Hide();
            WebStorePanel.Show();
            LibraryWin = false;
            WebWin = true;
            browser.Load("https://store.steampowered.com/app/" + library.GamesAppID[KKTDElimba]);
        }

        private void PlayToPurchase(object sender, EventArgs e)
        {
            Library_Panel.Hide();
            WebStorePanel.Show();
            LibraryWin = false;
            WebWin = true;
            browser.Load("https://store.steampowered.com/app/" + library.GamesAppID[KKTDElimba]);
            
        }

        private void PlayToPlay(object sender, EventArgs e)
        {
            if (library.GameOwner[KKTDElimba] == User.UserID)
                Process.Start("steam://rungameid/"+ library.GamesAppID[KKTDElimba]);
        }

        private void GoToSettings_Click(object sender, EventArgs e)
        {
            if(SettingsWindow == null)
            {
                SettingsWindow = new stm.Settings.Settings(User,browser);
                SettingsWindow.Show();
            }
            else
            {
                SettingsWindow.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(!WebStorePanel.Visible)
            {
                WebStorePanel.Show();
            }
            else 
            {
                WebStorePanel.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            browser.Dock = DockStyle.Fill;
            WebStorePanel.Controls.Add(browser);
        }

        private void LibraryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Library_Button_Click(object sender, EventArgs e)
        {
            if (WebWin == true)
            {
                Library_Panel.Show();
                WebStorePanel.Hide();
                WebWin = false;
                LibraryWin = true;
            }
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            browser.Load("https://store.steampowered.com/");
            if (LibraryWin == true)
            {
                Library_Panel.Hide();
                WebStorePanel.Show();
                WebWin = true;
                LibraryWin = false;
            }
        }

        private void Steam_Settings_Click(object sender, EventArgs e)
        {
            if (SettingsWindow == null)
            {
                SettingsWindow = new stm.Settings.Settings(User, browser);
                SettingsWindow.Show();
            }
            else
            {
                SettingsWindow.Show();
            }
        }

        private void Community_Button_Click(object sender, EventArgs e)
        {
            browser.Load("https://steamcommunity.com/");
            if (LibraryWin == true)
            {
                Library_Panel.Hide();
                WebStorePanel.Show();
                WebWin = true;
                LibraryWin = false;
            }
        }

        private void ActivateProductPanel_Paint(object sender, PaintEventArgs e)
        {
            //ActivateProductPanel.Hide();
        }

        private void Add_NewGame_Button_Click(object sender, EventArgs e)
        {        
            ActivateProductPanel.BringToFront(); 
            ActivateProductPanel.Show();
        }

        private void Acctivati_Close_Click(object sender, EventArgs e)
        {
            string CDKey = this.textBox1.Text;
            if (CDKey == null || CDKey.Length != 14 || CDKey.Length > 14) { MessageBox.Show("FILL THE FUCKING BOX DOG", "BONKK", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                string[] CDKeySplit = CDKey.Split('-');
                string GameKeyServerAddress = "https://sicker-forests.000webhostapp.com/app/GameKeys/" + CDKeySplit[0] + "/" + CDKeySplit[1] + "/" + CDKeySplit[2];
                var webclient = new HtmlWeb();
                var CDKeyFromServerStatus = webclient.Load(GameKeyServerAddress + "/status");
                var CDKeyFromServerName = webclient.Load(GameKeyServerAddress + "/name");
                if (CDKeyFromServerStatus.Text == "valid")
                {
                    MessageBox.Show("Thank you for activating " + CDKeyFromServerName.Text, "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.textBox1.Clear();
                    this.textBox1.Text = "";
                    this.ActivateProductPanel.Hide();
                }
                else if (CDKeyFromServerStatus.Text == "used")
                {
                    MessageBox.Show("The key for " + CDKeyFromServerName.Text + " was already used", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Error or IDK :)", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ActivateProductPanel.Hide();
        }

        private void ActivateDialib_X_Click(object sender, EventArgs e)
        {
            ActivateProductPanel.Hide();
        }

        private void UserProfile_Putton_Click(object sender, EventArgs e)
        {
            browser.Load("https://steamcommunity.com/profiles/" + User.UserID);
            if (LibraryWin == true)
            {
                Library_Panel.Hide();
                WebStorePanel.Show();
                WebWin = true;
                LibraryWin = false;
            }
        }
        
        private void UserProbileButton_Hold(object sender, EventArgs e)
        {
            //UserProfile_Putton.Size = new System.Drawing.Size(152, 129);
            UserButton_SubPanel.Show();
        }
        private void UserProbileButton_Stophold(object sender, EventArgs e)
        {
            if(!UserButton_SubPanel.Bounds.Contains(PointToClient(MousePosition))|| !UserProfile_Putton.Bounds.Contains(PointToClient(MousePosition)))
            {
                UserButton_SubPanel.Hide();
            }
        }

        private void UserButton_Subbut_YEAR_Click(object sender, EventArgs e)
        {
            browser.Load("https://store.steampowered.com/yearinreview/"+User.UserID+"/2023");
            if (LibraryWin == true)
            {
                Library_Panel.Hide();
                WebStorePanel.Show();
                WebWin = true;
                LibraryWin = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //It's broken :(
        private void Search_Enter(object sender, KeyPressEventArgs e)
        {
            string SearchContent = GamePanel_Search.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                int Y = LibraryPanel_Subpanel_Stanga.Location.Y;
                int X = LibraryPanel_Subpanel_Stanga.Location.X;
                for (int i = 0; i < Library_Buttons.Count; i++)
                {
                    Library_Buttons[i].Hide();
                }
                Library_Buttons.Clear();
                for (int i = 0; i < library.GamesAppID.Count; i++)
                {
                    if (library.GameName[i].Contains(GamePanel_Search.Text))
                    {
                    Button b = new Button();
                    b.Left = X;
                    b.Top = Y;
                    Y += 30;
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    b.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
                    b.ForeColor = System.Drawing.Color.LightGray;
                    b.Size = new System.Drawing.Size(230, 25);
                    b.Name = i.ToString();
                    string Icon = "C:/Program Files (x86)/Steam/appcache/librarycache/" + library.GamesAppID[int.Parse(b.Name)] + "_icon.jpg";
                    if (!File.Exists(Icon)) Icon = "C:/Program Files (x86)/Steam/steamui/images/glyph_x.png";
                    b.Image = Image.FromFile(Icon);
                    b.TextAlign = ContentAlignment.MiddleRight;
                    b.ImageAlign = ContentAlignment.MiddleLeft;
                    b.Text = library.GameName[i];
                    b.Click += new EventHandler(ClickLaButon);
                    LibraryPanel_Subpanel_Stanga.Controls.Add(b);
                    Library_Buttons.Add(b);
                    }
                }
            }
        }

        private void Activity_User_Click(object sender, EventArgs e)
        {
            browser.Load("https://steamcommunity.com/profiles/" + User.UserID + "/home");
            if (LibraryWin == true)
            {
                Library_Panel.Hide();
                WebStorePanel.Show();
                WebWin = true;
                LibraryWin = false;
            }
        }

        private void Help_Lable_Click(object sender, EventArgs e)
        {
            browser.Load("https://help.steampowered.com/en/");
            if (LibraryWin == true)
            {
                Library_Panel.Hide();
                WebStorePanel.Show();
                WebWin = true;
                LibraryWin = false;
            }
        }

        private void Login_Lable_Click(object sender, EventArgs e)
        {
            Login = new stm.Login.Login(Brosersettings);
            Login.Show();
        }


        private void UserInfo_RightTop_Paint(object sender, EventArgs e)
        {
            browser.Load("https://store.steampowered.com/account/");
            if (LibraryWin == true)
            {
                Library_Panel.Hide();
                WebStorePanel.Show();
                WebWin = true;
                LibraryWin = false;
            }
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            if (FriendsWindow == null)
            {
                FriendsWindow = new stm.Friends.Friends(User.UserID);
                FriendsWindow.Show();
            }
            else FriendsWindow.Show();
        }

        private void GamePanel_GameNews_Paint(object sender, PaintEventArgs e)
        {
            GameNews.Dock = DockStyle.Fill;
            GamePanel_GameNews.Controls.Add(GameNews);
        }

        private void Gamepanel_screenshot_Paint(object sender, PaintEventArgs e)
        {
            GameScreens.Dock = DockStyle.Fill;
            Gamepanel_screenshot.Controls.Add(GameScreens);
        }

        private void UrlLabelUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) { urlLabel.Text = browser.Address.ToString(); }
        }

        private void urlLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(urlLabel.Text);
        }

        private void GamePanel_Friends_Paint(object sender, PaintEventArgs e)
        {
            GameFriends.Dock = DockStyle.Fill;
            GamePanel_Friends.Controls.Add(GameFriends);
        }

        private void SteamAPICracked_Click(object sender, EventArgs e)
        {
            string PathNeeded = library.GiveMeTheGamePath(library.GamesAppID[KKTDElimba]);
            string GameDirName = "";
            string CurrentPath = "";
            foreach(string DirName in File.ReadAllLines(PathNeeded))
            {
                if(DirName.Contains("installdir"))
                {
                    GameDirName = DirName.Replace("\t\"installdir\"\t\t\"","");
                    GameDirName = GameDirName.Replace("\"","");
                }
            }

            foreach(var path in library.GamesPaths)
            {
                if(PathNeeded.Contains(path))
                {
                    CurrentPath = path;
                }
            }
            bool CreamAPIConfig = false;
            string GamePathForSteamDLL = CurrentPath + "\\common\\" + GameDirName;
            string SteamDLL = "steam_api.dll";
            string SteamDLLx64 = "steam_api64.dll";
            string SteamAPIFolder = "";
            bool SteamDLLBool = false; bool SteamDLLx64Bool = false;
            string[] SteamDefaulDlls = Directory.GetFiles(GamePathForSteamDLL, SteamDLL, SearchOption.AllDirectories);
            if (SteamDefaulDlls.Length > 0)
            {
                string PathTemp = SteamDefaulDlls[0];
                string pp = SteamDefaulDlls[0]; pp = pp.Replace(SteamDLL ,"cream_api.ini");
                if (File.Exists(pp))
                {
                    MessageBox.Show("Already unlocked, the game may open", "SteamAPI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CreamAPIConfig = true;
                    string[] exeFiles = Directory.GetFiles(GamePathForSteamDLL, "*.exe", SearchOption.AllDirectories);
                    var Game = new Process();
                    Game.StartInfo.FileName = exeFiles[0];
                    Game.Start();
                    return;
                }
                PathTemp = PathTemp.Replace(SteamDLL, "steam_api_o.dll");
                File.Move(SteamDefaulDlls[0], PathTemp);
                PathTemp = PathTemp.Replace("steam_api_o.dll", "steam_api.dll");
                File.Copy("./API/steam_api.dll", PathTemp);
                SteamAPIFolder = PathTemp;
                SteamDLLBool = true;
            }
            else
            {
                if (CreamAPIConfig == true) return;
                string[] Steamx64Dlls = Directory.GetFiles(GamePathForSteamDLL, SteamDLLx64, SearchOption.AllDirectories);
                if(Steamx64Dlls.Length > 0) 
                {
                    string PathTemp = Steamx64Dlls[0];
                    PathTemp = PathTemp.Replace(SteamDLLx64, "steam_api64_o.dll");
                    File.Move(Steamx64Dlls[0], PathTemp);
                    PathTemp = PathTemp.Replace("steam_api64_o.dll", "steam_api64.dll");
                    File.Copy("./API/steam_api64.dll", PathTemp);
                    SteamAPIFolder = PathTemp;
                    SteamDLLx64Bool = true;
                }
                else
                {
                    MessageBox.Show("No steam dlls found", "SteamAPI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(SteamDLLBool || SteamDLLx64Bool == true)
            {
                string[] arrLine = File.ReadAllLines("./API/cream_api.ini");
                arrLine[2] = "appid = "+ library.GamesAppID[KKTDElimba];
                File.WriteAllLines("./API/cream_api.ini", arrLine);
                if (SteamDLLBool == true) SteamAPIFolder = SteamAPIFolder.Replace("steam_api.dll", "cream_api.ini");
                if (SteamDLLx64Bool == true) SteamAPIFolder = SteamAPIFolder.Replace("steam_api64.dll", "cream_api.ini");
                File.Copy("./API/cream_api.ini", SteamAPIFolder);
            }


        }
    }
}
