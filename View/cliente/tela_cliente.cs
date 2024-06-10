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
    public partial class tela_cliente : Form
    {
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

        public tela_cliente()
        {
            InitializeComponent();
        }

        private void button_cliente_Click(object sender, EventArgs e)
        {

            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("SELECT * FROM cliente WHERE statuscliente != 0", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_clientes.DataSource = dt;
            }

            conn.Close();


        }
        private void button_remover_Click(object sender, EventArgs e)
        {
            if (dataGridView_clientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView_clientes.SelectedRows[0].Cells["idcliente"].Value);

                try
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE cliente SET statuscliente = 0 WHERE idcliente = @idcliente", conn);
                    cmd.Parameters.AddWithValue("idcliente", idCliente);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente removido com sucesso!");


                    dataGridView_clientes.Rows.RemoveAt(dataGridView_clientes.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao remover cliente: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover.");
            }
        }

        private void tela_cliente_Load(object sender, EventArgs e)
        {

        }

        private void button_notificacao_Click(object sender, EventArgs e)
        {
            OnNotificacaoButtonClicked(EventArgs.Empty);
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

        private void button_sair_Click(object sender, EventArgs e)
        {
            OnSairButtonClicked(EventArgs.Empty);
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            OnAddClientButtonClicked(EventArgs.Empty);
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

        private void button_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView_clientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView_clientes.SelectedRows[0].Cells["idcliente"].Value);

                // Abrir a tela de edição com o ID do cliente selecionado
                tela_cliente_adicionar telaEdicao = new tela_cliente_adicionar(idCliente);
                telaEdicao.Show();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }
        }
    }
}
