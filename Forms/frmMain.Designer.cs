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
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tpFixPrinter);
            this.tabMain.Controls.Add(this.tpDownloadDrivers);
            this.tabMain.Controls.Add(this.tpAbout);
            this.tabMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(418, 345);
            this.tabMain.TabIndex = 0;
            // 
            // tpFixPrinter
            // 
            this.tpFixPrinter.Controls.Add(this.gpbFixPrinter);
            this.tpFixPrinter.Controls.Add(this.lblHelp);
            this.tpFixPrinter.Controls.Add(this.btnHelp);
            this.tpFixPrinter.Location = new System.Drawing.Point(4, 26);
            this.tpFixPrinter.Name = "tpFixPrinter";
            this.tpFixPrinter.Padding = new System.Windows.Forms.Padding(3);
            this.tpFixPrinter.Size = new System.Drawing.Size(410, 315);
            this.tpFixPrinter.TabIndex = 0;
            this.tpFixPrinter.Text = "Corrigir impressora";
            this.tpFixPrinter.UseVisualStyleBackColor = true;
            // 
            // gpbFixPrinter
            // 
            this.gpbFixPrinter.Controls.Add(this.lblSpoolerFilesCleaned);
            this.gpbFixPrinter.Controls.Add(this.btnFixPrinter);
            this.gpbFixPrinter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gpbFixPrinter.Location = new System.Drawing.Point(6, 33);
            this.gpbFixPrinter.Name = "gpbFixPrinter";
            this.gpbFixPrinter.Size = new System.Drawing.Size(398, 151);
            this.gpbFixPrinter.TabIndex = 0;
            this.gpbFixPrinter.TabStop = false;
            this.gpbFixPrinter.Text = "Resolver problemas com a fila de impressão";
            // 
            // lblSpoolerFilesCleaned
            // 
            this.lblSpoolerFilesCleaned.AutoSize = true;
            this.lblSpoolerFilesCleaned.Location = new System.Drawing.Point(80, 116);
            this.lblSpoolerFilesCleaned.Name = "lblSpoolerFilesCleaned";
            this.lblSpoolerFilesCleaned.Size = new System.Drawing.Size(239, 17);
            this.lblSpoolerFilesCleaned.TabIndex = 1;
            this.lblSpoolerFilesCleaned.Text = "SPOOLER_CLEANING_STATUS_MESSAGE";
            this.lblSpoolerFilesCleaned.Visible = false;
            // 
            // btnFixPrinter
            // 
            this.btnFixPrinter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixPrinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFixPrinter.Image = global::FixMyPrinter.Properties.Resources.Apply;
            this.btnFixPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixPrinter.Location = new System.Drawing.Point(44, 38);
            this.btnFixPrinter.Name = "btnFixPrinter";
            this.btnFixPrinter.Size = new System.Drawing.Size(310, 62);
            this.btnFixPrinter.TabIndex = 1;
            this.btnFixPrinter.Text = "Tentar corrigir minha impressora";
            this.btnFixPrinter.UseVisualStyleBackColor = true;
            this.btnFixPrinter.Click += new System.EventHandler(this.btnFixPrinter_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHelp.Location = new System.Drawing.Point(65, 210);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(281, 34);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "     Se o procedimento acima não funcionou \r\ntente seguir as dicas clicando no bo" +
    "tão abaixo";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = global::FixMyPrinter.Properties.Resources.Help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(50, 256);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(310, 35);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Ainda não consigo imprimir";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tpDownloadDrivers
            // 
            this.tpDownloadDrivers.Controls.Add(this.label1);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadDriversCanon);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadDriversXerox);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadDriversEpson);
            this.tpDownloadDrivers.Controls.Add(this.btnDownloadHPDrivers);
            this.tpDownloadDrivers.Location = new System.Drawing.Point(4, 26);
            this.tpDownloadDrivers.Name = "tpDownloadDrivers";
            this.tpDownloadDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.tpDownloadDrivers.Size = new System.Drawing.Size(410, 315);
            this.tpDownloadDrivers.TabIndex = 1;
            this.tpDownloadDrivers.Text = "Baixar drivers";
            this.tpDownloadDrivers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(84, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Links rápidos para baixar os drivers das\r\n principais fabricantes de impressoras." +
    "";
            // 
            // btnDownloadDriversCanon
            // 
            this.btnDownloadDriversCanon.Image = global::FixMyPrinter.Properties.Resources.LogoCANON;
            this.btnDownloadDriversCanon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadDriversCanon.Location = new System.Drawing.Point(74, 248);
            this.btnDownloadDriversCanon.Name = "btnDownloadDriversCanon";
            this.btnDownloadDriversCanon.Size = new System.Drawing.Size(263, 56);
            this.btnDownloadDriversCanon.TabIndex = 3;
            this.btnDownloadDriversCanon.Text = "Baixar drivers Canon";
            this.btnDownloadDriversCanon.UseVisualStyleBackColor = true;
            this.btnDownloadDriversCanon.Click += new System.EventHandler(this.btnDownloadDriversCanon_Click);
            // 
            // btnDownloadDriversXerox
            // 
            this.btnDownloadDriversXerox.Image = global::FixMyPrinter.Properties.Resources.LogoXEROX;
            this.btnDownloadDriversXerox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadDriversXerox.Location = new System.Drawing.Point(74, 186);
            this.btnDownloadDriversXerox.Name = "btnDownloadDriversXerox";
            this.btnDownloadDriversXerox.Size = new System.Drawing.Size(263, 56);
            this.btnDownloadDriversXerox.TabIndex = 2;
            this.btnDownloadDriversXerox.Text = "Baixar drivers Xerox";
            this.btnDownloadDriversXerox.UseVisualStyleBackColor = true;
            this.btnDownloadDriversXerox.Click += new System.EventHandler(this.btnDownloadDriversXerox_Click);
            // 
            // btnDownloadDriversEpson
            // 
            this.btnDownloadDriversEpson.Image = global::FixMyPrinter.Properties.Resources.LogoEPSON;
            this.btnDownloadDriversEpson.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadDriversEpson.Location = new System.Drawing.Point(74, 124);
            this.btnDownloadDriversEpson.Name = "btnDownloadDriversEpson";
            this.btnDownloadDriversEpson.Size = new System.Drawing.Size(263, 56);
            this.btnDownloadDriversEpson.TabIndex = 1;
            this.btnDownloadDriversEpson.Text = "Baixar drivers Epson";
            this.btnDownloadDriversEpson.UseVisualStyleBackColor = true;
            this.btnDownloadDriversEpson.Click += new System.EventHandler(this.btnDownloadDriversEpson_Click);
            // 
            // btnDownloadHPDrivers
            // 
            this.btnDownloadHPDrivers.Image = global::FixMyPrinter.Properties.Resources.LogoHP1;
            this.btnDownloadHPDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadHPDrivers.Location = new System.Drawing.Point(74, 62);
            this.btnDownloadHPDrivers.Name = "btnDownloadHPDrivers";
            this.btnDownloadHPDrivers.Size = new System.Drawing.Size(263, 56);
            this.btnDownloadHPDrivers.TabIndex = 0;
            this.btnDownloadHPDrivers.Text = "Baixar drivers HP";
            this.btnDownloadHPDrivers.UseVisualStyleBackColor = true;
            this.btnDownloadHPDrivers.Click += new System.EventHandler(this.btnDownloadHPDrivers_Click);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.btnLicense);
            this.tpAbout.Controls.Add(this.btnDisclaimer);
            this.tpAbout.Controls.Add(this.lblAboutProjectRepoLink);
            this.tpAbout.Controls.Add(this.lblGitHubRepo);
            this.tpAbout.Controls.Add(this.pbAboutLinkedinProfile);
            this.tpAbout.Controls.Add(this.lblDeveloperName);
            this.tpAbout.Controls.Add(this.lblDevelopedBy);
            this.tpAbout.Location = new System.Drawing.Point(4, 26);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(410, 315);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "Sobre";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // btnLicense
            // 
            this.btnLicense.Location = new System.Drawing.Point(208, 271);
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.Size = new System.Drawing.Size(96, 32);
            this.btnLicense.TabIndex = 6;
            this.btnLicense.Text = "Licença";
            this.btnLicense.UseVisualStyleBackColor = true;
            this.btnLicense.Click += new System.EventHandler(this.btnLicense_Click);
            // 
            // btnDisclaimer
            // 
            this.btnDisclaimer.Location = new System.Drawing.Point(106, 271);
            this.btnDisclaimer.Name = "btnDisclaimer";
            this.btnDisclaimer.Size = new System.Drawing.Size(96, 32);
            this.btnDisclaimer.TabIndex = 5;
            this.btnDisclaimer.Text = "Disclaimer";
            this.btnDisclaimer.UseVisualStyleBackColor = true;
            this.btnDisclaimer.Click += new System.EventHandler(this.btnDisclaimer_Click);
            // 
            // lblAboutProjectRepoLink
            // 
            this.lblAboutProjectRepoLink.AutoSize = true;
            this.lblAboutProjectRepoLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutProjectRepoLink.Location = new System.Drawing.Point(68, 231);
            this.lblAboutProjectRepoLink.Name = "lblAboutProjectRepoLink";
            this.lblAboutProjectRepoLink.Size = new System.Drawing.Size(267, 17);
            this.lblAboutProjectRepoLink.TabIndex = 4;
            this.lblAboutProjectRepoLink.TabStop = true;
            this.lblAboutProjectRepoLink.Text = "https://github.com/DabliuB/FixMyPrinter";
            this.lblAboutProjectRepoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAboutProjectRepoLink_LinkClicked);
            // 
            // lblGitHubRepo
            // 
            this.lblGitHubRepo.AutoSize = true;
            this.lblGitHubRepo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGitHubRepo.Location = new System.Drawing.Point(102, 207);
            this.lblGitHubRepo.Name = "lblGitHubRepo";
            this.lblGitHubRepo.Size = new System.Drawing.Size(206, 17);
            this.lblGitHubRepo.TabIndex = 3;
            this.lblGitHubRepo.Text = "Repositório do projeto no GitHub";
            // 
            // pbAboutLinkedinProfile
            // 
            this.pbAboutLinkedinProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAboutLinkedinProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAboutLinkedinProfile.Image = global::FixMyPrinter.Properties.Resources.AvatarLinkedin_MainDev;
            this.pbAboutLinkedinProfile.Location = new System.Drawing.Point(145, 70);
            this.pbAboutLinkedinProfile.Name = "pbAboutLinkedinProfile";
            this.pbAboutLinkedinProfile.Size = new System.Drawing.Size(120, 112);
            this.pbAboutLinkedinProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutLinkedinProfile.TabIndex = 2;
            this.pbAboutLinkedinProfile.TabStop = false;
            this.pbAboutLinkedinProfile.Click += new System.EventHandler(this.pbAboutLinkedinProfile_Click);
            // 
            // lblDeveloperName
            // 
            this.lblDeveloperName.AutoSize = true;
            this.lblDeveloperName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloperName.Location = new System.Drawing.Point(150, 44);
            this.lblDeveloperName.Name = "lblDeveloperName";
            this.lblDeveloperName.Size = new System.Drawing.Size(111, 21);
            this.lblDeveloperName.TabIndex = 1;
            this.lblDeveloperName.Text = "William Silva";
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.AutoSize = true;
            this.lblDevelopedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDevelopedBy.Location = new System.Drawing.Point(150, 17);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(111, 17);
            this.lblDevelopedBy.TabIndex = 0;
            this.lblDevelopedBy.Text = "Desenvolvido por";
            // 
            // btnMainExit
            // 
            this.btnMainExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainExit.Location = new System.Drawing.Point(10, 363);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(420, 30);
            this.btnMainExit.TabIndex = 3;
            this.btnMainExit.Text = "&Sair";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServiceState,
            this.lblStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 403);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(440, 22);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 7;
            this.stsStatus.Text = "statusStrip1";
            // 
            // lblServiceState
            // 
            this.lblServiceState.Image = global::FixMyPrinter.Properties.Resources.Info;
            this.lblServiceState.Name = "lblServiceState";
            this.lblServiceState.Size = new System.Drawing.Size(102, 17);
            this.lblServiceState.Text = " O serviço está:";
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.Text = "Status.";
            // 
            // tmrServiceMonitor
            // 
            this.tmrServiceMonitor.Tick += new System.EventHandler(this.tmrServiceMonitor_Tick);
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.AutoSize = true;
            this.lblAboutVersion.Enabled = false;
            this.lblAboutVersion.Location = new System.Drawing.Point(319, 405);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(51, 17);
            this.lblAboutVersion.TabIndex = 6;
            this.lblAboutVersion.Text = "Versão:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Enabled = false;
            this.lblVersion.Location = new System.Drawing.Point(367, 405);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 17);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "1.0.0.0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnMainExit;
            this.ClientSize = new System.Drawing.Size(440, 425);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.lblAboutVersion);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixMyPrinter | Limpar o spooler de impressão";
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
    }
}

