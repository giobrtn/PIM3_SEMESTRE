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

namespace PIM3_SEMESTRE.fornecedor
{
    public partial class tela_fornecedor1cs : Form
    {

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

            Connection.Open();

            Visible = false;

            NpgsqlCommand c1 = new NpgsqlCommand("SELECT * FROM produto", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load (dr);
                dataGridView_fornecedor.DataSource = dt;
            }

            Connection.Close();



        }

        private void dataGridView_fornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
