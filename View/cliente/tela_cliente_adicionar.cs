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

namespace PIM3_SEMESTRE.cliente
{
    public partial class tela_cliente_adicionar : Form
    {
        public event EventHandler NotificacaoButtonClicked;
        public event EventHandler FornecedorButtonClicked;
        public event EventHandler VendasButtonClicked;
        public event EventHandler RelatorioButtonClicked;
        public event EventHandler ProducaoButtonClicked;
        public event EventHandler SairButtonClicked;
        public event EventHandler AddClientButtonClicked;
        public event EventHandler ClientButtonClicked;
        public event EventHandler CancelButtonClicked;

        public NpgsqlConnection Connection { get; set; } = null;

        NpgsqlConnection conn = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=sistema;" +
                "Uid=postgres;" +
                "Pwd=dbadmin;");

        private int idCliente;

        public tela_cliente_adicionar(int idCliente = -1)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            if (idCliente != -1)
            {

                CarregarDetalhesCliente(idCliente);

            }

        }

        private string ObterEnderecoCompleto()
        {
            string logradouro = textBox_logradouro.Text;
            string numero = textBox_numero.Text;
            string cidade = textBox_cidade.Text;

            return $"{logradouro}, {numero}, {cidade}";
        }

        private void CarregarDetalhesCliente(int idCliente)
        {

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM cliente WHERE idcliente = @idcliente", conn);
                cmd.Parameters.AddWithValue("idcliente", idCliente);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    textBox_nome_empresa.Text = reader["nomecliente"].ToString();
                    textBox_cnpj.Text = reader["cpf"].ToString();
                    textBox_telefone.Text = reader["telefone"].ToString();
                    string[] enderecoParts = reader["enderecocliente"].ToString().Split(',');
                    if (enderecoParts.Length == 3)
                    {
                        textBox_logradouro.Text = enderecoParts[0].Trim();
                        textBox_numero.Text = enderecoParts[1].Trim();
                        textBox_cidade.Text = enderecoParts[2].Trim();
                    }

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do cliente: " + ex.Message);
                this.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            string nome = textBox_nome_empresa.Text;
            string cnpj = textBox_cnpj.Text;
            string telefone = textBox_telefone.Text;
            string endereco = ObterEnderecoCompleto();

            try
            {
                conn.Open();
                NpgsqlCommand cmd;
                if (idCliente != -1)
                {
                    // Update query
                    string updateQuery = "UPDATE cliente SET nomecliente = @nomecliente, cnpj = @cnpj, telefone = @telefone, enderecocliente = @endereco, statuscliente = @status WHERE idcliente = @idcliente";
                    cmd = new NpgsqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("idcliente", idCliente);
                }
                else
                {
                    // Insert query
                    string insertQuery = "INSERT INTO cliente (nomecliente, cnpj, telefone, enderecocliente, statuscliente) " +
                                         "VALUES (@nomecliente, @cnpj, @telefone, @endereco, @status)";
                    cmd = new NpgsqlCommand(insertQuery, conn);
                }

                cmd.Parameters.AddWithValue("nomecliente", nome);
                cmd.Parameters.AddWithValue("cnpj", cnpj);
                cmd.Parameters.AddWithValue("telefone", telefone);
                cmd.Parameters.AddWithValue("endereco", endereco);
                cmd.Parameters.AddWithValue("status", 1);

                cmd.ExecuteNonQuery();
                MessageBox.Show(idCliente != -1 ? "Cliente atualizado com sucesso!" : "Cliente adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar/atualizar cliente: " + ex.Message);
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

        private void button_cliente_Click(object sender, EventArgs e)
        {
            OnClientButtonClicked(EventArgs.Empty);
        }
        private void button_fornecedor_Click(object sender, EventArgs e)
        {
            OnFornecedorButtonClicked(EventArgs.Empty);
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
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            OnCancelButtonClick(EventArgs.Empty);
        }
        private void button_sair_Click(object sender, EventArgs e)
        {
            OnSairButtonClicked(EventArgs.Empty);
        }

        protected virtual void OnCancelButtonClick(EventArgs e)
        {
            CancelButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnClientButtonClicked(EventArgs e)
        {
            ClientButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnAddClientButtonClicked(EventArgs e)
        {
            AddClientButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnNotificacaoButtonClicked(EventArgs e)
        {
            NotificacaoButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnFornecedorButtonClicked(EventArgs e)
        {
            FornecedorButtonClicked?.Invoke(this, e);
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

        private void textBox_nome_empresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cnpj_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_telefone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_logradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_numero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_cidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
