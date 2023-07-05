/* PROJETO: FixMyPrinter
 * AUTOR  : William Silva | unclWill
 * DATA   : 05/02/2022 (Criação) | Modificação: 05/07/2023
 * CONTATO: williamsilvajdf@gmail.com
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
