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

namespace PIM3_SEMESTRE.vendas
{
    public partial class tela_venda : Form
    {
        public event EventHandler ClienteButtonClicked;
        public event EventHandler NotificacaoButtonClicked;
        public event EventHandler FornecedorButtonClicked;
        public event EventHandler VendasButtonClicked;
        public event EventHandler RelatorioButtonClicked;
        public event EventHandler ProducaoButtonClicked;
        public event EventHandler SairButtonClicked;
        public event EventHandler AddClientButtonClicked;
        public NpgsqlConnection Connection { get; set; } = null;

        NpgsqlConnection conn = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=sistema;" +
                "Uid=postgres;" +
                "Pwd=dbadmin;");

        public tela_venda()
        {
            InitializeComponent();
        }

        private void tela_venda_Load(object sender, EventArgs e)
        {

        }

        private void button_historico_Click(object sender, EventArgs e)
        {

            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("SELECT * FROM pedidovenda", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                //dataGridView_historico_venda.DataSource = dt;
            }

            conn.Close();

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



        private void button_adicionar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(textBox_usuario.Text) ||
                string.IsNullOrWhiteSpace(textBox_pagamento.Text) ||
                string.IsNullOrWhiteSpace(textBox_produto.Text) ||
                string.IsNullOrWhiteSpace(textBox_data.Text) ||
                string.IsNullOrWhiteSpace(textBox_quantidade.Text) ||
                string.IsNullOrWhiteSpace(textBox_cliente.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            int usuario;
            if (!int.TryParse(textBox_usuario.Text, out usuario))
            {
                MessageBox.Show("Usuário inválido. Por favor, insira um valor numérico.");
                return;
            }

            int produto;
            if (!int.TryParse(textBox_produto.Text, out produto))
            {
                MessageBox.Show("Produto inválido. Por favor, insira um valor numérico.");
                return;
            }

            int quantidade;
            if (!int.TryParse(textBox_quantidade.Text, out quantidade))
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um valor numérico.");
                return;
            }

            int cliente;
            if (!int.TryParse(textBox_cliente.Text, out cliente))
            {
                MessageBox.Show("Cliente inválido. Por favor, insira um valor numérico.");
                return;
            }

            // Obtendo o valor do produto com base no ID
            double precoFinal;
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT precofinal FROM produto WHERE idproduto = @idproduto", conn);
                cmd.Parameters.AddWithValue("idproduto", produto);
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Produto não encontrado.");
                    return;
                }
                precoFinal = Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o valor do produto: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }

            // Calculando o total da venda
            double totalVenda = quantidade * precoFinal;


            // Inserindo a venda no banco de dados
            try
            {
                conn.Open();
                string query = "INSERT INTO pedidovenda (idusuario, pagamento, idproduto, datavenda, quantidade, idcliente, totalvenda, statuspedido) " +
                               "VALUES (@idusuario, @formaPagamento, @idproduto, @data, @quantidade, @idcliente, @totalVenda, @statusPedido)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("idusuario", usuario);
                cmd.Parameters.AddWithValue("pagamento", textBox_pagamento.Text);
                cmd.Parameters.AddWithValue("idproduto", produto);
                cmd.Parameters.AddWithValue("data", textBox_data.Text);
                cmd.Parameters.AddWithValue("quantidade", quantidade);
                cmd.Parameters.AddWithValue("idcliente", cliente);
                cmd.Parameters.AddWithValue("totalVenda", totalVenda);
                cmd.Parameters.AddWithValue("statusPedido", 1); // Status de pedido padrão (ativo)
                cmd.ExecuteNonQuery();

                MessageBox.Show("Venda adicionada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar venda: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void textBox_quantidade_TextChanged(object sender, EventArgs e)
        {
            AtualizarTotalVenda();
        }

        private void textBox_produto_TextChanged(object sender, EventArgs e)
        {
            AtualizarTotalVenda();
        }

        private void AtualizarTotalVenda()
        {
            // Verificar se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(textBox_quantidade.Text) ||
                string.IsNullOrWhiteSpace(textBox_produto.Text))
            {
                return;
            }

            int produto;
            if (!int.TryParse(textBox_produto.Text, out produto))
            {
                MessageBox.Show("Produto inválido. Por favor, insira um valor numérico.");
                return;
            }

            int quantidade;
            if (!int.TryParse(textBox_quantidade.Text, out quantidade))
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um valor numérico.");
                return;
            }

            // Obtendo o valor do produto com base no ID
            double precoFinal;
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT precofinal FROM produto WHERE idproduto = @idproduto", conn);
                cmd.Parameters.AddWithValue("idproduto", produto);
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Produto não encontrado.");
                    return;
                }
                precoFinal = Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o valor do produto: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }

            // Calculando o total da venda
            double totalVenda = quantidade * precoFinal;

            // Exibindo o total da venda no campo textBox_total_venda
            textBox_total_venda.Text = totalVenda.ToString("F2"); // Formato com duas casas decimais
        }
    }
}