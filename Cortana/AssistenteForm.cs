using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Cortana
{
    public partial class AssistenteForm : Form
    {
        // Dicionários para armazenar imagens e sons
        private Dictionary<string, string> assistenteImagens = new Dictionary<string, string>();
        private Dictionary<string, string> assistenteSons = new Dictionary<string, string>();

        // Variável para armazenar a imagem de fundo
        private string caminhoImagemFundo;

        public AssistenteForm()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            // Adiciona as opções ao ComboBox de imagens e sons
            comboBoxAssistente.Items.AddRange(new string[]
            {
                "Facebook", "Instagram", "Whatsapp", "Discord", "Steam",
                "Deviantart", "Reddit", "Tumblr", "Xuitter", "Epic Games",
                "Gog", "Telegram", "Messenger", "Tik Tok", "Threads",
                "Gmail", "Hotmail", "Yahoo Mail"
            });

            comboBoxIcones.Items.AddRange(new string[]
            {
                "Facebook", "Instagram", "Whatsapp", "Discord", "Steam",
                "Deviantart", "Reddit", "Tumblr", "Xuitter", "Epic Games",
                "Gog", "Telegram", "Messenger", "Tik Tok", "Threads",
                "Gmail", "Hotmail", "Yahoo Mail"
            });

            // Define o primeiro item como selecionado por padrão
            comboBoxAssistente.SelectedIndex = 0;
            comboBoxIcones.SelectedIndex = 0;
        }

        // Código para o botão de procurar imagem
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Selecione uma imagem para a assistente";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoImagem = openFileDialog.FileName;
                    pictureBoxAssistenteConfig.Image = Image.FromFile(caminhoImagem);

                    string opcaoSelecionada = comboBoxAssistente.SelectedItem.ToString();
                    assistenteImagens[opcaoSelecionada] = caminhoImagem;
                }
            }
        }

        // Código para o botão de aplicar imagem
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxAssistente.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma notificação para configurar a imagem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcaoSelecionada = comboBoxAssistente.SelectedItem.ToString();

            if (assistenteImagens.ContainsKey(opcaoSelecionada))
            {
                MessageBox.Show($"Imagem aplicada para {opcaoSelecionada} com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem foi selecionada. Escolha uma imagem antes de aplicar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Código para procurar o arquivo de som
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Áudio WAV|*.wav";
                openFileDialog.Title = "Selecione um arquivo de áudio (WAV)";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoAudio = openFileDialog.FileName;
                    string opcaoSelecionada = comboBoxIcones.SelectedItem.ToString();
                    assistenteSons[opcaoSelecionada] = caminhoAudio;
                    MessageBox.Show("Som selecionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Código para aplicar o som
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBoxIcones.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma notificação para configurar o som.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcaoSelecionada = comboBoxIcones.SelectedItem.ToString();

            if (assistenteSons.ContainsKey(opcaoSelecionada))
            {
                string caminhoAudio = assistenteSons[opcaoSelecionada];
                try
                {
                    SoundPlayer soundPlayer = new SoundPlayer(caminhoAudio);
                    soundPlayer.Play();
                    MessageBox.Show($"Som aplicado para {opcaoSelecionada} com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao reproduzir o som: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum som foi selecionado. Escolha um som antes de aplicar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Atualiza a imagem no PictureBox conforme a seleção no ComboBox
        private void comboBoxAssistente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcaoSelecionada = comboBoxAssistente.SelectedItem.ToString();

            if (assistenteImagens.ContainsKey(opcaoSelecionada))
            {
                pictureBoxAssistenteConfig.Image = Image.FromFile(assistenteImagens[opcaoSelecionada]);
            }
            else
            {
                pictureBoxAssistenteConfig.Image = null;
            }
        }

        // Código para o ComboBox de ícones (sons)
        private void comboBoxIcones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcaoSelecionada = comboBoxIcones.SelectedItem.ToString();

            if (assistenteSons.ContainsKey(opcaoSelecionada))
            {
                // O código de reprodução de som pode ser adicionado aqui, se necessário.
            }
            else
            {
                // Se não houver som, pode-se limpar o som atual ou realizar outra ação.
            }
        }

        // Código para o botão de procurar imagem de fundo
        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Selecione uma imagem para o plano de fundo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoImagemFundo = openFileDialog.FileName;

                    // Exibe a prévia no PictureBox
                    pictureBoxFundo.Image = Image.FromFile(caminhoImagemFundo);
                }
            }
        }

        // Código para aplicar o plano de fundo ao MainForm
        private void button8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(caminhoImagemFundo))
            {
                // Cria uma instância do MainForm (ou obtém a instância já existente)
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

                // Se o MainForm estiver aberto, aplica a imagem de fundo
                if (mainForm != null)
                {
                    mainForm.AplicaImagemFundo(caminhoImagemFundo);
                    MessageBox.Show("Plano de fundo aplicado com sucesso!");
                }
                else
                {
                    MessageBox.Show("O MainForm não está aberto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma imagem de fundo primeiro.");
            }
        }

        // Ação do botão de "Aplicar"
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            AplicarConfiguracoes();
        }

        // Ação do botão de "OK" (Aplica as configurações e fecha)
        private void btnOk_Click(object sender, EventArgs e)
        {
            AplicarConfiguracoes();
            this.Close(); // Fecha o AssistenteForm
        }

        // Ação do botão de "Cancelar" (Não aplica as configurações e fecha)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Apenas fecha o AssistenteForm sem salvar
        }

        private void AplicarConfiguracoes()
        {
            // Aplica a imagem do assistente
            if (comboBoxAssistente.SelectedItem != null)
            {
                string opcaoSelecionada = comboBoxAssistente.SelectedItem.ToString();
                if (assistenteImagens.ContainsKey(opcaoSelecionada))
                {
                    MessageBox.Show($"Imagem aplicada para {opcaoSelecionada} com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem foi selecionada. Escolha uma imagem antes de aplicar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}