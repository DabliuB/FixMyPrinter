namespace FixMyPrinter.Forms
{
    partial class frmLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicense));
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDisclaimerFooter = new System.Windows.Forms.Panel();
            this.txtLicense = new System.Windows.Forms.RichTextBox();
            this.pnlDisclaimerFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDisclaimerFooter
            // 
            resources.ApplyResources(this.pnlDisclaimerFooter, "pnlDisclaimerFooter");
            this.pnlDisclaimerFooter.Controls.Add(this.btnClose);
            this.pnlDisclaimerFooter.Name = "pnlDisclaimerFooter";
            // 
            // txtLicense
            // 
            this.txtLicense.BackColor = System.Drawing.SystemColors.Control;
            this.txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicense.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtLicense, "txtLicense");
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.TabStop = false;
            // 
            // frmLicense
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pnlDisclaimerFooter);
            this.Controls.Add(this.txtLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLicense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlDisclaimerFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDisclaimerFooter;
        private System.Windows.Forms.RichTextBox txtLicense;
    }
}