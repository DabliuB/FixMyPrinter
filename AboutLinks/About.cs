/* PROJETO : FixMyPrinter
 * ARQUIVO : Classe About
 * OBJETIVO: Concentrar todos os links para redes sociais do desenvolvedor.
 * AUTOR   : William Silva - unclWill
 * DATA    : 05/07/2023 (Criação) | Modificação: 05/07/2023
 * CONTATO : williamsilvajdf@gmail.com
 */

using System;
using System.Diagnostics;
using System.Windows.Forms;
using FixMyPrinter.Globals;

namespace FixMyPrinter.AboutLinks
{
    internal class About
    {
        internal enum DeveloperLink
        {
            LinkedIn,
            GitHub
        }

        private static string SetDeveloperLink(DeveloperLink networkName)
        {
            string developerLink = string.Empty;

            switch (networkName)
            {
                case DeveloperLink.LinkedIn:
                    developerLink = Links._toLinkedIn;
                    break;
                case DeveloperLink.GitHub:
                    developerLink = Links._toGitHub;
                    break;
                default:
                    Console.WriteLine("Nenhum link válido foi encontrado!");
                    break;
            }
            return developerLink;
        }

        internal static void OpenExternalLink(DeveloperLink linkTo, string socialNetworkName = "")
        {
            string msg = "Deseja acessar o perfil do desenvolvedor no " + socialNetworkName + "?";
            const string caption = "Abrir link externo";
            dynamic dialogResult = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Process.Start(SetDeveloperLink(linkTo));
            }
        }
    }
}
