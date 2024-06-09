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

namespace PIM3_SEMESTRE.relatório
{
    public partial class tela_relatório_adicionar : Form
    {
        public NpgsqlConnection Connection { get; set; } = null;

        NpgsqlConnection conn = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=sistema;" +
                "Uid=postgres;" +
                "Pwd=dbadmin;");
        public tela_relatório_adicionar()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button_gerar_Click(object sender, EventArgs e)
        {
            string tipo = textBox_tipo.Text;
            string data = textBox_data.Text;

            try
            {
                conn.Open();
                string query = "SELECT *  FROM tipo WHERE data IS data";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("tipo", tipo);

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
