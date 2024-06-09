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

namespace PIM3_SEMESTRE
{
    public partial class tela_fornecedor_adicionar : Form
    {
        public event EventHandler NotificacaoButtonClicked;
        public event EventHandler FornecedorButtonClicked;
        public event EventHandler VendasButtonClicked;
        public event EventHandler RelatorioButtonClicked;
        public event EventHandler ProducaoButtonClicked;
        public event EventHandler SairButtonClicked;
        public event EventHandler AddFornecedorButtonClicked;
        public event EventHandler ClientButtonClicked;
        public event EventHandler CancelButtonClicked;

        public NpgsqlConnection Connection { get; set; } = null;

        NpgsqlConnection conn = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=sistema;" +
                "Uid=postgres;" +
                "Pwd=dbadmin;");
        private string ObterEnderecoCompleto()
        {
            string logradouro = textBox_logradouro.Text;
            string numero = textBox_numero.Text;
            string cidade = textBox_cidade.Text;

            return $"{logradouro}, {numero}, {cidade}";
        }
        public tela_fornecedor_adicionar()
        {
            InitializeComponent();
        }

        private void tela_fornecedor_Load(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            OnCancelButtonClicked(EventArgs.Empty);
        }
        private void button_sair_Click(object sender, EventArgs e)
        {
            OnSairButtonClicked(EventArgs.Empty);
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
           
        }
        protected virtual void OnCancelButtonClicked(EventArgs e)
        {
            CancelButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnClientButtonClicked(EventArgs e)
        {
            ClientButtonClicked?.Invoke(this, e);
        }
        protected virtual void OnAddFornecedorButtonClicked(EventArgs e)
        {
            AddFornecedorButtonClicked?.Invoke(this, e);
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

        private void button_adicionar_Click_1(object sender, EventArgs e)
        {
            string nome = textBox_nome_empresa.Text;
            string cnpj = textBox_cnpj.Text;
            string telefone = textBox_telefone.Text;
            string endereco = ObterEnderecoCompleto();
            try
            {
                conn.Open();
                string query = "INSERT INTO fornecedor (nomeFornecedor, cnpj, telefone, enderecoFornecedor) " +
                               "VALUES (@nomefornecedor, @cnpj, @telefone, @endereco)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("nomeFornecedor", nome);
                cmd.Parameters.AddWithValue("cnpj", cnpj);
                cmd.Parameters.AddWithValue("telefone", telefone);
                cmd.Parameters.AddWithValue("endereco", endereco);


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
        }
    }
}
