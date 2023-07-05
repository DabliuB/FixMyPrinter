/* PROJETO: FixMyPrinter
 * AUTOR  : William Silva - unclWill
 * DATA   : 05/02/2022 (Criação) | Modificação: 05/07/2023
 * CONTATO: williamsilvajdf@gmail.com
 */

using System;
using System.Windows.Forms;
using FixMyPrinter.Globals;

namespace FixMyPrinter.Forms
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnHelpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            txtHelpAlternative1.Text = TextDescriptions.ShowHelpAnternative1Description();
            txtHelpAlternative2.Text = TextDescriptions.ShowHelpAnternative2Description();
            txtHelpAlternative3.Text = TextDescriptions.ShowHelpAnternative3Description();
        }
    }
}
