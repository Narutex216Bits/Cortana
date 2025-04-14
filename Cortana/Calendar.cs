using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cortana
{
    public partial class Calendar : Form
    {
        string connectionString = "server=127.0.0.1;user=root;password=;database=otames_db";

        public Calendar()
        {
            InitializeComponent();
            calendarCortana.DateChanged += calendarCortana_DateChanged;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void calendarCortana_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = calendarCortana.SelectionStart;
            CarregarRegistrosPorData(dataSelecionada);
        }

        private void CarregarRegistrosPorData(DateTime data)
        {
            string dataFormatada = data.ToString("yyyy-MM-dd");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
    -- Compromissos no mesmo dia e mês
    SELECT 'Compromisso' AS Tipo, nome, descricao, data_compromisso AS Data, hora_compromisso AS Hora
    FROM compromissos
    WHERE DAY(data_compromisso) = DAY(@data) AND MONTH(data_compromisso) = MONTH(@data)

    UNION

    -- Filmes lançados no mesmo ano
    SELECT 'Filme', nome, sinopse, ano_lancamento, NULL
    FROM filmes
    WHERE ano_lancamento = YEAR(@data)

    UNION

    -- Animes com data relacionada ao mesmo dia e mês
    SELECT 'Anime', nome, titulo_alternativo, data_lancamento, data_termino, data_lancamento_br, criador, diretor, roteirista, estudio, tipo, status, episodios, duracao_media, genero, popularidade, nota_media, inspiracao, publico_alvo, censura, logo_url, NULL
    FROM anime
    WHERE 
        (data_lancamento IS NOT NULL AND DAY(data_lancamento) = DAY(@data) AND MONTH(data_lancamento) = MONTH(@data))
        OR (data_termino IS NOT NULL AND DAY(data_termino) = DAY(@data) AND MONTH(data_termino) = MONTH(@data))
        OR (data_lancamento_br IS NOT NULL AND DAY(data_lancamento_br) = DAY(@data) AND MONTH(data_lancamento_br) = MONTH(@data))

    UNION

    -- Desenhos lançados no mesmo ano
    SELECT 'Desenho', nome, descricao, ano_lancamento, NULL
    FROM desenhos
    WHERE ano_lancamento = YEAR(@data)

    UNION

    -- Dubladores aniversariando no mesmo dia/mês
    SELECT 'Dublador', nome, NULL, data_aniversario, NULL
    FROM anime_dubladores
    WHERE DAY(data_aniversario) = DAY(@data) AND MONTH(data_aniversario) = MONTH(@data)

    UNION

    -- Livros publicados no mesmo ano
    SELECT 'Livro', titulo, NULL, ano_publicacao, NULL
    FROM livros
    WHERE ano_publicacao = YEAR(@data)
";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@data", dataFormatada);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridCortana.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar registros: " + ex.Message);
                }
            }
        }
    }
}
