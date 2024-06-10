﻿using Npgsql;
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

        private int idFornecedor;
        
        public tela_fornecedor_adicionar(int idFornecedor = -1)
        {
            InitializeComponent();
            this.idFornecedor = idFornecedor;
            if (idFornecedor != -1)
            {

                CarregarDetalhesFornecedor(idFornecedor);

            }

        }

        private string ObterEnderecoCompleto()
        {
            string logradouro = textBox_logradouro.Text;
            string numero = textBox_numero.Text;
            string cidade = textBox_cidade.Text;

            return $"{logradouro}, {numero}, {cidade}";
        }

        private void CarregarDetalhesFornecedor(int idFornecedor)
        {

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM fornecedor WHERE idfornecedor = @idfornecedor", conn);
                cmd.Parameters.AddWithValue("idfornecedor", idFornecedor);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    textBox_nome_empresa.Text = reader["nomefornecedor"].ToString();
                    textBox_cnpj.Text = reader["cnpj"].ToString();
                    textBox_telefone.Text = reader["telefone"].ToString();
                    string[] enderecoParts = reader["enderecofornecedor"].ToString().Split(',');
                    if (enderecoParts.Length == 3)
                    {
                        textBox_logradouro.Text = enderecoParts[0].Trim();
                        textBox_numero.Text = enderecoParts[1].Trim();
                        textBox_cidade.Text = enderecoParts[2].Trim();
                    }

                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do fornecedor: " + ex.Message);
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
                if (idFornecedor != -1)
                {
                    // Update query
                    string updateQuery = "UPDATE fornecedor SET nomefornecedor = @nomefornecedor, cnpj = @cnpj, telefone = @telefone, enderecofornecedor = @endereco, statusfornecedor = @status WHERE idfornecedor = @idfornecedor";
                    cmd = new NpgsqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("idfornecedor", idFornecedor);
                }
                else
                {
                    // Insert query
                    string insertQuery = "INSERT INTO fornecedor (nomefornecedor, cnpj, telefone, enderecofornecedor, statusfornecedor) " +
                                         "VALUES (@nomefornecedor, @cnpj, @telefone, @endereco, @status)";
                    cmd = new NpgsqlCommand(insertQuery, conn);
                }

                cmd.Parameters.AddWithValue("nomefornecedor", nome);
                cmd.Parameters.AddWithValue("cnpj", cnpj);
                cmd.Parameters.AddWithValue("telefone", telefone);
                cmd.Parameters.AddWithValue("endereco", endereco);
                cmd.Parameters.AddWithValue("status", 1);

                cmd.ExecuteNonQuery();
                MessageBox.Show(idFornecedor != -1 ? "Fornecedor atualizado com sucesso!" : "Fornecedor adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar/atualizar fornecedor: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

    }
}
