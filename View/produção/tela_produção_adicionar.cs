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
        private int idProduto;
        public tela_produção_adicionar(int idProduto = -1)
        {
            InitializeComponent();
            this.idProduto = idProduto;
            if (idProduto != -1)
            {
                
                CarregarDetalhesProduto(idProduto);

            }
            
        }

        private void CarregarDetalhesProduto(int idProduto)
        {
            
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM produto WHERE idproduto = @idproduto", conn);
                cmd.Parameters.AddWithValue("idproduto", idProduto);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    textBox_nome.Text = reader["nomeproduto"].ToString();
                    textBox_categoria.Text = reader["categoria"].ToString();
                    textBox_tipo.Text = reader["tipo"].ToString();
                    textBox4_estacao_preferencial.Text = reader["estacaopreferencial"].ToString();
                    textBox_data.Text = reader["data"].ToString();
                    textBox_usuario.Text = reader["idusuario"].ToString();
                    textBox_fornecedor.Text = reader["idfornecedor"].ToString();
                    textBox_quantidade.Text = reader["quantidadeestoque"].ToString();
                    textBox_preco_inicial.Text = reader["preco"].ToString();
                    textBox_preco_final.Text = reader["precofinal"].ToString();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do produto: " + ex.Message);
                this.Close(); 
            }
            finally
            {
                conn.Close();
            }
        }
    
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
                NpgsqlCommand cmd;
                if (idProduto != -1)
                {
                    // Update query
                    string updateQuery = "UPDATE produto SET nomeproduto = @nome, categoria = @categoria, tipo = @tipo, estacaopreferencial = @estacaoPreferencial, data = @data, idUsuario = @usuario, idFornecedor = @fornecedor, quantidadeestoque = @quantidade, preco = @precoInicial, precofinal = @precoFinal, statusproduto = @status WHERE idproduto = @idProduto";
                    cmd = new NpgsqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("idProduto", idProduto);
                }
                else
                {
                    // Insert query
                    string insertQuery = "INSERT INTO produto (nomeproduto, categoria, tipo, estacaopreferencial, data, idUsuario, idFornecedor, quantidadeestoque, preco, precofinal, statusproduto) " +
                                         "VALUES (@nome, @categoria, @tipo, @estacaoPreferencial, @data, @usuario, @fornecedor, @quantidade, @precoInicial, @precoFinal, @status)";
                    cmd = new NpgsqlCommand(insertQuery, conn);
                }

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
                MessageBox.Show(idProduto != -1 ? "Produto atualizado com sucesso!" : "Produto adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar/atualizar produto: " + ex.Message);
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
