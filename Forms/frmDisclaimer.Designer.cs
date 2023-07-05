namespace FixMyPrinter.Forms
{
    partial class frmDisclaimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisclaimer));
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDisclaimer = new System.Windows.Forms.RichTextBox();
            this.pnlDisclaimerFooter = new System.Windows.Forms.Panel();
            this.pnlDisclaimerFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDisclaimer
            // 
            resources.ApplyResources(this.txtDisclaimer, "txtDisclaimer");
            this.txtDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisclaimer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisclaimer.Name = "txtDisclaimer";
            this.txtDisclaimer.ReadOnly = true;
            this.txtDisclaimer.TabStop = false;
            // 
            // pnlDisclaimerFooter
            // 
            resources.ApplyResources(this.pnlDisclaimerFooter, "pnlDisclaimerFooter");
            this.pnlDisclaimerFooter.Controls.Add(this.btnClose);
            this.pnlDisclaimerFooter.Name = "pnlDisclaimerFooter";
            // 
            // frmDisclaimer
            // 
            this.AcceptButton = this.btnClose;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pnlDisclaimerFooter);
            this.Controls.Add(this.txtDisclaimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDisclaimer";
            this.ShowInTaskbar = false;
            this.pnlDisclaimerFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox txtDisclaimer;
        private System.Windows.Forms.Panel pnlDisclaimerFooter;
    }
}