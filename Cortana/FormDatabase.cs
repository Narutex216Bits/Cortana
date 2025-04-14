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
    public partial class FormDatabase : Form
    {
        public FormDatabase()
        {
            InitializeComponent();
        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {

        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
                string connStr = "server=127.0.0.1;user=root;password=;database=otames_db";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        // Exemplo: Inserindo ANIME
                        string queryAnime = @"INSERT INTO anime 
                (nome, titulo_alternativo, data_lancamento, data_termino, data_lancamento_br, 
                criador, diretor, roteirista, trilha_sonora, estudio, tipo, status, episodios, 
                duracao_media, genero, popularidade, nota_media, numero_avaliacoes, trailer_url, 
                site_oficial, mal_id, anilist_id, inspiracao, publico_alvo, censura, logo_url)
                VALUES 
                (@nome, @titulo_alternativo, @data_lancamento, @data_termino, @data_lancamento_br,
                @criador, @diretor, @roteirista, '', @estudio, @tipo, @status, @episodios,
                @duracao_media, @genero, @popularidade, @nota_media, 0, @trailer_url, 
                @site_oficial, @mal_id, @anilist_id, @inspiracao, @publico_alvo, @censura, @logo_url)";

                        MySqlCommand cmd = new MySqlCommand(queryAnime, conn);
                        cmd.Parameters.AddWithValue("@nome", txtAnimeNome.Text);
                        cmd.Parameters.AddWithValue("@titulo_alternativo", txtAnimeAltNome.Text);
                        cmd.Parameters.AddWithValue("@data_lancamento", txtAnimeData.Text);
                        cmd.Parameters.AddWithValue("@data_termino", txtAnimeTermino.Text);
                        cmd.Parameters.AddWithValue("@data_lancamento_br", txtAnimeDataBrasil.Text);
                        cmd.Parameters.AddWithValue("@criador", txtAnimeCriador.Text);
                        cmd.Parameters.AddWithValue("@diretor", txtAnimeDiretor.Text);
                        cmd.Parameters.AddWithValue("@roteirista", txtAnimeRoteirista.Text);
                        cmd.Parameters.AddWithValue("@estudio", txtAnimeEstudio.Text);
                        cmd.Parameters.AddWithValue("@tipo", txtAnimeTipo.Text);
                        cmd.Parameters.AddWithValue("@status", txtAnimeStatus.Text);
                        cmd.Parameters.AddWithValue("@episodios", txtAnimeEpisodios.Text);
                        cmd.Parameters.AddWithValue("@duracao_media", txtAnimeDuracaoEpi.Text);
                        cmd.Parameters.AddWithValue("@genero", txtAnimeGenero.Text);
                        cmd.Parameters.AddWithValue("@popularidade", txtAnimePopularidade.Text);
                        cmd.Parameters.AddWithValue("@nota_media", txtAnimeNota.Text);
                        cmd.Parameters.AddWithValue("@trailer_url", txtAnimeTrailer.Text);
                        cmd.Parameters.AddWithValue("@site_oficial", txtAnimeSite.Text);
                        cmd.Parameters.AddWithValue("@mal_id", txtAnimeMyAnimeList.Text);
                        cmd.Parameters.AddWithValue("@anilist_id", txtAnimeAnilist.Text);
                        cmd.Parameters.AddWithValue("@inspiracao", txtAnimeInspiracao.Text);
                        cmd.Parameters.AddWithValue("@publico_alvo", txtAnimePublico.Text);
                        cmd.Parameters.AddWithValue("@censura", txtAnimeCensura.Text);
                        cmd.Parameters.AddWithValue("@logo_url", txtAnimeLogo.Text);
                        cmd.Parameters.AddWithValue("@trilha_sonora", txtTrilhaSonora.Text);
                        cmd.Parameters.AddWithValue("@numero_avaliacoes", txtNumeroAvaliacoes.Text);

                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Anime gravado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar: " + ex.Message);
                    }
                }
            }

        private void exitBtn_Click(object sender, EventArgs e)
        {
                this.Close(); // Fecha o formulário
        }

        private void GravarDublador_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;password=;database=otames_db";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO anime_dubladores 
                            (nome, foto_url, data_aniversario) 
                            VALUES 
                            (@nome, @foto_url, @data_aniversario)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nomeTxt.Text);
                    cmd.Parameters.AddWithValue("@foto_url", fotoUrlTxt.Text);
                    cmd.Parameters.AddWithValue("@data_aniversario", aniversarioPicker.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dublador gravado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gravar dublador: " + ex.Message);
                }
            }
        }

        private void gravarPersonagens_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;password=;database=otames_db";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string queryPersonagem = @"INSERT INTO anime_personagens 
                (nome, foto_url, anime_id, dublador_id)
                VALUES (@nome, @foto_url, @anime_id, @dublador_id)";

                    MySqlCommand cmd = new MySqlCommand(queryPersonagem, conn);
                    cmd.Parameters.AddWithValue("@nome", txtPersonagemNome.Text);
                    cmd.Parameters.AddWithValue("@foto_url", txtPersonagemFoto.Text);
                    cmd.Parameters.AddWithValue("@anime_id", Convert.ToInt32(txtAnimeID.Text));
                    cmd.Parameters.AddWithValue("@dublador_id", Convert.ToInt32(txtDubladorID.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personagem gravado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gravar personagem: " + ex.Message);
                }
            }
        }

        private void gravarAutores_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;password=;database=otames_db";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string queryAutores = @"INSERT INTO autores 
                (nome_autor, biografia, foto_autor, created_at)
                VALUES (@nome, @biografia, @foto_autor, @created_at)";

                    MySqlCommand cmd = new MySqlCommand(queryAutores, conn);
                    cmd.Parameters.AddWithValue("@nome", txtAutorNome.Text);
                    cmd.Parameters.AddWithValue("@biografia", txtBiografia.Text);
                    cmd.Parameters.AddWithValue("@foto_autor", txtAutorFoto.Text );
                    cmd.Parameters.AddWithValue("@created_at", autorPicker.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor gravado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gravar autor: " + ex.Message);
                }
            }
        }

        private void gravarLivros_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;password=;database=otames_db";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string queryAutores = @"INSERT INTO autores_livros 
                (autor_id, livro_id, created_at)
                VALUES (@autor_id, @livro_id, @created_at)";

                    MySqlCommand cmd = new MySqlCommand(queryAutores, conn);
                    cmd.Parameters.AddWithValue("@autor_id", txtAutorId.Text);
                    cmd.Parameters.AddWithValue("@livro_id", txtLivroId.Text);
                    cmd.Parameters.AddWithValue("@created_at", autorLivrosPicker.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor gravado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gravar autor: " + ex.Message);
                }
            }
        }

        private void livroRecordBtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;password=;database=otames_db";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string queryLivros = @"INSERT INTO livros 
                (titulo, ano_publicação, capa_url, created_at)
                VALUES (@titulo, @ano_publicação, @capa_url, @created_at)";

                    MySqlCommand cmd = new MySqlCommand(queryLivros, conn);
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@ano_publicação", txtAnoPublicacao.Text);
                    cmd.Parameters.AddWithValue("@capa_url", txtCapaURL.Text);
                    cmd.Parameters.AddWithValue("@created_at", LivrosPicker.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor gravado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gravar autor: " + ex.Message);
                }
            }
        }
    }
    }
