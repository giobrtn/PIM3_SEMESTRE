using Npgsql;
using PIM3_SEMESTRE.notificações;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3_SEMESTRE.login
{
    public partial class tela_login : Form
    {
        public NpgsqlConnection Connection { get; set; } = null;

        NpgsqlConnection conn = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=sistema;" +
                "Uid=postgres;" +
                "Pwd=dbadmin;");

        public event EventHandler LoginSuccessful;
        public tela_login()
        {
            InitializeComponent();
            textBox_senha.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void limparCampos() { textBox_login.Text = ""; textBox_senha.Text = "";}
        private void button_entrar_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string senha = textBox_senha.Text;

            try
            {
                // Verifica se a conexão está aberta, se sim, fecha antes de abrir novamente
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                string query = "SELECT senhausuario FROM usuario WHERE nomeusuario = @nomeusuario";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("nomeusuario", login);

                object result = cmd.ExecuteScalar();
                string storedPassword = result != null ? result.ToString() : null;

                if (storedPassword != null && senha == storedPassword)
                {
                    MessageBox.Show("Login efetuado com sucesso!");
                    OnLoginSuccessful(EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos!");
                    limparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login: " + ex.Message);
            }
            finally
            {
                // Garante que a conexão seja fechada mesmo se ocorrer uma exceção
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected virtual void OnLoginSuccessful(EventArgs e)
        {
            LoginSuccessful?.Invoke(this, e);
        }
    }
}
