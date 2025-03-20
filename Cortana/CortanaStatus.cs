using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cortana
{
    public partial class CortanaStatus : Form
    {
        private string caminhoSons = "Sounds";
        private string caminhoImagens = "Images";
        private Dictionary<string, PictureBox> notificacoes = new Dictionary<string, PictureBox>();
        private Image cortanaIdle1;
        private Image cortanaIdle2;
        private Dictionary<string, Image> cortanaDirecoes = new Dictionary<string, Image>();
        private bool temNotificacao = false;

        public CortanaStatus()
        {
            InitializeComponent();
            InicializarNotificacoes();
            CarregarImagensCortana();
            IniciarAnimacaoIdle();
        }

        private void CortanaStatus_Load(object sender, EventArgs e)
        {
            // Coleção de sons de boas-vindas
            List<string> sonsBoasVindas = new List<string>
    {
        "in-01",
        "in-02",
        "in-03",
        "in-04",
        "in-05"
    };

            // Sorteia um som aleatório
            Random rnd = new Random();
            string somEscolhido = sonsBoasVindas[rnd.Next(sonsBoasVindas.Count)];

            // Toca o som escolhido
            TocarSom(somEscolhido);
        }
        private void InicializarNotificacoes()
        {
            notificacoes.Add("ms-discord", pbMsg_Discord);
            notificacoes.Add("ms-fbmessager", pbMsg_Messenge);
            notificacoes.Add("ms-instagram", pbMsg_InstagramDirect);
            notificacoes.Add("ms-telegram", pbMsg_Telegram);
            notificacoes.Add("ms-whatsapp", pbMsg_WhatsApp);
            notificacoes.Add("gm-epic", pbGames_Epic);
            notificacoes.Add("gm-gog", pbGames_GOG);
            notificacoes.Add("gm-steam", pbGames_Steam);
            notificacoes.Add("ml-gmail", pbMail_Gmail);
            notificacoes.Add("ml-outlook", pbMail_Outlook);
            notificacoes.Add("ml-yahoo", pbMail_Yahoo);
            notificacoes.Add("nt-deviant", pbRedes_DeviantArt);
            notificacoes.Add("nt-facebook", pbRedes_Facebook);
            notificacoes.Add("nt-instagram", pbRedes_Instagram);
            notificacoes.Add("nt-reddit", pbRedes_Reddit);
            notificacoes.Add("nt-tiktok", pbRedes_TikTok);
            notificacoes.Add("nt-xuitter", pbRedes_Xuitter);
        }

        private void CarregarImagensCortana()
        {
            cortanaIdle1 = Image.FromFile(Path.Combine(Application.StartupPath, caminhoImagens, "idle_1.png"));
            cortanaIdle2 = Image.FromFile(Path.Combine(Application.StartupPath, caminhoImagens, "idle_2.png"));
            cortanaDirecoes["cima"] = Image.FromFile(Path.Combine(Application.StartupPath, caminhoImagens, "look_up.png"));
            cortanaDirecoes["baixo"] = Image.FromFile(Path.Combine(Application.StartupPath, caminhoImagens, "look_down.png"));
            cortanaDirecoes["esquerda"] = Image.FromFile(Path.Combine(Application.StartupPath, caminhoImagens, "look_left.png"));
            cortanaDirecoes["direita"] = Image.FromFile(Path.Combine(Application.StartupPath, caminhoImagens, "look_right.png"));
        }

        private async void IniciarAnimacaoIdle()
        {
            while (true)
            {
                if (!temNotificacao)
                {
                    pbCortana.Image = cortanaIdle1;
                    await Task.Delay(1000);
                    pbCortana.Image = cortanaIdle2;
                    await Task.Delay(1000);
                }
                else
                {
                    await Task.Delay(500);
                }
            }
        }

        public async void ReceberNotificacao(string tipo, string direcao)
        {
            if (!notificacoes.ContainsKey(tipo) || !cortanaDirecoes.ContainsKey(direcao)) return;

            PictureBox pb = notificacoes[tipo];
            TocarSom(tipo);
            await PiscarIcone(pb, tipo);
            await AlterarImagemCortana(direcao);
        }

        private void TocarSom(string nomeArquivo)
        {
            string caminho = Path.Combine(Application.StartupPath, caminhoSons, nomeArquivo + ".wav");
            if (File.Exists(caminho))
            {
                SoundPlayer player = new SoundPlayer(caminho);
                player.Play();
            }
        }

        private async Task PiscarIcone(PictureBox pb, string nomeArquivo)
        {
            string caminhoImg1 = Path.Combine(Application.StartupPath, "Images", nomeArquivo + "_1.png");
            string caminhoImg2 = Path.Combine(Application.StartupPath, "Images", nomeArquivo + "_2.png");
            if (!File.Exists(caminhoImg1) || !File.Exists(caminhoImg2)) return;

            Image img1 = Image.FromFile(caminhoImg1);
            Image img2 = Image.FromFile(caminhoImg2);

            pb.BackColor = Color.Red;
            for (int i = 0; i < 3; i++)
            {
                pb.Image = img1;
                await Task.Delay(500);
                pb.Image = img2;
                await Task.Delay(500);
            }
            pb.BackColor = Color.Transparent;
            pb.Image = img1;
        }

        private async Task AlterarImagemCortana(string direcao)
        {
            temNotificacao = true;
            Image direcaoImagem = cortanaDirecoes[direcao];

            for (int i = 0; i < 3; i++)
            {
                pbCortana.Image = cortanaIdle1;
                await Task.Delay(500);
                pbCortana.Image = direcaoImagem;
                await Task.Delay(500);
            }
            temNotificacao = false;
        }

        private void CortanaStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Coleção de sons de despedida
            List<string> sonsDespedida = new List<string>
    {
        "ex-01",
        "ex-02"
        };

            // Sorteia um som aleatório
            Random rnd = new Random();
            string somEscolhido = sonsDespedida[rnd.Next(sonsDespedida.Count)];

            // Toca o som escolhido
            TocarSom(somEscolhido);
        }

        private void pbCortana_Click(object sender, EventArgs e)
        {
        }
    }
}
-