/* PROJETO : FixMyPrinter
 * ARQUIVO : Classe PrinterDriversLinks
 * OBJETIVO: Concentrar todos os links para download de drivers num único arquivo para evitar a repetição de código que acontecia anteriormente.
 * AUTOR   : William Silva - unclWill
 * DATA    : 05/07/2023 (Criação) | Modificação: 05/07/2023
 * CONTATO : williamsilvajdf@gmail.com
 */

using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace FixMyPrinter.Drivers
{
    internal class PrinterDriversLinks
    {
        internal enum PrinterBrand
        {
            Canon,
            Epson,
            HP,
            Xerox
        }

        private static string SetPrinterBrand(PrinterBrand brand)
        {
            string driverDowloadLink = string.Empty;

            switch (brand)
            {
                case PrinterBrand.Canon:
                    driverDowloadLink = "https://www.usa.canon.com/internet/portal/us/home/support/";
                    break;
                case PrinterBrand.Epson:
                    driverDowloadLink = "https://epson.com.br/Suporte/Impressoras/sh/s1";
                    break;
                case PrinterBrand.HP:
                    driverDowloadLink = "https://support.hp.com/br-pt/drivers/printers";
                    break;
                case PrinterBrand.Xerox:
                    driverDowloadLink = "https://www.support.xerox.com/pt-br/product/global-printer-driver/downloads?language=pt_BR";
                    break;
                default:
                    Console.WriteLine("Nenhum link válido foi encontrado!");
                    break;
            }
            return driverDowloadLink;
        }

        internal static void OpenDriverLink(PrinterBrand brand, string printerManufacturerName)
        {
            string msg = "Deseja acessar o site de download de drivers da " + printerManufacturerName + "?";
            const string caption = "Abrir link externo";
            dynamic dialogResult = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Process.Start(SetPrinterBrand(brand));
            }
        }
    }
}
