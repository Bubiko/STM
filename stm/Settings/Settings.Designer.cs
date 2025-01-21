using System.Windows.Forms;

namespace stm.Settings
{
    partial class Settings
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
        private void InitializeComponent(UserInfo.UserBasicInfo User_Settings)
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Settings_UserName = new System.Windows.Forms.Label();
            this.Settings_Pfp = new System.Windows.Forms.PictureBox();
            this.Settings_Account = new System.Windows.Forms.Button();
            this.Settings_Download = new System.Windows.Forms.Button();
            this.Settings_Cloud = new System.Windows.Forms.Button();
            this.Account_Panel = new System.Windows.Forms.Panel();
            this.VacButton = new System.Windows.Forms.Button();
            this.FundsButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Settings_ViewProfile = new System.Windows.Forms.Button();
            this.Download_Panel = new System.Windows.Forms.Panel();
            this.ClearCacheButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ClearChacheLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DownloadGameplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DownloadSpeed = new System.Windows.Forms.Label();
            this.LimitDownloadSpeed = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegionType = new System.Windows.Forms.Label();
            this.RegionLable = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.Cloud_Panel = new System.Windows.Forms.Panel();
            this.CloudLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_Pfp)).BeginInit();
            this.Account_Panel.SuspendLayout();
            this.Download_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.Cloud_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings_UserName
            // 
            this.Settings_UserName.AutoSize = true;
            this.Settings_UserName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.Settings_UserName.ForeColor = System.Drawing.Color.Silver;
            this.Settings_UserName.Location = new System.Drawing.Point(102, 29);
            this.Settings_UserName.Name = "Settings_UserName";
            this.Settings_UserName.Size = new System.Drawing.Size(46, 20);
            this.Settings_UserName.TabIndex = 1;
            this.Settings_UserName.Text = User_Settings.UserName;
            // 
            // Settings_Pfp
            // 
            this.Settings_Pfp.ImageLocation = "C:/Program Files (x86)/Steam/config/avatarcache/" + User_Settings.UserID+".png";
            this.Settings_Pfp.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Settings_Pfp.Location = new System.Drawing.Point(30, 28);
            this.Settings_Pfp.Name = "Settings_Pfp";
            this.Settings_Pfp.Size = new System.Drawing.Size(62, 62);
            this.Settings_Pfp.TabIndex = 2;
            this.Settings_Pfp.TabStop = false;
            // 
            // Settings_Account
            // 
            this.Settings_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Account.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Account.ForeColor = System.Drawing.Color.LightGray;
            this.Settings_Account.Location = new System.Drawing.Point(0, 49);
            this.Settings_Account.Name = "Settings_Account";
            this.Settings_Account.Size = new System.Drawing.Size(110, 42);
            this.Settings_Account.TabIndex = 4;
            this.Settings_Account.Text = "Account";
            this.Settings_Account.UseVisualStyleBackColor = true;
            this.Settings_Account.Click += new System.EventHandler(this.Settings_Account_Click);
            // 
            // Settings_Download
            // 
            this.Settings_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Download.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.Settings_Download.ForeColor = System.Drawing.Color.LightGray;
            this.Settings_Download.Location = new System.Drawing.Point(0, 97);
            this.Settings_Download.Name = "Settings_Download";
            this.Settings_Download.Size = new System.Drawing.Size(110, 42);
            this.Settings_Download.TabIndex = 5;
            this.Settings_Download.Text = "Download";
            this.Settings_Download.UseVisualStyleBackColor = true;
            this.Settings_Download.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings_Cloud
            // 
            this.Settings_Cloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Cloud.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.Settings_Cloud.ForeColor = System.Drawing.Color.LightGray;
            this.Settings_Cloud.Location = new System.Drawing.Point(0, 145);
            this.Settings_Cloud.Name = "Settings_Cloud";
            this.Settings_Cloud.Size = new System.Drawing.Size(110, 42);
            this.Settings_Cloud.TabIndex = 6;
            this.Settings_Cloud.Text = "Cloud";
            this.Settings_Cloud.UseVisualStyleBackColor = true;
            this.Settings_Cloud.Click += new System.EventHandler(this.Settings_Cloud_Click);
            // 
            // Account_Panel
            // 
            this.Account_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.Account_Panel.Controls.Add(this.VacButton);
            this.Account_Panel.Controls.Add(this.FundsButton);
            this.Account_Panel.Controls.Add(this.Status);
            this.Account_Panel.Controls.Add(this.panel1);
            this.Account_Panel.Controls.Add(this.Settings_ViewProfile);
            this.Account_Panel.Controls.Add(this.Settings_UserName);
            this.Account_Panel.Controls.Add(this.Settings_Pfp);
            this.Account_Panel.Location = new System.Drawing.Point(116, 49);
            this.Account_Panel.Name = "Account_Panel";
            this.Account_Panel.Size = new System.Drawing.Size(424, 514);
            this.Account_Panel.TabIndex = 8;
            // 
            // VacButton
            // 
            this.VacButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VacButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.VacButton.ForeColor = System.Drawing.Color.LightGray;
            this.VacButton.Location = new System.Drawing.Point(279, 161);
            this.VacButton.Name = "VacButton";
            this.VacButton.Size = new System.Drawing.Size(120, 120);
            this.VacButton.TabIndex = 7;
            this.VacButton.Text = "VAC\r\n\r\n\r\nNush daca ai";
            this.VacButton.UseVisualStyleBackColor = true;
            // 
            // FundsButton
            // 
            this.FundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FundsButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.FundsButton.ForeColor = System.Drawing.Color.LightGray;
            this.FundsButton.Location = new System.Drawing.Point(30, 161);
            this.FundsButton.Name = "FundsButton";
            this.FundsButton.Size = new System.Drawing.Size(120, 120);
            this.FundsButton.TabIndex = 6;
            this.FundsButton.Text = "Funds\r\n\r\n\r\n$idk!?";
            this.FundsButton.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Silver;
            this.Status.Location = new System.Drawing.Point(101, 58);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(158, 20);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status : De unde sa stiu?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(30, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 5);
            this.panel1.TabIndex = 4;
            // 
            // Settings_ViewProfile
            // 
            this.Settings_ViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_ViewProfile.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.Settings_ViewProfile.ForeColor = System.Drawing.Color.LightGray;
            this.Settings_ViewProfile.Location = new System.Drawing.Point(280, 58);
            this.Settings_ViewProfile.Name = "Settings_ViewProfile";
            this.Settings_ViewProfile.Size = new System.Drawing.Size(119, 32);
            this.Settings_ViewProfile.TabIndex = 3;
            this.Settings_ViewProfile.Text = "View Profile";
            this.Settings_ViewProfile.UseVisualStyleBackColor = true;
            this.Settings_ViewProfile.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Download_Panel
            // 
            this.Download_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.Download_Panel.Controls.Add(this.ClearCacheButton);
            this.Download_Panel.Controls.Add(this.label2);
            this.Download_Panel.Controls.Add(this.label7);
            this.Download_Panel.Controls.Add(this.panel5);
            this.Download_Panel.Controls.Add(this.ClearChacheLabel);
            this.Download_Panel.Controls.Add(this.panel4);
            this.Download_Panel.Controls.Add(this.DownloadGameplay);
            this.Download_Panel.Controls.Add(this.label4);
            this.Download_Panel.Controls.Add(this.DownloadSpeed);
            this.Download_Panel.Controls.Add(this.LimitDownloadSpeed);
            this.Download_Panel.Controls.Add(this.panel2);
            this.Download_Panel.Controls.Add(this.RegionType);
            this.Download_Panel.Controls.Add(this.RegionLable);
            this.Download_Panel.Location = new System.Drawing.Point(116, 49);
            this.Download_Panel.Name = "Download_Panel";
            this.Download_Panel.Size = new System.Drawing.Size(424, 514);
            this.Download_Panel.TabIndex = 9;
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCacheButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCacheButton.ForeColor = System.Drawing.Color.LightGray;
            this.ClearCacheButton.Location = new System.Drawing.Point(301, 259);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(75, 38);
            this.ClearCacheButton.TabIndex = 17;
            this.ClearCacheButton.Text = "Clear cache";
            this.ClearCacheButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(29, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apesi aci poate se descarca jocu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(28, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Shader ceva sila";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(32, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 5);
            this.panel5.TabIndex = 14;
            // 
            // ClearChacheLabel
            // 
            this.ClearChacheLabel.AutoSize = true;
            this.ClearChacheLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.ClearChacheLabel.ForeColor = System.Drawing.Color.Silver;
            this.ClearChacheLabel.Location = new System.Drawing.Point(28, 259);
            this.ClearChacheLabel.Name = "ClearChacheLabel";
            this.ClearChacheLabel.Size = new System.Drawing.Size(143, 20);
            this.ClearChacheLabel.TabIndex = 12;
            this.ClearChacheLabel.Text = "Clear download cache";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(32, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 5);
            this.panel4.TabIndex = 11;
            // 
            // DownloadGameplay
            // 
            this.DownloadGameplay.AutoSize = true;
            this.DownloadGameplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.DownloadGameplay.ForeColor = System.Drawing.Color.Silver;
            this.DownloadGameplay.Location = new System.Drawing.Point(327, 154);
            this.DownloadGameplay.Name = "DownloadGameplay";
            this.DownloadGameplay.Size = new System.Drawing.Size(26, 20);
            this.DownloadGameplay.TabIndex = 10;
            this.DownloadGameplay.Text = "Nu";
            this.DownloadGameplay.Click += new System.EventHandler(this.DownloadGameplay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Allow download druing gameplay";
            // 
            // DownloadSpeed
            // 
            this.DownloadSpeed.AutoSize = true;
            this.DownloadSpeed.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.DownloadSpeed.ForeColor = System.Drawing.Color.Silver;
            this.DownloadSpeed.Location = new System.Drawing.Point(327, 118);
            this.DownloadSpeed.Name = "DownloadSpeed";
            this.DownloadSpeed.Size = new System.Drawing.Size(26, 20);
            this.DownloadSpeed.TabIndex = 7;
            this.DownloadSpeed.Text = "Nu";
            this.DownloadSpeed.Click += new System.EventHandler(this.DownloadSpeed_Click);
            // 
            // LimitDownloadSpeed
            // 
            this.LimitDownloadSpeed.AutoSize = true;
            this.LimitDownloadSpeed.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.LimitDownloadSpeed.ForeColor = System.Drawing.Color.Silver;
            this.LimitDownloadSpeed.Location = new System.Drawing.Point(28, 118);
            this.LimitDownloadSpeed.Name = "LimitDownloadSpeed";
            this.LimitDownloadSpeed.Size = new System.Drawing.Size(143, 20);
            this.LimitDownloadSpeed.TabIndex = 6;
            this.LimitDownloadSpeed.Text = "Limit download speed";
            this.LimitDownloadSpeed.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(32, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 5);
            this.panel2.TabIndex = 5;
            // 
            // RegionType
            // 
            this.RegionType.AutoSize = true;
            this.RegionType.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.RegionType.ForeColor = System.Drawing.Color.Silver;
            this.RegionType.Location = new System.Drawing.Point(278, 44);
            this.RegionType.Name = "RegionType";
            this.RegionType.Size = new System.Drawing.Size(122, 20);
            this.RegionType.TabIndex = 3;
            this.RegionType.Text = "Nu stiu sa fac d ala";
            // 
            // RegionLable
            // 
            this.RegionLable.AutoSize = true;
            this.RegionLable.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.RegionLable.ForeColor = System.Drawing.Color.Silver;
            this.RegionLable.Location = new System.Drawing.Point(28, 44);
            this.RegionLable.Name = "RegionLable";
            this.RegionLable.Size = new System.Drawing.Size(113, 20);
            this.RegionLable.TabIndex = 2;
            this.RegionLable.Text = "Download region";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Cloud_Panel
            // 
            this.Cloud_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.Cloud_Panel.Controls.Add(this.CloudLabel);
            this.Cloud_Panel.Location = new System.Drawing.Point(116, 49);
            this.Cloud_Panel.Name = "Cloud_Panel";
            this.Cloud_Panel.Size = new System.Drawing.Size(424, 514);
            this.Cloud_Panel.TabIndex = 18;
            // 
            // CloudLabel
            // 
            this.CloudLabel.AutoSize = true;
            this.CloudLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.CloudLabel.ForeColor = System.Drawing.Color.LightGray;
            this.CloudLabel.Location = new System.Drawing.Point(180, 27);
            this.CloudLabel.Name = "CloudLabel";
            this.CloudLabel.Size = new System.Drawing.Size(85, 18);
            this.CloudLabel.TabIndex = 0;
            this.CloudLabel.Text = "Nu e cloud";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(552, 575);
            this.ControlBox = true;
            this.Controls.Add(this.Account_Panel);
            this.Controls.Add(this.Cloud_Panel);
            this.Controls.Add(this.Settings_Cloud);
            this.Controls.Add(this.Settings_Download);
            this.Controls.Add(this.Settings_Account);
            this.Controls.Add(this.Download_Panel);
            this.MaximumSize = new System.Drawing.Size(568, 614);
            this.MinimumSize = new System.Drawing.Size(568, 614);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Settings_Pfp)).EndInit();
            this.Account_Panel.ResumeLayout(false);
            this.Account_Panel.PerformLayout();
            this.Download_Panel.ResumeLayout(false);
            this.Download_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.Cloud_Panel.ResumeLayout(false);
            this.Cloud_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosing += Form1_FormClosing;

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Settings_UserName;
        private System.Windows.Forms.PictureBox Settings_Pfp;
        private System.Windows.Forms.Button Settings_Account;
        private System.Windows.Forms.Button Settings_Download;
        private System.Windows.Forms.Button Settings_Cloud;
        private System.Windows.Forms.Panel Account_Panel;
        private System.Windows.Forms.Panel Download_Panel;
        private System.Windows.Forms.Button Settings_ViewProfile;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button VacButton;
        private System.Windows.Forms.Button FundsButton;
        private System.Windows.Forms.Label RegionLable;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ClearChacheLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DownloadGameplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DownloadSpeed;
        private System.Windows.Forms.Label LimitDownloadSpeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RegionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearCacheButton;
        private System.Windows.Forms.Panel Cloud_Panel;
        private System.Windows.Forms.Label CloudLabel;
    }
}