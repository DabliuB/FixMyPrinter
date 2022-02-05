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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnFixPrinter = new System.Windows.Forms.Button();
            this.tpDownloadDrivers = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnDisclaimer = new System.Windows.Forms.Button();
            this.lblAboutProjectRepoLink = new System.Windows.Forms.LinkLabel();
            this.lblGitHubRepo = new System.Windows.Forms.Label();
            this.pbAboutLinkedinProfile = new System.Windows.Forms.PictureBox();
            this.lblDeveloperName = new System.Windows.Forms.Label();
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            this.btnMainClose = new System.Windows.Forms.Button();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblServiceState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrServiceMonitor = new System.Windows.Forms.Timer(this.components);
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpFixPrinter.SuspendLayout();
            this.tpDownloadDrivers.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutLinkedinProfile)).BeginInit();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpFixPrinter);
            this.tabMain.Controls.Add(this.tpDownloadDrivers);
            this.tabMain.Controls.Add(this.tpAbout);
            this.tabMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(418, 345);
            this.tabMain.TabIndex = 1;
            // 
            // tpFixPrinter
            // 
            this.tpFixPrinter.Controls.Add(this.label3);
            this.tpFixPrinter.Controls.Add(this.label2);
            this.tpFixPrinter.Controls.Add(this.btnHelp);
            this.tpFixPrinter.Controls.Add(this.btnFixPrinter);
            this.tpFixPrinter.Location = new System.Drawing.Point(4, 26);
            this.tpFixPrinter.Name = "tpFixPrinter";
            this.tpFixPrinter.Padding = new System.Windows.Forms.Padding(3);
            this.tpFixPrinter.Size = new System.Drawing.Size(410, 315);
            this.tpFixPrinter.TabIndex = 0;
            this.tpFixPrinter.Text = "Corrigir impressora";
            this.tpFixPrinter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(81, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Se o procedimento acima não funcionou \r\n            clique no botão abaixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(49, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para tentar resolver problemas na fila de impressão\r\n                      clique" +
    " no botão abaixo";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = global::FixMyPrinter.Properties.Resources.Help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(78, 235);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(255, 35);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Ainda não consigo imprimir";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnFixPrinter
            // 
            this.btnFixPrinter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixPrinter.Image = global::FixMyPrinter.Properties.Resources.Apply;
            this.btnFixPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixPrinter.Location = new System.Drawing.Point(78, 70);
            this.btnFixPrinter.Name = "btnFixPrinter";
            this.btnFixPrinter.Size = new System.Drawing.Size(255, 62);
            this.btnFixPrinter.TabIndex = 0;
            this.btnFixPrinter.Text = "Tentar corrigir minha impressora";
            this.btnFixPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFixPrinter.UseVisualStyleBackColor = true;
            this.btnFixPrinter.Click += new System.EventHandler(this.btnFixPrinter_Click);
            // 
            // tpDownloadDrivers
            // 
            this.tpDownloadDrivers.Controls.Add(this.label1);
            this.tpDownloadDrivers.Controls.Add(this.button4);
            this.tpDownloadDrivers.Controls.Add(this.button3);
            this.tpDownloadDrivers.Controls.Add(this.button2);
            this.tpDownloadDrivers.Controls.Add(this.button1);
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
            this.label1.Location = new System.Drawing.Point(84, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Links rápidos para baixar os drivers das\r\nprincipais fabricantes de impressoras.";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(263, 41);
            this.button4.TabIndex = 0;
            this.button4.Text = "Baixar drivers Canon";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Baixar drivers Xerox";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Baixar drivers Epson";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Baixar drivers HP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.lblAboutVersion);
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
            // btnDisclaimer
            // 
            this.btnDisclaimer.Location = new System.Drawing.Point(157, 272);
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
            this.lblAboutProjectRepoLink.Size = new System.Drawing.Size(275, 17);
            this.lblAboutProjectRepoLink.TabIndex = 4;
            this.lblAboutProjectRepoLink.TabStop = true;
            this.lblAboutProjectRepoLink.Text = "https://github.com/pontiffex/FixMyPrinter";
            this.lblAboutProjectRepoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAboutProjectRepoLink_LinkClicked);
            // 
            // lblGitHubRepo
            // 
            this.lblGitHubRepo.AutoSize = true;
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
            this.lblDevelopedBy.Location = new System.Drawing.Point(150, 17);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(111, 17);
            this.lblDevelopedBy.TabIndex = 0;
            this.lblDevelopedBy.Text = "Desenvolvido por";
            // 
            // btnMainClose
            // 
            this.btnMainClose.Location = new System.Drawing.Point(10, 363);
            this.btnMainClose.Name = "btnMainClose";
            this.btnMainClose.Size = new System.Drawing.Size(420, 30);
            this.btnMainClose.TabIndex = 4;
            this.btnMainClose.Text = "Sair";
            this.btnMainClose.UseVisualStyleBackColor = true;
            this.btnMainClose.Click += new System.EventHandler(this.btnMainClose_Click);
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
            this.stsStatus.TabIndex = 3;
            this.stsStatus.Text = "statusStrip1";
            // 
            // lblServiceState
            // 
            this.lblServiceState.Name = "lblServiceState";
            this.lblServiceState.Size = new System.Drawing.Size(83, 17);
            this.lblServiceState.Text = "O serviço está:";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Status.";
            // 
            // tmrServiceMonitor
            // 
            this.tmrServiceMonitor.Tick += new System.EventHandler(this.tmrServiceMonitor_Tick);
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.AutoSize = true;
            this.lblAboutVersion.Location = new System.Drawing.Point(16, 287);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(51, 17);
            this.lblAboutVersion.TabIndex = 6;
            this.lblAboutVersion.Text = "Versão:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(68, 287);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 17);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "versão";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 425);
            this.Controls.Add(this.btnMainClose);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pontiffex | FixMyPrinter";
            this.tabMain.ResumeLayout(false);
            this.tpFixPrinter.ResumeLayout(false);
            this.tpFixPrinter.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnFixPrinter;
        private System.Windows.Forms.TabPage tpDownloadDrivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Button btnDisclaimer;
        private System.Windows.Forms.LinkLabel lblAboutProjectRepoLink;
        private System.Windows.Forms.Label lblGitHubRepo;
        private System.Windows.Forms.PictureBox pbAboutLinkedinProfile;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.Label lblDevelopedBy;
        private System.Windows.Forms.Button btnMainClose;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblServiceState;
        private System.Windows.Forms.Timer tmrServiceMonitor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAboutVersion;
    }
}

