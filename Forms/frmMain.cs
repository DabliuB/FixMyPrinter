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
                MessageBox.Show("A manipualação de serviços do sistema exige que o programa seja executado " +
                    "por um usuário com privilégios administrativos.\n\n" +
                    "Clique com o botão direito do mouse no FixMyPrinter e depois clique em 'Executar como Administrador'.", "A operação requer elevação",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if(spooler.Status == ServiceControllerStatus.Stopped)
            {
                lblStatus.Text = "parado.";
            }
        }

        private void ReloadSpooler()
        {
            //Definindo o Spooler como o serviço alvo dos procedimentos
            ServiceController spooler = new ServiceController("Spooler");

            //Verificando se o serviço está parado
            if (spooler.Status == ServiceControllerStatus.Stopped || spooler.Status == ServiceControllerStatus.Paused)
            {
                    if (spooler.StartType == ServiceStartMode.Automatic || spooler.StartType == ServiceStartMode.Manual)
                    {

                    AutoClosingMessageBox.Show("Iniciando o serviço do Spooler de impressão...", "Status", 1000);

                    spooler.Start();
                    }

                    else if (spooler.StartType == ServiceStartMode.Disabled)
                {
                    MessageBox.Show("O serviço está desativado, será necessário inicializá-lo manualmente!");
                    System.Diagnostics.Process.Start("services.msc");
                }

            }

            //Se o serviço estiver sendo executado ele será parado e iniciado novamente.
            else if (spooler.Status == ServiceControllerStatus.Running)
            {
                //Parando o serviço do spooler de impressão
                spooler.Stop();

                //Iniciando o serviço do Spooler de impressão
                spooler.Start();
                MessageBox.Show("Agora tudo deve funcionar corretamente!\n" +
                                "Por favor, tente imprimir novamente.", "Aviso");
            }
        }

        private void btnFixPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                ReloadSpooler();
            }
            catch (Exception ex)
            {
                const string errmsg = "Ocorreu um erro inesperado";
                MessageBox.Show(ex.Message, errmsg);
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
