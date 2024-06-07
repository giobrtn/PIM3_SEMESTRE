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

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_categoria_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_tipo_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox4_estacao_preferencial_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_data_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_fornecedor_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_quantidade_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_preco_inicial_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_preco_final_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }
    }
}
