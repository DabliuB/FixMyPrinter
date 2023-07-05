namespace FixMyPrinter.Forms
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.txtHelpAlternative2 = new System.Windows.Forms.RichTextBox();
            this.lblHelpAlternative2 = new System.Windows.Forms.Label();
            this.txtHelpAlternative1 = new System.Windows.Forms.RichTextBox();
            this.lblHelpAlternative1 = new System.Windows.Forms.Label();
            this.btnHelpClose = new System.Windows.Forms.Button();
            this.pnlHelpFooter = new System.Windows.Forms.Panel();
            this.txtHelpAlternative3 = new System.Windows.Forms.RichTextBox();
            this.lblHelpAlternative3 = new System.Windows.Forms.Label();
            this.pbLogoHelp = new System.Windows.Forms.PictureBox();
            this.pnlHelpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHelpAlternative2
            // 
            resources.ApplyResources(this.txtHelpAlternative2, "txtHelpAlternative2");
            this.txtHelpAlternative2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHelpAlternative2.Name = "txtHelpAlternative2";
            this.txtHelpAlternative2.ReadOnly = true;
            this.txtHelpAlternative2.TabStop = false;
            // 
            // lblHelpAlternative2
            // 
            resources.ApplyResources(this.lblHelpAlternative2, "lblHelpAlternative2");
            this.lblHelpAlternative2.Name = "lblHelpAlternative2";
            // 
            // txtHelpAlternative1
            // 
            resources.ApplyResources(this.txtHelpAlternative1, "txtHelpAlternative1");
            this.txtHelpAlternative1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHelpAlternative1.Name = "txtHelpAlternative1";
            this.txtHelpAlternative1.ReadOnly = true;
            this.txtHelpAlternative1.TabStop = false;
            // 
            // lblHelpAlternative1
            // 
            resources.ApplyResources(this.lblHelpAlternative1, "lblHelpAlternative1");
            this.lblHelpAlternative1.Name = "lblHelpAlternative1";
            // 
            // btnHelpClose
            // 
            resources.ApplyResources(this.btnHelpClose, "btnHelpClose");
            this.btnHelpClose.Name = "btnHelpClose";
            this.btnHelpClose.UseVisualStyleBackColor = true;
            this.btnHelpClose.Click += new System.EventHandler(this.btnHelpClose_Click);
            // 
            // pnlHelpFooter
            // 
            resources.ApplyResources(this.pnlHelpFooter, "pnlHelpFooter");
            this.pnlHelpFooter.Controls.Add(this.btnHelpClose);
            this.pnlHelpFooter.Name = "pnlHelpFooter";
            // 
            // txtHelpAlternative3
            // 
            resources.ApplyResources(this.txtHelpAlternative3, "txtHelpAlternative3");
            this.txtHelpAlternative3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHelpAlternative3.Name = "txtHelpAlternative3";
            this.txtHelpAlternative3.ReadOnly = true;
            this.txtHelpAlternative3.TabStop = false;
            // 
            // lblHelpAlternative3
            // 
            resources.ApplyResources(this.lblHelpAlternative3, "lblHelpAlternative3");
            this.lblHelpAlternative3.Name = "lblHelpAlternative3";
            // 
            // pbLogoHelp
            // 
            resources.ApplyResources(this.pbLogoHelp, "pbLogoHelp");
            this.pbLogoHelp.Image = global::FixMyPrinter.Properties.Resources.Help;
            this.pbLogoHelp.Name = "pbLogoHelp";
            this.pbLogoHelp.TabStop = false;
            // 
            // frmHelp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLogoHelp);
            this.Controls.Add(this.txtHelpAlternative3);
            this.Controls.Add(this.lblHelpAlternative3);
            this.Controls.Add(this.pnlHelpFooter);
            this.Controls.Add(this.txtHelpAlternative2);
            this.Controls.Add(this.lblHelpAlternative2);
            this.Controls.Add(this.txtHelpAlternative1);
            this.Controls.Add(this.lblHelpAlternative1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHelp";
            this.ShowInTaskbar = false;
            this.pnlHelpFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHelpAlternative2;
        private System.Windows.Forms.Label lblHelpAlternative2;
        private System.Windows.Forms.RichTextBox txtHelpAlternative1;
        private System.Windows.Forms.Label lblHelpAlternative1;
        private System.Windows.Forms.Button btnHelpClose;
        private System.Windows.Forms.Panel pnlHelpFooter;
        private System.Windows.Forms.RichTextBox txtHelpAlternative3;
        private System.Windows.Forms.Label lblHelpAlternative3;
        private System.Windows.Forms.PictureBox pbLogoHelp;
    }
}