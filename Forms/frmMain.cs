using System;
using System.Windows.Forms;
using System.Security.Principal;
using FixMyPrinter.Forms;
using System.ServiceProcess;
using System.Management;

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

        //Definindo o Spooler como o serviço alvo dos procedimentos
        ServiceController spooler = new ServiceController("Spooler");

        private void StartTimerServiceMonitor()
        {
            tmrServiceMonitor.Interval = 500;
            tmrServiceMonitor.Tick += new EventHandler(tmrServiceMonitor_Tick);

            tmrServiceMonitor.Enabled = true;
        }

        private void tmrServiceMonitor_Tick(object sender, EventArgs e)
        {
            ServiceMonitor();
        }

        private static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private void WindowsRoleVerification()
        {
            if (IsAdministrator() == true)
            {
                this.Text = "FixMyPrinter | Administrador";
            }
            else
            {
                MessageBox.Show("A manipulação de serviços do sistema exige que o programa seja executado " +
                    "por um usuário com privilégios administrativos.\n\n" +
                    "Clique com o botão direito do mouse no FixMyPrinter e depois clique em 'Executar como Administrador'.", "A operação requer elevação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Text = "FixMyPrinter";
            }
        }

        private void ServiceMonitor()
        {
            ServiceController spooler = new ServiceController("Spooler");

            if (spooler.Status == ServiceControllerStatus.Running)
            {
                lblStatus.Text = "sendo executado.";
            }
            else if (spooler.Status == ServiceControllerStatus.Stopped)
            {
                lblStatus.Text = "parado.";
            }
        }

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
                System.Diagnostics.Process.Start("services.msc");
            }
        }

        private void ReloadSpooler()
        {
            //Parando o serviço do spooler de impressão
            AutoClosingMessageBox.Show("Parando o serviço do Spooler de impressão...", "Status", 1300);
            spooler.Stop();
            //Iniciando o serviço do Spooler de impressão
            AutoClosingMessageBox.Show("Reiniciando o serviço do Spooler de impressão...", "Status", 1300);
            spooler.Start();
            MessageBox.Show("Agora tudo deve funcionar corretamente!\n" +
                            "Por favor, tente imprimir novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFixPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                VerifyServiceStatus();
                ReloadSpooler();
            }
            catch (Exception ex)
            {
                const string errmsg = "Ocorreu um erro!";
                MessageBox.Show(ex.Message, errmsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
