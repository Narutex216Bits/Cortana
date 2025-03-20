using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cortana
{
    public partial class MainForm : Form
    {
        private NotifyIcon notifyIcon;

        public MainForm()
        {
            InitializeComponent();

            // Configurações do MainForm
            this.Text = "Cortana";
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true; // Permite formulários filhos
            this.FormClosing += MainForm_FormClosing;

            // Configuração da System Tray
            notifyIcon = new NotifyIcon
            {
                Icon = new Icon("Cortana.ICO"),  // Usando o novo ícone
                Text = "",
                Visible = false
            };
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;

            // Chama o login apenas uma vez, se necessário
            LoadLoginForm();
        }

        private void LoadLoginForm()
        {
            if (IsUserLoggedIn())
            {
                // Se já está logado, abre direto o CortanaStatus
                LoadCortanaStatus();
                return;
            }

            LoginForm loginForm = new LoginForm
            {
                MdiParent = null,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(816, 488)
            };

            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Bem-Vindo de volta!", "Eu sou a Cortana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCortanaStatus(); // Abre a tela CortanaStatus após o login
            }
            else
            {
                Application.Exit();
            }
        }

        // Método para carregar o CortanaStatus dentro do MainForm
        private void LoadCortanaStatus()
        {
            CortanaStatus cortanaStatus = new CortanaStatus
            {
                MdiParent = this, // Define o MainForm como pai
                FormBorderStyle = FormBorderStyle.None, // Remove as bordas
                Dock = DockStyle.Fill // Ajusta o tamanho ao MainForm
            };
            cortanaStatus.Show();
        }

        private bool IsUserLoggedIn() => false;

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000, "Hey!", "Não prometa a uma garota algo que você não pode cumprir!", ToolTipIcon.Info);
        }

        // Evento para "Sair" do menu
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você quer sair?", "Vai me esquecer aqui com o Flood?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                notifyIcon.Visible = false;
                Application.Exit();
            }
        }

        // Evento para abrir o AssistenteForm dentro do MainForm
        private void configuraçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssistenteForm assistenteForm = new AssistenteForm
            {
                MdiParent = this, // Define MainForm como pai
                FormBorderStyle = FormBorderStyle.None, // Remove bordas
                Dock = DockStyle.Fill // Ajusta ao tamanho do MainForm
            };
            assistenteForm.Show();
        }

        // Adicionando o novo evento de menu para abrir a configuração do assistente
        private void configuraçõesAssistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssistenteForm assistenteForm = new AssistenteForm
            {
                MdiParent = this, // Define MainForm como pai
                FormBorderStyle = FormBorderStyle.None, // Remove bordas
                Dock = DockStyle.Fill // Ajusta ao tamanho do MainForm
            };
            assistenteForm.Show();
        }
        public void AplicaImagemFundo(string caminhoImagem)
        {
            // Aplica a imagem de fundo ao MainForm
            try
            {
                this.BackgroundImage = Image.FromFile(caminhoImagem);
                this.BackgroundImageLayout = ImageLayout.Stretch; // Ajusta a imagem para cobrir todo o fundo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aplicar a imagem de fundo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
