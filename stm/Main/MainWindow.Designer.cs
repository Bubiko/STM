using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UserInfo;

namespace MainW
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.WebStorePanel = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.Community_Button = new System.Windows.Forms.Button();
            this.Library_Button = new System.Windows.Forms.Button();
            this.Home_Button = new System.Windows.Forms.Button();
            this.Steam_Settings = new System.Windows.Forms.Label();
            this.Add_NewGame_Button = new System.Windows.Forms.Button();
            this.ActivateProductPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Acctivati_Close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyExample = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivateDialib_X = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserProfile_Putton = new System.Windows.Forms.Button();
            this.UserButton_SubPanel = new System.Windows.Forms.Panel();
            this.Activity_User = new System.Windows.Forms.Button();
            this.UserButton_Subbut_YEAR = new System.Windows.Forms.Button();
            this.Library_Panel = new System.Windows.Forms.Panel();
            this.GamePanel_Search = new System.Windows.Forms.TextBox();
            this.Library_SubPanel_GamePanel = new System.Windows.Forms.Panel();
            this.GamePanel_GameNews = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Gamepanel_screenshot = new System.Windows.Forms.Panel();
            this.GamePanel_Friends = new System.Windows.Forms.Panel();
            this.GamePanel_QuickButtons = new System.Windows.Forms.Panel();
            this.GamePanel_Support = new System.Windows.Forms.Button();
            this.GamePanel_Guides = new System.Windows.Forms.Button();
            this.GamePanel_Discussions = new System.Windows.Forms.Button();
            this.GamePanel_CominityHub = new System.Windows.Forms.Button();
            this.GamePanel_StoreButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LastPlayed = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.Game_Hours = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.Game_Header = new System.Windows.Forms.PictureBox();
            this.GamePanel_GameLogo = new System.Windows.Forms.PictureBox();
            this.LibraryPanel_Subpanel_Stanga = new System.Windows.Forms.Panel();
            this.Help_Lable = new System.Windows.Forms.Label();
            this.Login_Lable = new System.Windows.Forms.Label();
            this.UserInfo_RightTop = new System.Windows.Forms.Panel();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.UrlLabelUpdater = new System.ComponentModel.BackgroundWorker();
            this.urlLabel = new System.Windows.Forms.Label();
            this.SteamAPICracked = new System.Windows.Forms.Button();
            this.ActivateProductPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserButton_SubPanel.SuspendLayout();
            this.Library_Panel.SuspendLayout();
            this.Library_SubPanel_GamePanel.SuspendLayout();
            this.GamePanel_QuickButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Header)).BeginInit();
            this.Game_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel_GameLogo)).BeginInit();
            this.UserInfo_RightTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebStorePanel
            // 
            this.WebStorePanel.Location = new System.Drawing.Point(0, 94);
            this.WebStorePanel.Name = "WebStorePanel";
            this.WebStorePanel.Size = new System.Drawing.Size(1030, 581);
            this.WebStorePanel.TabIndex = 2;
            this.WebStorePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.UserNameLabel.Location = new System.Drawing.Point(31, 4);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(78, 16);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "User.UserName";
            this.UserNameLabel.Click += new System.EventHandler(this.UserInfo_RightTop_Paint);
            // 
            // Community_Button
            // 
            this.Community_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Community_Button.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.Community_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Community_Button.Location = new System.Drawing.Point(320, 27);
            this.Community_Button.Name = "Community_Button";
            this.Community_Button.Size = new System.Drawing.Size(152, 39);
            this.Community_Button.TabIndex = 4;
            this.Community_Button.Text = "Community";
            this.Community_Button.UseVisualStyleBackColor = true;
            this.Community_Button.Click += new System.EventHandler(this.Community_Button_Click);
            // 
            // Library_Button
            // 
            this.Library_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Library_Button.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.Library_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Library_Button.Location = new System.Drawing.Point(162, 27);
            this.Library_Button.Name = "Library_Button";
            this.Library_Button.Size = new System.Drawing.Size(152, 39);
            this.Library_Button.TabIndex = 5;
            this.Library_Button.Text = "Library";
            this.Library_Button.UseVisualStyleBackColor = true;
            this.Library_Button.Click += new System.EventHandler(this.Library_Button_Click);
            // 
            // Home_Button
            // 
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.Home_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Home_Button.Location = new System.Drawing.Point(67, 27);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(89, 39);
            this.Home_Button.TabIndex = 6;
            this.Home_Button.Text = "Home";
            this.Home_Button.UseVisualStyleBackColor = true;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Steam_Settings
            // 
            this.Steam_Settings.AutoSize = true;
            this.Steam_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Steam_Settings.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steam_Settings.ForeColor = System.Drawing.Color.Silver;
            this.Steam_Settings.Location = new System.Drawing.Point(12, 8);
            this.Steam_Settings.Name = "Steam_Settings";
            this.Steam_Settings.Size = new System.Drawing.Size(45, 15);
            this.Steam_Settings.TabIndex = 7;
            this.Steam_Settings.Text = "Steam";
            this.Steam_Settings.Click += new System.EventHandler(this.Steam_Settings_Click);
            // 
            // Add_NewGame_Button
            // 
            this.Add_NewGame_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_NewGame_Button.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.Add_NewGame_Button.ForeColor = System.Drawing.Color.Silver;
            this.Add_NewGame_Button.Location = new System.Drawing.Point(15, 685);
            this.Add_NewGame_Button.Name = "Add_NewGame_Button";
            this.Add_NewGame_Button.Size = new System.Drawing.Size(104, 23);
            this.Add_NewGame_Button.TabIndex = 8;
            this.Add_NewGame_Button.Text = "Add a Game";
            this.Add_NewGame_Button.UseVisualStyleBackColor = true;
            this.Add_NewGame_Button.Click += new System.EventHandler(this.Add_NewGame_Button_Click);
            // 
            // ActivateProductPanel
            // 
            this.ActivateProductPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(123)))));
            this.ActivateProductPanel.Controls.Add(this.panel1);
            this.ActivateProductPanel.Location = new System.Drawing.Point(0, 0);
            this.ActivateProductPanel.Name = "ActivateProductPanel";
            this.ActivateProductPanel.Size = new System.Drawing.Size(1048, 759);
            this.ActivateProductPanel.TabIndex = 0;
            this.ActivateProductPanel.Visible = false;
            this.ActivateProductPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ActivateProductPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Acctivati_Close);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.KeyExample);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ActivateDialib_X);
            this.panel1.Location = new System.Drawing.Point(180, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 342);
            this.panel1.TabIndex = 0;
            // 
            // Acctivati_Close
            // 
            this.Acctivati_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acctivati_Close.Location = new System.Drawing.Point(556, 294);
            this.Acctivati_Close.Name = "Acctivati_Close";
            this.Acctivati_Close.Size = new System.Drawing.Size(100, 23);
            this.Acctivati_Close.TabIndex = 5;
            this.Acctivati_Close.Text = "Redeem";
            this.Acctivati_Close.UseVisualStyleBackColor = true;
            this.Acctivati_Close.Click += new System.EventHandler(this.Acctivati_Close_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(23, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 30);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // KeyExample
            // 
            this.KeyExample.AutoSize = true;
            this.KeyExample.BackColor = System.Drawing.Color.Transparent;
            this.KeyExample.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyExample.ForeColor = System.Drawing.Color.Silver;
            this.KeyExample.Location = new System.Drawing.Point(20, 145);
            this.KeyExample.Name = "KeyExample";
            this.KeyExample.Size = new System.Drawing.Size(254, 48);
            this.KeyExample.TabIndex = 2;
            this.KeyExample.Text = "ABCDE-FGHJK-LMNOP-QRSTU-VWXYZ\r\nABCDE-FGHJK-LMNOP\r\nRYTV-0730-ABCD(ASTA MERGE CUMVA" +
    ")";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "M am voie sa activez pe steam chiar asa ;(";
            // 
            // ActivateDialib_X
            // 
            this.ActivateDialib_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivateDialib_X.Location = new System.Drawing.Point(632, 17);
            this.ActivateDialib_X.Name = "ActivateDialib_X";
            this.ActivateDialib_X.Size = new System.Drawing.Size(24, 23);
            this.ActivateDialib_X.TabIndex = 0;
            this.ActivateDialib_X.Text = "X";
            this.ActivateDialib_X.UseVisualStyleBackColor = true;
            this.ActivateDialib_X.Click += new System.EventHandler(this.ActivateDialib_X_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:/Program Files (x86)/Steam/config/avatarcache/+User.UserID+.png";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UserProfile_Putton
            // 
            this.UserProfile_Putton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserProfile_Putton.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.UserProfile_Putton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UserProfile_Putton.Location = new System.Drawing.Point(478, 27);
            this.UserProfile_Putton.Name = "UserProfile_Putton";
            this.UserProfile_Putton.Size = new System.Drawing.Size(152, 39);
            this.UserProfile_Putton.TabIndex = 10;
            this.UserProfile_Putton.Text = "User.UserName";
            this.UserProfile_Putton.UseVisualStyleBackColor = true;
            this.UserProfile_Putton.Click += new System.EventHandler(this.UserProfile_Putton_Click);
            this.UserProfile_Putton.MouseLeave += new System.EventHandler(this.UserProbileButton_Stophold);
            this.UserProfile_Putton.MouseHover += new System.EventHandler(this.UserProbileButton_Hold);
            // 
            // UserButton_SubPanel
            // 
            this.UserButton_SubPanel.Controls.Add(this.Activity_User);
            this.UserButton_SubPanel.Controls.Add(this.UserButton_Subbut_YEAR);
            this.UserButton_SubPanel.Location = new System.Drawing.Point(478, 63);
            this.UserButton_SubPanel.Name = "UserButton_SubPanel";
            this.UserButton_SubPanel.Size = new System.Drawing.Size(152, 129);
            this.UserButton_SubPanel.TabIndex = 11;
            // 
            // Activity_User
            // 
            this.Activity_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Activity_User.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_User.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Activity_User.Location = new System.Drawing.Point(0, 13);
            this.Activity_User.Name = "Activity_User";
            this.Activity_User.Size = new System.Drawing.Size(152, 39);
            this.Activity_User.TabIndex = 13;
            this.Activity_User.Text = "Activity";
            this.Activity_User.UseVisualStyleBackColor = true;
            this.Activity_User.Click += new System.EventHandler(this.Activity_User_Click);
            // 
            // UserButton_Subbut_YEAR
            // 
            this.UserButton_Subbut_YEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton_Subbut_YEAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserButton_Subbut_YEAR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UserButton_Subbut_YEAR.Location = new System.Drawing.Point(0, 58);
            this.UserButton_Subbut_YEAR.Name = "UserButton_Subbut_YEAR";
            this.UserButton_Subbut_YEAR.Size = new System.Drawing.Size(152, 39);
            this.UserButton_Subbut_YEAR.TabIndex = 12;
            this.UserButton_Subbut_YEAR.Text = "Year in review";
            this.UserButton_Subbut_YEAR.UseVisualStyleBackColor = true;
            this.UserButton_Subbut_YEAR.Click += new System.EventHandler(this.UserButton_Subbut_YEAR_Click);
            // 
            // Library_Panel
            // 
            this.Library_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Library_Panel.Controls.Add(this.GamePanel_Search);
            this.Library_Panel.Controls.Add(this.Library_SubPanel_GamePanel);
            this.Library_Panel.Controls.Add(this.LibraryPanel_Subpanel_Stanga);
            this.Library_Panel.Location = new System.Drawing.Point(0, 76);
            this.Library_Panel.Name = "Library_Panel";
            this.Library_Panel.Size = new System.Drawing.Size(1030, 599);
            this.Library_Panel.TabIndex = 1;
            // 
            // GamePanel_Search
            // 
            this.GamePanel_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.GamePanel_Search.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanel_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GamePanel_Search.Location = new System.Drawing.Point(4, 18);
            this.GamePanel_Search.Name = "GamePanel_Search";
            this.GamePanel_Search.Size = new System.Drawing.Size(238, 22);
            this.GamePanel_Search.TabIndex = 3;
            // 
            // Library_SubPanel_GamePanel
            // 
            this.Library_SubPanel_GamePanel.AutoScroll = true;
            this.Library_SubPanel_GamePanel.Controls.Add(this.SteamAPICracked);
            this.Library_SubPanel_GamePanel.Controls.Add(this.GamePanel_GameNews);
            this.Library_SubPanel_GamePanel.Controls.Add(this.label4);
            this.Library_SubPanel_GamePanel.Controls.Add(this.Gamepanel_screenshot);
            this.Library_SubPanel_GamePanel.Controls.Add(this.GamePanel_Friends);
            this.Library_SubPanel_GamePanel.Controls.Add(this.GamePanel_QuickButtons);
            this.Library_SubPanel_GamePanel.Controls.Add(this.label3);
            this.Library_SubPanel_GamePanel.Controls.Add(this.LastPlayed);
            this.Library_SubPanel_GamePanel.Controls.Add(this.Hours);
            this.Library_SubPanel_GamePanel.Controls.Add(this.Game_Hours);
            this.Library_SubPanel_GamePanel.Controls.Add(this.PlayButton);
            this.Library_SubPanel_GamePanel.Controls.Add(this.Game_Header);
            this.Library_SubPanel_GamePanel.Location = new System.Drawing.Point(248, 3);
            this.Library_SubPanel_GamePanel.Name = "Library_SubPanel_GamePanel";
            this.Library_SubPanel_GamePanel.Size = new System.Drawing.Size(779, 596);
            this.Library_SubPanel_GamePanel.TabIndex = 2;
            // 
            // GamePanel_GameNews
            // 
            this.GamePanel_GameNews.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel_GameNews.Location = new System.Drawing.Point(22, 462);
            this.GamePanel_GameNews.Name = "GamePanel_GameNews";
            this.GamePanel_GameNews.Size = new System.Drawing.Size(425, 303);
            this.GamePanel_GameNews.TabIndex = 10;
            this.GamePanel_GameNews.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_GameNews_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(469, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Friends who played before";
            // 
            // Gamepanel_screenshot
            // 
            this.Gamepanel_screenshot.Location = new System.Drawing.Point(22, 772);
            this.Gamepanel_screenshot.Name = "Gamepanel_screenshot";
            this.Gamepanel_screenshot.Size = new System.Drawing.Size(715, 424);
            this.Gamepanel_screenshot.TabIndex = 8;
            this.Gamepanel_screenshot.Paint += new System.Windows.Forms.PaintEventHandler(this.Gamepanel_screenshot_Paint);
            // 
            // GamePanel_Friends
            // 
            this.GamePanel_Friends.BackColor = System.Drawing.Color.DimGray;
            this.GamePanel_Friends.ForeColor = System.Drawing.Color.Transparent;
            this.GamePanel_Friends.Location = new System.Drawing.Point(469, 462);
            this.GamePanel_Friends.Name = "GamePanel_Friends";
            this.GamePanel_Friends.Size = new System.Drawing.Size(270, 218);
            this.GamePanel_Friends.TabIndex = 7;
            this.GamePanel_Friends.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Friends_Paint);
            // 
            // GamePanel_QuickButtons
            // 
            this.GamePanel_QuickButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.GamePanel_QuickButtons.Controls.Add(this.GamePanel_Support);
            this.GamePanel_QuickButtons.Controls.Add(this.GamePanel_Guides);
            this.GamePanel_QuickButtons.Controls.Add(this.GamePanel_Discussions);
            this.GamePanel_QuickButtons.Controls.Add(this.GamePanel_CominityHub);
            this.GamePanel_QuickButtons.Controls.Add(this.GamePanel_StoreButton);
            this.GamePanel_QuickButtons.Location = new System.Drawing.Point(22, 355);
            this.GamePanel_QuickButtons.Name = "GamePanel_QuickButtons";
            this.GamePanel_QuickButtons.Size = new System.Drawing.Size(715, 37);
            this.GamePanel_QuickButtons.TabIndex = 6;
            // 
            // GamePanel_Support
            // 
            this.GamePanel_Support.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamePanel_Support.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanel_Support.ForeColor = System.Drawing.Color.White;
            this.GamePanel_Support.Location = new System.Drawing.Point(546, 3);
            this.GamePanel_Support.Name = "GamePanel_Support";
            this.GamePanel_Support.Size = new System.Drawing.Size(79, 31);
            this.GamePanel_Support.TabIndex = 11;
            this.GamePanel_Support.Text = "Support";
            this.GamePanel_Support.UseVisualStyleBackColor = true;
            // 
            // GamePanel_Guides
            // 
            this.GamePanel_Guides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamePanel_Guides.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanel_Guides.ForeColor = System.Drawing.Color.White;
            this.GamePanel_Guides.Location = new System.Drawing.Point(447, 3);
            this.GamePanel_Guides.Name = "GamePanel_Guides";
            this.GamePanel_Guides.Size = new System.Drawing.Size(79, 31);
            this.GamePanel_Guides.TabIndex = 10;
            this.GamePanel_Guides.Text = "Guides";
            this.GamePanel_Guides.UseVisualStyleBackColor = true;
            // 
            // GamePanel_Discussions
            // 
            this.GamePanel_Discussions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamePanel_Discussions.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanel_Discussions.ForeColor = System.Drawing.Color.White;
            this.GamePanel_Discussions.Location = new System.Drawing.Point(293, 3);
            this.GamePanel_Discussions.Name = "GamePanel_Discussions";
            this.GamePanel_Discussions.Size = new System.Drawing.Size(132, 31);
            this.GamePanel_Discussions.TabIndex = 9;
            this.GamePanel_Discussions.Text = "Discussions";
            this.GamePanel_Discussions.UseVisualStyleBackColor = true;
            // 
            // GamePanel_CominityHub
            // 
            this.GamePanel_CominityHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamePanel_CominityHub.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanel_CominityHub.ForeColor = System.Drawing.Color.White;
            this.GamePanel_CominityHub.Location = new System.Drawing.Point(143, 3);
            this.GamePanel_CominityHub.Name = "GamePanel_CominityHub";
            this.GamePanel_CominityHub.Size = new System.Drawing.Size(132, 31);
            this.GamePanel_CominityHub.TabIndex = 8;
            this.GamePanel_CominityHub.Text = "Community Hub";
            this.GamePanel_CominityHub.UseVisualStyleBackColor = true;
            // 
            // GamePanel_StoreButton
            // 
            this.GamePanel_StoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamePanel_StoreButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanel_StoreButton.ForeColor = System.Drawing.Color.White;
            this.GamePanel_StoreButton.Location = new System.Drawing.Point(24, 3);
            this.GamePanel_StoreButton.Name = "GamePanel_StoreButton";
            this.GamePanel_StoreButton.Size = new System.Drawing.Size(101, 31);
            this.GamePanel_StoreButton.TabIndex = 7;
            this.GamePanel_StoreButton.Text = "Store";
            this.GamePanel_StoreButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(199, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tot nu stiu";
            // 
            // LastPlayed
            // 
            this.LastPlayed.AutoSize = true;
            this.LastPlayed.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPlayed.ForeColor = System.Drawing.Color.LightGray;
            this.LastPlayed.Location = new System.Drawing.Point(198, 298);
            this.LastPlayed.Name = "LastPlayed";
            this.LastPlayed.Size = new System.Drawing.Size(95, 20);
            this.LastPlayed.TabIndex = 4;
            this.LastPlayed.Text = "LAST PLAYED";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.ForeColor = System.Drawing.Color.LightGray;
            this.Hours.Location = new System.Drawing.Point(326, 318);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(46, 15);
            this.Hours.TabIndex = 3;
            this.Hours.Text = "Nu stiu";
            // 
            // Game_Hours
            // 
            this.Game_Hours.AutoSize = true;
            this.Game_Hours.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Hours.ForeColor = System.Drawing.Color.LightGray;
            this.Game_Hours.Location = new System.Drawing.Point(325, 298);
            this.Game_Hours.Name = "Game_Hours";
            this.Game_Hours.Size = new System.Drawing.Size(76, 20);
            this.Game_Hours.TabIndex = 2;
            this.Game_Hours.Text = "PLAY TIME";
            // 
            // PlayButton
            // 
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(4, 298);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(166, 40);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "sssss";
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // Game_Header
            // 
            this.Game_Header.Controls.Add(this.GamePanel_GameLogo);
            this.Game_Header.Location = new System.Drawing.Point(4, 3);
            this.Game_Header.Name = "Game_Header";
            this.Game_Header.Size = new System.Drawing.Size(755, 281);
            this.Game_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Game_Header.TabIndex = 0;
            this.Game_Header.TabStop = false;
            // 
            // GamePanel_GameLogo
            // 
            this.GamePanel_GameLogo.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel_GameLogo.Location = new System.Drawing.Point(18, 140);
            this.GamePanel_GameLogo.Name = "GamePanel_GameLogo";
            this.GamePanel_GameLogo.Size = new System.Drawing.Size(266, 130);
            this.GamePanel_GameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GamePanel_GameLogo.TabIndex = 7;
            this.GamePanel_GameLogo.TabStop = false;
            // 
            // LibraryPanel_Subpanel_Stanga
            // 
            this.LibraryPanel_Subpanel_Stanga.AutoScroll = true;
            this.LibraryPanel_Subpanel_Stanga.Location = new System.Drawing.Point(0, 45);
            this.LibraryPanel_Subpanel_Stanga.Name = "LibraryPanel_Subpanel_Stanga";
            this.LibraryPanel_Subpanel_Stanga.Size = new System.Drawing.Size(250, 551);
            this.LibraryPanel_Subpanel_Stanga.TabIndex = 1;
            // 
            // Help_Lable
            // 
            this.Help_Lable.AutoSize = true;
            this.Help_Lable.BackColor = System.Drawing.Color.Transparent;
            this.Help_Lable.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_Lable.ForeColor = System.Drawing.Color.Silver;
            this.Help_Lable.Location = new System.Drawing.Point(64, 8);
            this.Help_Lable.Name = "Help_Lable";
            this.Help_Lable.Size = new System.Drawing.Size(34, 15);
            this.Help_Lable.TabIndex = 12;
            this.Help_Lable.Text = "Help";
            this.Help_Lable.Click += new System.EventHandler(this.Help_Lable_Click);
            // 
            // Login_Lable
            // 
            this.Login_Lable.AutoSize = true;
            this.Login_Lable.BackColor = System.Drawing.Color.Transparent;
            this.Login_Lable.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Lable.ForeColor = System.Drawing.Color.Silver;
            this.Login_Lable.Location = new System.Drawing.Point(104, 8);
            this.Login_Lable.Name = "Login_Lable";
            this.Login_Lable.Size = new System.Drawing.Size(104, 15);
            this.Login_Lable.TabIndex = 13;
            this.Login_Lable.Text = "Login(Sila mare)";
            this.Login_Lable.Click += new System.EventHandler(this.Login_Lable_Click);
            // 
            // UserInfo_RightTop
            // 
            this.UserInfo_RightTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(112)))), ((int)(((byte)(123)))));
            this.UserInfo_RightTop.Controls.Add(this.pictureBox1);
            this.UserInfo_RightTop.Controls.Add(this.UserNameLabel);
            this.UserInfo_RightTop.Location = new System.Drawing.Point(785, 8);
            this.UserInfo_RightTop.Name = "UserInfo_RightTop";
            this.UserInfo_RightTop.Size = new System.Drawing.Size(134, 25);
            this.UserInfo_RightTop.TabIndex = 14;
            this.UserInfo_RightTop.Click += new System.EventHandler(this.UserInfo_RightTop_Paint);
            // 
            // FriendsButton
            // 
            this.FriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.FriendsButton.ForeColor = System.Drawing.Color.Silver;
            this.FriendsButton.Location = new System.Drawing.Point(916, 685);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(104, 23);
            this.FriendsButton.TabIndex = 15;
            this.FriendsButton.Text = "Friends";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // UrlLabelUpdater
            // 
            this.UrlLabelUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UrlLabelUpdater_DoWork);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.BackColor = System.Drawing.Color.Transparent;
            this.urlLabel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.ForeColor = System.Drawing.Color.Silver;
            this.urlLabel.Location = new System.Drawing.Point(228, 8);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(14, 15);
            this.urlLabel.TabIndex = 16;
            this.urlLabel.Text = "L";
            this.urlLabel.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // SteamAPICracked
            // 
            this.SteamAPICracked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteamAPICracked.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamAPICracked.ForeColor = System.Drawing.Color.White;
            this.SteamAPICracked.Location = new System.Drawing.Point(564, 298);
            this.SteamAPICracked.Name = "SteamAPICracked";
            this.SteamAPICracked.Size = new System.Drawing.Size(155, 31);
            this.SteamAPICracked.TabIndex = 12;
            this.SteamAPICracked.Text = "SteamAPI Unlocker";
            this.SteamAPICracked.UseVisualStyleBackColor = true;
            this.SteamAPICracked.Click += new System.EventHandler(this.SteamAPICracked_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1032, 720);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.UserInfo_RightTop);
            this.Controls.Add(this.Login_Lable);
            this.Controls.Add(this.Help_Lable);
            this.Controls.Add(this.Library_Panel);
            this.Controls.Add(this.ActivateProductPanel);
            this.Controls.Add(this.UserButton_SubPanel);
            this.Controls.Add(this.Add_NewGame_Button);
            this.Controls.Add(this.WebStorePanel);
            this.Controls.Add(this.Home_Button);
            this.Controls.Add(this.Library_Button);
            this.Controls.Add(this.Steam_Settings);
            this.Controls.Add(this.Community_Button);
            this.Controls.Add(this.UserProfile_Putton);
            this.MaximumSize = new System.Drawing.Size(1048, 759);
            this.MinimumSize = new System.Drawing.Size(1048, 759);
            this.Name = "MainWindow";
            this.Text = "Main";
            this.ActivateProductPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserButton_SubPanel.ResumeLayout(false);
            this.Library_Panel.ResumeLayout(false);
            this.Library_Panel.PerformLayout();
            this.Library_SubPanel_GamePanel.ResumeLayout(false);
            this.Library_SubPanel_GamePanel.PerformLayout();
            this.GamePanel_QuickButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Game_Header)).EndInit();
            this.Game_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel_GameLogo)).EndInit();
            this.UserInfo_RightTop.ResumeLayout(false);
            this.UserInfo_RightTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel WebStorePanel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button Community_Button;
        private System.Windows.Forms.Button Library_Button;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Label Steam_Settings;
        private System.Windows.Forms.Button Add_NewGame_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KeyExample;
        private System.Windows.Forms.Button Acctivati_Close;
        private System.Windows.Forms.Button UserProfile_Putton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel UserButton_SubPanel;
        private System.Windows.Forms.Button UserButton_Subbut_YEAR;
        private Panel Library_Panel;
        private Panel LibraryPanel_Subpanel_Stanga;
        private Panel Library_SubPanel_GamePanel;
        private Label Game_Hours;
        private Button PlayButton;
        private PictureBox Game_Header;
        private System.Windows.Forms.Panel ActivateProductPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ActivateDialib_X;
        private Button Activity_User;
        private Label label3;
        private Label LastPlayed;
        private Label Hours;
        private Panel GamePanel_QuickButtons;
        private Button GamePanel_StoreButton;
        private Button GamePanel_Guides;
        private Button GamePanel_Discussions;
        private Button GamePanel_CominityHub;
        private Button GamePanel_Support;
        private PictureBox GamePanel_GameLogo;
        private Label label4;
        private Panel Gamepanel_screenshot;
        private Panel GamePanel_Friends;
        private TextBox GamePanel_Search;
        private Label Help_Lable;
        private Label Login_Lable;
        private Panel UserInfo_RightTop;
        private Button FriendsButton;
        private Panel GamePanel_GameNews;
        private System.ComponentModel.BackgroundWorker UrlLabelUpdater;
        private Label urlLabel;
        private Button SteamAPICracked;
    }
}