using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PIM3_SEMESTRE.DAO.conexao_banco;
using Npgsql;
using PIM3_SEMESTRE.produção;

namespace PIM3_SEMESTRE.fornecedor
{
    public partial class tela_fornecedor1cs : Form
    {
        public event EventHandler AddFornecedorButtonClicked;
        public event EventHandler NotificacaoButtonClicked;
        public event EventHandler FornecedorButtonClicked;
        public event EventHandler VendasButtonClicked;
        public event EventHandler RelatorioButtonClicked;
        public event EventHandler ProducaoButtonClicked;
        public event EventHandler SairButtonClicked;
        public event EventHandler ClienteButtonClicked;
        public NpgsqlConnection Connection { get; set; } = null;

        NpgsqlConnection conn = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=sistema;" +
                "Uid=postgres;" +
                "Pwd=dbadmin;");

        public tela_fornecedor1cs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_fornecedor_Click(object sender, EventArgs e)
        {

            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("SELECT * FROM fornecedor WHERE statusfornecedor != 0", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_fornecedor.DataSource = dt;
            }

            conn.Close();



        }

        private void button_remover_Click(object sender, EventArgs e)
        {
            if (dataGridView_fornecedor.SelectedRows.Count > 0)
            {
                int idFornecedor = Convert.ToInt32(dataGridView_fornecedor.SelectedRows[0].Cells["idfornecedor"].Value);

                try
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE fornecedor SET statusfornecedor = 0 WHERE idfornecedor = @idfornecedor", conn);
                    cmd.Parameters.AddWithValue("idfornecedor", idFornecedor);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor removido com sucesso!");

                    
                    dataGridView_fornecedor.Rows.RemoveAt(dataGridView_fornecedor.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao remover fornecedor: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para remover.");
            }
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView_fornecedor.SelectedRows.Count > 0)
            {
                int idFornecedor = Convert.ToInt32(dataGridView_fornecedor.SelectedRows[0].Cells["idfornecedor"].Value);

                // Abrir a tela de edição com o ID do fornecedor selecionado
                tela_fornecedor_adicionar telaEdicao = new tela_fornecedor_adicionar(idFornecedor);
                telaEdicao.Show();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
            }
        }

        protected virtual void OnAddFornecedorButtonClicked(EventArgs e)
        {
            AddFornecedorButtonClicked?.Invoke(this, e);
        }
        private void button_notificacao_Click(object sender, EventArgs e)
        {
            OnNotificacaoButtonClicked(EventArgs.Empty);
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
        protected virtual void OnClienteButtonClicked(EventArgs e)
        {
            ClienteButtonClicked?.Invoke(this, e);
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
        private void dataGridView_fornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tela_fornecedor1cs_Load(object sender, EventArgs e)
        {

        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            OnAddFornecedorButtonClicked(EventArgs.Empty);
        }

    }
}
