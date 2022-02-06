using System;
using System.Windows.Forms;
using System.Security.Principal;
using System.ServiceProcess;
using System.IO;
using System.Linq;
using FixMyPrinter.Forms;

namespace FixMyPrinter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            WindowsRoleVerification();
            StartTimerServiceMonitor();
            lblVersion.Text = Application.ProductVersion;
        }

        //Variáveis globais da classe.
        //Definindo o Spooler como o serviço alvo dos procedimentos.
        ServiceController spooler = new ServiceController("Spooler");
        //Flag utilizada na verificação do status do serviço.
        bool IsServiceDisabled = false;

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
                lblStatus.Text = "em execução.";
            }
            else if (spooler.Status == ServiceControllerStatus.Stopped)
            {
                lblStatus.Text = "parado.";
            }
        }
        //Retorna se o usuário atualmente logado é um Administrador do sistema.
        private static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
        //Se o usuário não for Admin exibe um aviso.
        private void WindowsRoleVerification()
        {
            if (IsAdministrator() == false)
            {
                MessageBox.Show("A manipulação de serviços do sistema exige que o programa seja executado " +
                                "por um usuário com privilégios administrativos.\n\n" +
                                "Clique com o botão direito do mouse no FixMyPrinter e depois clique em 'Executar como Administrador'.", "A operação requer elevação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Text = "FixMyPrinter";
                
            }
            else
            {
                this.Text = "FixMyPrinter | Administrador";
            }
        }
        //Verifica o status do serviço.
        private void VerifyServiceStatus()
        {
            //Verificando se o serviço está parado
            if (spooler.StartType == ServiceStartMode.Disabled)
            {
                MessageBox.Show("O serviço está desativado, será necessário inicializá-lo manualmente!\n\n" +
                                "Os serviços do Windows geralmente são exibidos em ordem alfabética,\n\n" +
                                "portanto procure pelos serviços inciados pela letra 'S' até encontrar o 'Spooler de Impressão', quando encontrar dê um duplo clique no serviço,\n\n" +
                                "Em 'Tipo de inicialização' escolha 'Automático', em 'Status do serviço' pressione o botão 'Iniciar'.\n\n\n" +
                                "O painel de gerenciamento de serviços irá ser exibido dentro de alguns segundos...", "Aviso");
                //Abrindo o console de gerenciamento de serviços do Windows.
                System.Diagnostics.Process.Start("services.msc");
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

        //Limpar os arquivos do spooler de impressão manualmente.
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
                lblSpoolerFilesCleaned.Text = "Os arquivos do spooler foram limpos!";
            }
            else
            {
                lblSpoolerFilesCleaned.Visible = true;
                lblSpoolerFilesCleaned.ForeColor = System.Drawing.Color.DarkGray;
                lblSpoolerFilesCleaned.Text = "Nenhum arquivo no spooler para limpar.";
            }
        }

        //Rotina que recarrega o serviço para limpar a fila de impressão.
        private void ReloadSpooler()
        {
            //Parando o serviço do spooler de impressão
            AutoClosingMessageBox.Show("Parando o serviço do Spooler de impressão...", "Status", 1300);
            spooler.Stop();

            //Limpa os arquivos do spooler, se existirem.
            ClearFilesFromSpooler();

            //Iniciando o serviço do Spooler de impressão
            AutoClosingMessageBox.Show("Reiniciando o serviço do Spooler de impressão...", "Status", 1300);
            spooler.Start();
            MessageBox.Show("Agora tudo deve funcionar corretamente!\n" +
                            "Por favor, tente imprimir novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IsServiceDisabled = false;
        }
        //Faz a verificação do status do serviço e se o mesmo não estiver desativado executa a rotina de recarregamento do spooler de impressão.
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
                const string errmsg = "Ocorreu um erro!";
                MessageBox.Show(ex.Message, errmsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Abre no navegador padrão do usuário uma página que exibe o LinkedIn e o GitHub do desenvolvedor do software.
        private void pbAboutLinkedinProfile_Click(object sender, EventArgs e)
        {
            const string msg = "Deseja acessar o perfil do desenvolvedor no LinkedIn?";
            const string caption = "Abrir link externo";
            dynamic dialogResult = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/williamsilvajf/");
            }
        }

        private void lblAboutProjectRepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string msg = "Deseja acessar o repositório do projeto no GitHub?";
            const string caption = "Abrir link externo";
            dynamic dialogResult = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/pontiffex/FixMyPrinter");
            }
        }

        //Exibindo os formulários adicionais.
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

        //Encerrando a aplicação.
        private void btnMainClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
