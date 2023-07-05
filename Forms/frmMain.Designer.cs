namespace FixMyPrinter
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpFixPrinter = new System.Windows.Forms.TabPage();
            this.gpbFixPrinter = new System.Windows.Forms.GroupBox();
            this.lblSpoolerFilesCleaned = new System.Windows.Forms.Label();
            this.btnFixPrinter = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tpDownloadDrivers = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadDriversCanon = new System.Windows.Forms.Button();
            this.btnDownloadDriversXerox = new System.Windows.Forms.Button();
            this.btnDownloadDriversEpson = new System.Windows.Forms.Button();
            this.btnDownloadHPDrivers = new System.Windows.Forms.Button();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnLicense = new System.Windows.Forms.Button();
            this.btnDisclaimer = new System.Windows.Forms.Button();
            this.lblAboutProjectRepoLink = new System.Windows.Forms.LinkLabel();
            this.lblGitHubRepo = new System.Windows.Forms.Label();
            this.pbAboutLinkedinProfile = new System.Windows.Forms.PictureBox();
            this.lblDeveloperName = new System.Windows.Forms.Label();
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblServiceState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrServiceMonitor = new System.Windows.Forms.Timer(this.components);
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.cboLanguageSelection = new System.Windows.Forms.ComboBox();
            this.tabMain.SuspendLayout();
            this.tpFixPrinter.SuspendLayout();
            this.gpbFixPrinter.SuspendLayout();
            this.tpDownloadDrivers.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutLinkedinProfile)).BeginInit();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Controls.Add(this.tpFixPrinter);
            this.tabMain.Controls.Add(this.tpDownloadDrivers);
            this.tabMain.Controls.Add(this.tpAbout);
            this.tabMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            // 
            // tpFixPrinter
            // 
            resources.ApplyResources(this.tpFixPrinter, "tpFixPrinter");
            this.tpFixPrinter.Controls.Add(this.gpbFixPrinter);
            this.tpFixPrinter.Controls.Add(this.lblHelp);
            this.tpFixPrinter.Controls.Add(this.btnHelp);
            this.tpFixPrinter.Name = "tpFixPrinter";
            this.tpFixPrinter.UseVisualStyleBackColor = true;
            // 
            // gpbFixPrinter
            // 
            resources.ApplyResources(this.gpbFixPrinter, "gpbFixPrinter");
            this.gpbFixPrinter.Controls.Add(this.lblSpoolerFilesCleaned);
            this.gpbFixPrinter.Controls.Add(this.btnFixPrinter);
            this.gpbFixPrinter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gpbFixPrinter.Name = "gpbFixPrinter";
            this.gpbFixPrinter.TabStop = false;
            // 
            // lblSpoolerFilesCleaned
            // 
            resources.ApplyResources(this.lblSpoolerFilesCleaned, "lblSpoolerFilesCleaned");
            this.lblSpoolerFilesCleaned.Name = "lblSpoolerFilesCleaned";
            // 
            // btnFixPrinter
            // 
            resources.ApplyResources(this.btnFixPrinter, "btnFixPrinter");
            this.btnFixPrinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFixPrinter.Image = global::FixMyPrinter.Properties.Resources.Apply;
            this.btnFixPrinter.Name = "btnFixPrinter";
            this.btnFixPrinter.UseVisualStyleBackColor = true;
            this.btnFixPrinter.Click += new System.EventHandler(this.btnFixPrinter_Click);
            // 
            // lblHelp
            // 
            resources.ApplyResources(this.lblHelp, "lblHelp");
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHelp.Name = "lblHelp";
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.Image = global::FixMyPrinter.Properties.Resources.Help;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tpDownloadDrivers
            // 
            resources.ApplyResources(this.tpDownloadDrivers, "tpDownloadDrivers");
            this.tpDownloadDrivers.Controls.Add(this.label1);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadDriversCanon);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadDriversXerox);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadDriversEpson);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadHPDrivers);
            this.tpDownloadDrivers.Name = "tpDownloadDrivers";
            this.tpDownloadDrivers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // btnDownloadDriversCanon
            // 
            resources.ApplyResources(this.btnDownloadDriversCanon, "btnDownloadDriversCanon");
            this.btnDownloadDriversCanon.Image = global::FixMyPrinter.Properties.Resources.LogoCANON;
            this.btnDownloadDriversCanon.Name = "btnDownloadDriversCanon";
            this.btnDownloadDriversCanon.UseVisualStyleBackColor = true;
            this.btnDownloadDriversCanon.Click += new System.EventHandler(this.btnDownloadDriversCanon_Click);
            // 
            // btnDownloadDriversXerox
            // 
            resources.ApplyResources(this.btnDownloadDriversXerox, "btnDownloadDriversXerox");
            this.btnDownloadDriversXerox.Image = global::FixMyPrinter.Properties.Resources.LogoXEROX;
            this.btnDownloadDriversXerox.Name = "btnDownloadDriversXerox";
            this.btnDownloadDriversXerox.UseVisualStyleBackColor = true;
            this.btnDownloadDriversXerox.Click += new System.EventHandler(this.btnDownloadDriversXerox_Click);
            // 
            // btnDownloadDriversEpson
            // 
            resources.ApplyResources(this.btnDownloadDriversEpson, "btnDownloadDriversEpson");
            this.btnDownloadDriversEpson.Image = global::FixMyPrinter.Properties.Resources.LogoEPSON;
            this.btnDownloadDriversEpson.Name = "btnDownloadDriversEpson";
            this.btnDownloadDriversEpson.UseVisualStyleBackColor = true;
            this.btnDownloadDriversEpson.Click += new System.EventHandler(this.btnDownloadDriversEpson_Click);
            // 
            // btnDownloadHPDrivers
            // 
            resources.ApplyResources(this.btnDownloadHPDrivers, "btnDownloadHPDrivers");
            this.btnDownloadHPDrivers.Image = global::FixMyPrinter.Properties.Resources.LogoHP1;
            this.btnDownloadHPDrivers.Name = "btnDownloadHPDrivers";
            this.btnDownloadHPDrivers.UseVisualStyleBackColor = true;
            this.btnDownloadHPDrivers.Click += new System.EventHandler(this.btnDownloadHPDrivers_Click);
            // 
            // tpAbout
            // 
            resources.ApplyResources(this.tpAbout, "tpAbout");
            this.tpAbout.Controls.Add(this.btnLicense);
            this.tpAbout.Controls.Add(this.btnDisclaimer);
            this.tpAbout.Controls.Add(this.lblAboutProjectRepoLink);
            this.tpAbout.Controls.Add(this.lblGitHubRepo);
            this.tpAbout.Controls.Add(this.pbAboutLinkedinProfile);
            this.tpAbout.Controls.Add(this.lblDeveloperName);
            this.tpAbout.Controls.Add(this.lblDevelopedBy);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // btnLicense
            // 
            resources.ApplyResources(this.btnLicense, "btnLicense");
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.UseVisualStyleBackColor = true;
            this.btnLicense.Click += new System.EventHandler(this.btnLicense_Click);
            // 
            // btnDisclaimer
            // 
            resources.ApplyResources(this.btnDisclaimer, "btnDisclaimer");
            this.btnDisclaimer.Name = "btnDisclaimer";
            this.btnDisclaimer.UseVisualStyleBackColor = true;
            this.btnDisclaimer.Click += new System.EventHandler(this.btnDisclaimer_Click);
            // 
            // lblAboutProjectRepoLink
            // 
            resources.ApplyResources(this.lblAboutProjectRepoLink, "lblAboutProjectRepoLink");
            this.lblAboutProjectRepoLink.Name = "lblAboutProjectRepoLink";
            this.lblAboutProjectRepoLink.TabStop = true;
            this.lblAboutProjectRepoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAboutProjectRepoLink_LinkClicked);
            // 
            // lblGitHubRepo
            // 
            resources.ApplyResources(this.lblGitHubRepo, "lblGitHubRepo");
            this.lblGitHubRepo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGitHubRepo.Name = "lblGitHubRepo";
            // 
            // pbAboutLinkedinProfile
            // 
            resources.ApplyResources(this.pbAboutLinkedinProfile, "pbAboutLinkedinProfile");
            this.pbAboutLinkedinProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAboutLinkedinProfile.Image = global::FixMyPrinter.Properties.Resources.AvatarLinkedin_MainDev;
            this.pbAboutLinkedinProfile.Name = "pbAboutLinkedinProfile";
            this.pbAboutLinkedinProfile.TabStop = false;
            this.pbAboutLinkedinProfile.Click += new System.EventHandler(this.pbAboutLinkedinProfile_Click);
            // 
            // lblDeveloperName
            // 
            resources.ApplyResources(this.lblDeveloperName, "lblDeveloperName");
            this.lblDeveloperName.Name = "lblDeveloperName";
            // 
            // lblDevelopedBy
            // 
            resources.ApplyResources(this.lblDevelopedBy, "lblDevelopedBy");
            this.lblDevelopedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            // 
            // btnMainExit
            // 
            resources.ApplyResources(this.btnMainExit, "btnMainExit");
            this.btnMainExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // stsStatus
            // 
            resources.ApplyResources(this.stsStatus, "stsStatus");
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServiceState,
            this.lblStatus});
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.SizingGrip = false;
            // 
            // lblServiceState
            // 
            resources.ApplyResources(this.lblServiceState, "lblServiceState");
            this.lblServiceState.Image = global::FixMyPrinter.Properties.Resources.Info;
            this.lblServiceState.Name = "lblServiceState";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            // 
            // tmrServiceMonitor
            // 
            this.tmrServiceMonitor.Tick += new System.EventHandler(this.tmrServiceMonitor_Tick);
            // 
            // lblAboutVersion
            // 
            resources.ApplyResources(this.lblAboutVersion, "lblAboutVersion");
            this.lblAboutVersion.Name = "lblAboutVersion";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // cboLanguageSelection
            // 
            resources.ApplyResources(this.cboLanguageSelection, "cboLanguageSelection");
            this.cboLanguageSelection.FormattingEnabled = true;
            this.cboLanguageSelection.Items.AddRange(new object[] {
            resources.GetString("cboLanguageSelection.Items"),
            resources.GetString("cboLanguageSelection.Items1")});
            this.cboLanguageSelection.Name = "cboLanguageSelection";
            this.cboLanguageSelection.SelectedIndexChanged += new System.EventHandler(this.cboLanguageSelection_SelectedIndexChanged);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnMainExit;
            this.Controls.Add(this.cboLanguageSelection);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.lblAboutVersion);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tpFixPrinter.ResumeLayout(false);
            this.tpFixPrinter.PerformLayout();
            this.gpbFixPrinter.ResumeLayout(false);
            this.gpbFixPrinter.PerformLayout();
            this.tpDownloadDrivers.ResumeLayout(false);
            this.tpDownloadDrivers.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutLinkedinProfile)).EndInit();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpFixPrinter;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnFixPrinter;
        private System.Windows.Forms.TabPage tpDownloadDrivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownloadDriversCanon;
        private System.Windows.Forms.Button btnDownloadDriversXerox;
        private System.Windows.Forms.Button btnDownloadDriversEpson;
        private System.Windows.Forms.Button btnDownloadHPDrivers;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Button btnDisclaimer;
        private System.Windows.Forms.LinkLabel lblAboutProjectRepoLink;
        private System.Windows.Forms.Label lblGitHubRepo;
        private System.Windows.Forms.PictureBox pbAboutLinkedinProfile;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.Label lblDevelopedBy;
        private System.Windows.Forms.Button btnMainExit;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblServiceState;
        private System.Windows.Forms.Timer tmrServiceMonitor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAboutVersion;
        private System.Windows.Forms.GroupBox gpbFixPrinter;
        private System.Windows.Forms.Label lblSpoolerFilesCleaned;
        private System.Windows.Forms.Button btnLicense;
        private System.Windows.Forms.ComboBox cboLanguageSelection;
    }
}

