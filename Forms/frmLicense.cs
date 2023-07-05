/* PROJETO: FixMyPrinter
 * AUTOR  : William Silva - unclWill
 * DATA   : 05/02/2022 (Criação) | Modificação: 05/07/2023
 * CONTATO: williamsilvajdf@gmail.com
 */

using System;
using System.Windows.Forms;

namespace FixMyPrinter.Forms
{
    public partial class frmLicense : Form
    {
        public frmLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
