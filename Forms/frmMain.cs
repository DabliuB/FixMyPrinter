/* PROJETO: FixMyPrinter
 * AUTOR  : William Silva - unclWill
 * DATA   : 05/02/2022 (Criação) | Modificação: 05/07/2023
 * CONTATO: williamsilvajdf@gmail.com
 */

using System;
using System.Windows.Forms;
using System.Security.Principal;
using System.ServiceProcess;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FixMyPrinter.Forms;
using System.Text;
using FixMyPrinter.DriversLinks;
using FixMyPrinter.AboutLinks;
using System.Threading;

namespace FixMyPrinter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowsRoleVerification();
            StartTimerServiceMonitor();
            lblVersion.Text = Application.ProductVersion;
        }

        private void cboLanguageSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboLanguageSelection.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                default:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
                    return;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        //Definindo o Spooler como o serviço alvo dos procedimentos.
        readonly ServiceController spooler = new ServiceController("Spooler");

        //Flag utilizada na verificação do status do serviço.
        private bool IsServiceDisabled = false;

        private static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        internal void WindowsRoleVerification()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Este programa precisa ser executado como Administrador!\n" +
                      "This program needs to be run as Administrator!");

            if (IsAdministrator() == false)
            {
                MessageBox.Show(sb.ToString(), "A operação requer elevação | This operation requires elevation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Text = "FixMyPrinter";

            }
            else
            {
                this.Text = "FixMyPrinter | Admin";
            }
        }

        #region Rotinas
        //Configurando o timer que verifica o status do serviço.
        private void StartTimerServiceMonitor()
        {
            tmrServiceMonitor.Interval = 300; //milissegundos
            tmrServiceMonitor.Tick += new EventHandler(tmrServiceMonitor_Tick);

            tmrServiceMonitor.Enabled = true;
        }
        //Definindo a tarefa que o timer deve executar.
        private void tmrServiceMonitor_Tick(object sender, EventArgs e)
        {
            ServiceMonitor();
        }
        //Rotina que define o status do serviço, o estado é exibido no radapé do programa.
        private void ServiceMonitor()
        {
            ServiceController spooler = new ServiceController("Spooler");

            if (spooler.Status == ServiceControllerStatus.Running)
            {
                lblStatus.Text = "em execução | running";
            }
            else if (spooler.Status == ServiceControllerStatus.Stopped)
            {
                lblStatus.Text = "parado | stopped";
            }
        }

        //Verifica o status do serviço.
        private void VerifyServiceStatus()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("O serviço está desativado, será necessário inicializá-lo manualmente!" +
                "Os serviços do Windows geralmente são exibidos em ordem alfabética, portanto procure pelos serviços inciados pela letra 'S' até encontrar o 'Spooler de Impressão', quando encontrar dê um duplo clique no serviço." +
                "Em 'Tipo de inicialização' escolha 'Automático', em 'Status do serviço' pressione o botão 'Iniciar'." +
                "O painel de gerenciamento de serviços irá ser exibido dentro de alguns segundos...");

            //Verificando se o serviço está parado
            if (spooler.StartType == ServiceStartMode.Disabled)
            {
                MessageBox.Show(sb.ToString(), "Aviso | Notice");
                //Abrindo o console de gerenciamento de serviços do Windows.
                Process.Start("services.msc");
                IsServiceDisabled = true;
            }
            else if (spooler.Status == ServiceControllerStatus.Stopped)
            {
                spooler.Start();
            }
        }
        //Verifica se existem arquivos no diretório.
        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
        //Limpar os arquivos do diretório do spooler de impressão manualmente.
        private void ClearFilesFromSpooler()
        {
            //Pega a letra da unidade na qual o Windows está instalado.
            string sysDrive = Path.GetPathRoot(Environment.SystemDirectory);

            if (IsDirectoryEmpty(sysDrive + @"Windows\System32\spool\PRINTERS") == false)
            {
                //Verifica o diretório do spooler por arquivos na fila e os deleta, se existirem.
                DirectoryInfo dirInfo = new DirectoryInfo(sysDrive + @"Windows\System32\spool\PRINTERS");

                foreach (FileInfo file in dirInfo.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo subDirectory in dirInfo.EnumerateDirectories())
                {
                    subDirectory.Delete(true);
                }

                lblSpoolerFilesCleaned.Visible = true;
                lblSpoolerFilesCleaned.ForeColor = System.Drawing.Color.ForestGreen;
                lblSpoolerFilesCleaned.Text = "Os arquivos do spooler foram limpos!\n" +
                                              "The spooler files have been cleaned!";
            }
            else
            {
                lblSpoolerFilesCleaned.Visible = true;
                lblSpoolerFilesCleaned.ForeColor = System.Drawing.Color.DarkGray;
                lblSpoolerFilesCleaned.Text = "Nenhum arquivo no spooler para limpar.\n" +
                                              "No files in the spooler to clean.";
            }
        }
        //Rotina que recarrega o serviço para limpar a fila de impressão.
        private void ReloadSpooler()
        {
            //Parando o serviço do spooler de impressão
            AutoClosingMessageBox.Show("Parando o serviço do Spooler de impressão...\n" +
                                       "Stopping the print spooler service...", "Status", 1300);
            spooler.Stop();

            //Limpa os arquivos do spooler, se existirem.
            ClearFilesFromSpooler();

            //Iniciando o serviço do Spooler de impressão
            AutoClosingMessageBox.Show("Reiniciando o serviço do Spooler de impressão...\n" +
                                       "Restarting the Print Spooler service...", "Status", 1300);
            spooler.Start();
            MessageBox.Show("Agora tudo deve funcionar corretamente!\n" +
                            "Now everything should work properly!\n\n" +
                            "Por favor, tente imprimir novamente.\n" +
                            "Please try printing again.", "Aviso | Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IsServiceDisabled = false;
        }
        //Faz a verificação do status do serviço e se o mesmo não estiver desativado executa a rotina de recarregamento do spooler de impressão.
        #endregion

        #region Eventos
        //Operação principal do programa.
        private void btnFixPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                VerifyServiceStatus();
                if (IsServiceDisabled == false)
                {
                    ReloadSpooler();
                }
            }
            catch (Exception ex)
            {
                const string errmsg = "Ocorreu um erro!" +
                                      "An error has occurred!";
                MessageBox.Show(ex.Message, errmsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Download de Drivers
        private void btnDownloadDriversEpson_Click(object sender, EventArgs e)
        {
            PrinterDrivers.OpenDriverLink(PrinterDrivers.PrinterBrand.Epson, "Epson");
        }

        private void btnDownloadHPDrivers_Click(object sender, EventArgs e)
        {
            PrinterDrivers.OpenDriverLink(PrinterDrivers.PrinterBrand.HP, "HP");
        }

        private void btnDownloadDriversXerox_Click(object sender, EventArgs e)
        {
            PrinterDrivers.OpenDriverLink(PrinterDrivers.PrinterBrand.Xerox, "Xerox");
        }

        private void btnDownloadDriversCanon_Click(object sender, EventArgs e)
        {
            PrinterDrivers.OpenDriverLink(PrinterDrivers.PrinterBrand.Canon, "Canon");
        }
        #endregion

        #region Redes sociais do desenvolvedor
        private void pbAboutLinkedinProfile_Click(object sender, EventArgs e)
        {
            About.OpenExternalLink(About.DeveloperLink.LinkedIn, "Linkedin");
        }
        private void lblAboutProjectRepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About.OpenExternalLink(About.DeveloperLink.GitHub, "GitHub");
        }
        #endregion

        #region Abrindo os outros Forms
        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp formHelp = new frmHelp();
            formHelp.ShowDialog();
        }
        //Exibe o formulário que contém os 'avisos legais' e os componentes de terceiros utilizados no projeto.
        private void btnDisclaimer_Click(object sender, EventArgs e)
        {
            frmDisclaimer formDisclaimer = new frmDisclaimer();
            formDisclaimer.ShowDialog();
        }
        //Exibe o formulário com a licença de uso do software.
        private void btnLicense_Click(object sender, EventArgs e)
        {
            frmLicense formLicense = new frmLicense();
            formLicense.ShowDialog();
        }
        #endregion

        //Encerrando a aplicação.
        private void btnMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}