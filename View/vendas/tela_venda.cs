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

            NpgsqlCommand c1 = new NpgsqlCommand("SELECT * FROM fornecedor", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
               //dataGridView_historico_venda.DataSource = dt;
            }

            conn.Close();

        }
        /*
        private void button_adicionar_Click(object sender, EventArgs e)
        {
            string idCliente = textBox_cliente.Text;
            string data = textBox_data.Text;
            string pagamento = textBox_pagamento.Text;
            string produto = textBox_produto.Text;
            string quantidade = textBox_quantidade.Text;
            try
            {
                conn.Open();
                string query = "INSERT INTO fornecedor (nomeFornecedor, cnpj, telefone, enderecoFornecedor, statusfornecedor) " +
                               "VALUES (@nomefornecedor, @cnpj, @telefone, @endereco, @status)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("nomeFornecedor", nome);
                cmd.Parameters.AddWithValue("cnpj", cnpj);
                cmd.Parameters.AddWithValue("telefone", telefone);
                cmd.Parameters.AddWithValue("endereco", endereco);
                cmd.Parameters.AddWithValue("status", 1);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar fornecedor: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }*/
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

        private void textBox_cliente_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO vendas (cliente) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_data_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO vendas (data) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_pagamento_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO vendas (pagamento) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_produto_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO vendas (produto) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_quantidade_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO vendas (quantidade) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("INSERT INTO vendas (usuario) VALUES ()", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            string cliente = textBox_cliente.Text;
            string data = textBox_data.Text;
            string pagamento = textBox_pagamento.Text;
            string produto = textBox_produto.Text;
            string quantidade = textBox_quantidade.Text;
            string usuario = textBox_usuario.Text;
            string totalvenda = textBox_total_venda.Text;

            try
            {
                conn.Open();
                string query = "INSERT INTO pedidovenda (idcliente, datavenda, pagamento, idproduto, quantidade, idusuario, totalvenda) " +
                               "VALUES (@cliente, @data, @pagamento, @produto, @quantidade, @usuario, @totalvenda)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("cliente", cliente);

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

                cmd.Parameters.AddWithValue("pagamento", pagamento);
                cmd.Parameters.AddWithValue("produto", produto);
                cmd.Parameters.AddWithValue("quantidade", quantidade);
                cmd.Parameters.AddWithValue("usuario", usuario);


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
    }
}
