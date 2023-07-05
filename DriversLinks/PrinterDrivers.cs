/* PROJETO : FixMyPrinter
 * ARQUIVO : Classe PrinterDrivers
 * OBJETIVO: Concentrar todos os links para download de drivers num único arquivo para evitar a repetição de código que acontecia anteriormente.
 * AUTOR   : William Silva - unclWill
 * DATA    : 05/07/2023 (Criação) | Modificação: 05/07/2023
 * CONTATO : williamsilvajdf@gmail.com
 */

using System;
using System.Windows.Forms;
using System.Diagnostics;
using FixMyPrinter.Globals;

namespace FixMyPrinter.DriversLinks
{
    internal class PrinterDrivers
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
                    driverDowloadLink = Links._canonDrivers;
                    break;
                case PrinterBrand.Epson:
                    driverDowloadLink = Links._epsonDrivers;
                    break;
                case PrinterBrand.HP:
                    driverDowloadLink = Links._hpDrivers;
                    break;
                case PrinterBrand.Xerox:
                    driverDowloadLink = Links._xeroxDrivers;
                    break;
                default:
                    Console.WriteLine("Nenhum link válido foi encontrado!");
                    break;
            }
            return driverDowloadLink;
        }

        internal static void OpenDriverLink(PrinterBrand brand, string printerManufacturerName = "fabricante")
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
