/* PROJETO: FixMyPrinter
 * AUTOR  : William Silva (pontiffex)
 * DATA   : 05/02/2022
 * CONTATO: wsilva@pontiffex.com.br
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
