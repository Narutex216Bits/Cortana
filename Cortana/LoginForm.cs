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
    public partial class LoginForm : Form
    {
        // String de Conexão com o banco de dados
        string connectionString = "Server=localhost;Database=otames_db;Uid=root;Pwd=;";

        public LoginForm()
        {
            InitializeComponent();
        }

        // Função de login
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = loginTxtBox.Text;
            string password = passTxtBox.Text;

            // Chama a função de autenticação
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login bem-sucedido!");
                this.DialogResult = DialogResult.OK; // Definir o DialogResult como OK
                this.Close(); // Fecha o LoginForm
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
            }
        }

        // Função para autenticar o usuário
        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;

            // Usando a conexão MySQL com a string de conexão
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query para verificar o login e a senha
                    string query = "SELECT * FROM users WHERE login = @login AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Substituindo os parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@login", username);
                    cmd.Parameters.AddWithValue("@password", password);  // Aqui é onde você validaria a senha criptografada

                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Se houver um registro correspondente, o login é válido
                    if (reader.HasRows)
                    {
                        isAuthenticated = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }

            return isAuthenticated;
        }

        // Função para o botão de sair
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Exibe uma caixa de diálogo de confirmação
            DialogResult result = MessageBox.Show("Você realmente deseja sair?",
                                                  "Confirmar Saída",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result == DialogResult.Yes)
            {
                Application.Exit();  // Fecha toda a aplicação
            }
            else
            {
                // O usuário escolheu "Não", então não faz nada
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Aqui você pode adicionar qualquer código que queira executar quando o LoginForm for carregado.
        }
    }
}
