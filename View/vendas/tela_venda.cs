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

        private void textBox_cliente_TextChanged(object sender, EventArgs e)
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

        private void textBox_pagamento_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }

        private void textBox_produto_TextChanged(object sender, EventArgs e)
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

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand c1 = new NpgsqlCommand("", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            conn.Close();
        }
    }
}
