namespace new_project
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.BtnInfo = new FontAwesome.Sharp.IconButton();
            this.BtnSettings = new FontAwesome.Sharp.IconButton();
            this.BtnCustomSer = new FontAwesome.Sharp.IconButton();
            this.BtnRenewal = new FontAwesome.Sharp.IconButton();
            this.BtnFines = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.BtnInfo);
            this.panelMenu.Controls.Add(this.BtnSettings);
            this.panelMenu.Controls.Add(this.BtnCustomSer);
            this.panelMenu.Controls.Add(this.BtnRenewal);
            this.panelMenu.Controls.Add(this.BtnFines);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 511);
            this.panelMenu.TabIndex = 0;
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.btnHome);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 140);
            this.panellogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.title);
            this.panelTitleBar.Controls.Add(this.iconCurrentChild);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(822, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.ForeColor = System.Drawing.Color.Orange;
            this.title.Location = new System.Drawing.Point(57, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(44, 16);
            this.title.TabIndex = 1;
            this.title.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(822, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(822, 427);
            this.panelDesktop.TabIndex = 3;
            // 
            // iconCurrentChild
            // 
            this.iconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChild.ForeColor = System.Drawing.Color.Orange;
            this.iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChild.IconColor = System.Drawing.Color.Orange;
            this.iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChild.IconSize = 41;
            this.iconCurrentChild.Location = new System.Drawing.Point(10, 12);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(41, 41);
            this.iconCurrentChild.TabIndex = 0;
            this.iconCurrentChild.TabStop = false;
            // 
            // BtnInfo
            // 
            this.BtnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnInfo.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.BtnInfo.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInfo.IconSize = 32;
            this.BtnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.Location = new System.Drawing.Point(0, 352);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnInfo.Size = new System.Drawing.Size(220, 53);
            this.BtnInfo.TabIndex = 5;
            this.BtnInfo.Text = "Info";
            this.BtnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.BtnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSettings.IconSize = 32;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.Location = new System.Drawing.Point(0, 299);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnSettings.Size = new System.Drawing.Size(220, 53);
            this.BtnSettings.TabIndex = 4;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnCustomSer
            // 
            this.BtnCustomSer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomSer.FlatAppearance.BorderSize = 0;
            this.BtnCustomSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomSer.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCustomSer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnCustomSer.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCustomSer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCustomSer.IconSize = 32;
            this.BtnCustomSer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomSer.Location = new System.Drawing.Point(0, 246);
            this.BtnCustomSer.Name = "BtnCustomSer";
            this.BtnCustomSer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCustomSer.Size = new System.Drawing.Size(220, 53);
            this.BtnCustomSer.TabIndex = 3;
            this.BtnCustomSer.Text = "Customer Service";
            this.BtnCustomSer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomSer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCustomSer.UseVisualStyleBackColor = true;
            this.BtnCustomSer.Click += new System.EventHandler(this.BtnCustomSer_Click);
            // 
            // BtnRenewal
            // 
            this.BtnRenewal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRenewal.FlatAppearance.BorderSize = 0;
            this.BtnRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRenewal.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnRenewal.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.BtnRenewal.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnRenewal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRenewal.IconSize = 32;
            this.BtnRenewal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRenewal.Location = new System.Drawing.Point(0, 193);
            this.BtnRenewal.Name = "BtnRenewal";
            this.BtnRenewal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnRenewal.Size = new System.Drawing.Size(220, 53);
            this.BtnRenewal.TabIndex = 2;
            this.BtnRenewal.Text = "Renew";
            this.BtnRenewal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRenewal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRenewal.UseVisualStyleBackColor = true;
            this.BtnRenewal.Click += new System.EventHandler(this.BtnRenewal_Click);
            // 
            // BtnFines
            // 
            this.BtnFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFines.FlatAppearance.BorderSize = 0;
            this.BtnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFines.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFines.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.BtnFines.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnFines.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFines.IconSize = 32;
            this.BtnFines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFines.Location = new System.Drawing.Point(0, 140);
            this.BtnFines.Name = "BtnFines";
            this.BtnFines.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnFines.Size = new System.Drawing.Size(220, 53);
            this.BtnFines.TabIndex = 1;
            this.BtnFines.Text = "Fines";
            this.BtnFines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFines.UseVisualStyleBackColor = true;
            this.BtnFines.Click += new System.EventHandler(this.BtnFines_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::new_project.Properties.Resources.ETS_no_bck;
            this.btnHome.Location = new System.Drawing.Point(0, -12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(224, 152);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1042, 511);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Egyptian Traffic Services";
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnFines;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton BtnInfo;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private FontAwesome.Sharp.IconButton BtnCustomSer;
        private FontAwesome.Sharp.IconButton BtnRenewal;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

