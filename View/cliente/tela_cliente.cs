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

            NpgsqlCommand c1 = new NpgsqlCommand("SELECT * FROM cliente", conn);

            NpgsqlDataReader dr = c1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_clientes.DataSource = dt;
            }

            conn.Close();


        }

        private void tela_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
