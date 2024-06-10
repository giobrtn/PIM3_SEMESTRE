using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3_SEMESTRE.produção
{
    public partial class tela_produção_adicionar : Form
    {
        public event EventHandler ClienteButtonClicked;
        public event EventHandler NotificacaoButtonClicked;
        public event EventHandler FornecedorButtonClicked;
        public event EventHandler VendasButtonClicked;
        public event EventHandler RelatorioButtonClicked;
        public event EventHandler ProducaoButtonClicked;
        public event EventHandler SairButtonClicked;
        public event EventHandler AddProducaoButtonClicked;
        public NpgsqlConnection Connection { get; set; } = null;

        NpgsqlConnection conn = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=sistema;" +
                "Uid=postgres;" +
                "Pwd=dbadmin;");

        public tela_produção_adicionar()
        {
            InitializeComponent();
        }

        /*
        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (nome) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_categoria_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (categoria) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_tipo_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (tipo) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox4_estacao_preferencial_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (estacaopreferencial) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_data_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (data) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (usuario) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_fornecedor_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (fornecedor) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_quantidade_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (quantidade) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_preco_inicial_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (precoinicial) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_preco_final_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO produto (precofinal) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        } */
        private void button_adicionar_Click(object sender, EventArgs e)
        {
            string nome = textBox_nome.Text;
            string categoria = textBox_categoria.Text;
            string tipo = textBox_tipo.Text;
            string estacaoPreferencial = textBox4_estacao_preferencial.Text;
            string data = textBox_data.Text;
            string usuario = textBox_usuario.Text;
            string fornecedor = textBox_fornecedor.Text;
            string quantidade = textBox_quantidade.Text;
            string precoInicial = textBox_preco_inicial.Text;
            string precoFinal = textBox_preco_final.Text;

            try
            {
                conn.Open();
                string query = "INSERT INTO produto (nomeproduto, categoria, tipo, estacaopreferencial, data, idUsuario, idFornecedor, quantidadeestoque, preco, precofinal, statusproduto) " +
                               "VALUES (@nome, @categoria, @tipo, @estacaoPreferencial, @data, @usuario, @fornecedor, @quantidade, @precoInicial, @precoFinal, @status)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("categoria", categoria);
                cmd.Parameters.AddWithValue("tipo", tipo);
                cmd.Parameters.AddWithValue("estacaoPreferencial", estacaoPreferencial);
                cmd.Parameters.AddWithValue("status", 1);

                DateTime dataConvertida;
                if (DateTime.TryParse(data, out dataConvertida))
                {
                    cmd.Parameters.AddWithValue("data", dataConvertida);
                }
                else
                {
                    MessageBox.Show("Data inválida.");
                    return;
                }

                int idUsuario;
                if (int.TryParse(usuario, out idUsuario))
                {
                    cmd.Parameters.AddWithValue("usuario", idUsuario);
                }
                else
                {
                    MessageBox.Show("ID do usuário inválido.");
                    return;
                }

                int idFornecedor;
                if (int.TryParse(fornecedor, out idFornecedor))
                {
                    cmd.Parameters.AddWithValue("fornecedor", idFornecedor);
                }
                else
                {
                    MessageBox.Show("ID do fornecedor inválido.");
                    return;
                }

                int quantidadeValor;
                if (int.TryParse(quantidade, out quantidadeValor))
                {
                    cmd.Parameters.AddWithValue("quantidade", quantidadeValor);
                }
                else
                {
                    MessageBox.Show("Quantidade inválida.");
                    return;
                }

                
                double precoInicialValor;
                if (double.TryParse(precoInicial, out precoInicialValor))
                {
                    cmd.Parameters.AddWithValue("precoInicial", precoInicialValor);
                }
                else
                {
                    MessageBox.Show("Preço inicial inválido.");
                    return;
                }

                double precoFinalValor;
                if (double.TryParse(precoFinal, out precoFinalValor))
                {
                    cmd.Parameters.AddWithValue("precoFinal", precoFinalValor);
                }
                else
                {
                    MessageBox.Show("Preço final inválido.");
                    return;
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_notificacao_Click(object sender, EventArgs e)
        {
            OnNotificacaoButtonClicked(EventArgs.Empty);
        }
        private void button_fornecedor_Click(object sender, EventArgs e)
        {
            OnFornecedorButtonClicked(EventArgs.Empty);
        }
        private void button_cliente_Click(object sender, EventArgs e)
        {
            OnClienteButtonClicked(EventArgs.Empty);
        }

        private void button_vendas_Click(object sender, EventArgs e)
        {
            OnVendasButtonClicked(EventArgs.Empty);
        }

        private void button_relatorio_Click(object sender, EventArgs e)
        {
            OnRelatorioButtonClicked(EventArgs.Empty);
        }

        private void button_producao_Click(object sender, EventArgs e)
        {
            OnProducaoButtonClicked(EventArgs.Empty);
        }
        private void button_sair_Click(object sender, EventArgs e)
        {
            OnSairButtonClicked(EventArgs.Empty);
        }



        protected virtual void OnNotificacaoButtonClicked(EventArgs e)
        {
            NotificacaoButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnFornecedorButtonClicked(EventArgs e)
        {
            FornecedorButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnClienteButtonClicked(EventArgs e)
        {
            ClienteButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnVendasButtonClicked(EventArgs e)
        {
            VendasButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnRelatorioButtonClicked(EventArgs e)
        {
            RelatorioButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnProducaoButtonClicked(EventArgs e)
        {
            ProducaoButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnSairButtonClicked(EventArgs e)
        {
            SairButtonClicked?.Invoke(this, e);
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
