/* PROJETO: FixMyPrinter
 * AUTOR  : William Silva (pontiffex)
 * DATA   : 05/02/2022
 * CONTATO: wsilva@pontiffex.com.br
 */

using System;
using System.Windows.Forms;

namespace FixMyPrinter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
