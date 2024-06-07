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
    public partial class tela_producao : Form
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


        public tela_producao()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button_producao_Click(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("SELECT * FROM fornecedor", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_producao.DataSource = dt;
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

       

        protected virtual void OnSairButtonClicked(EventArgs e)
        {
            SairButtonClicked?.Invoke(this, e);
        }

    }
    
}
