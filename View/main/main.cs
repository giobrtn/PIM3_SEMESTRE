using PIM3_SEMESTRE.cliente;
using PIM3_SEMESTRE.login;
using PIM3_SEMESTRE.notificações;
using PIM3_SEMESTRE.produção;
using PIM3_SEMESTRE.relatório;
using PIM3_SEMESTRE.vendas;
using PIM3_SEMESTRE.fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3_SEMESTRE.View.main
{
    public partial class Form1 : Form
    {
        private Form currentForm;
        private Stack<Form> formHistory = new Stack<Form>();
        public Form1()
        {
            InitializeComponent();
            InitializeTelaLogin();
        }

        private void InitializeTelaLogin()
        {
            tela_login loginForm = new tela_login();
            loginForm.LoginSuccessful += OnLoginSuccessful;
            ShowFormInPanel(loginForm); // Exibe a tela de login
        }

        private void OnLoginSuccessful(object sender, EventArgs e)
        {
            tela_notificações notificacoesForm = new tela_notificações();
            notificacoesForm.FornecedorButtonClicked += OnFornecedorButtonClicked;
            notificacoesForm.ClienteButtonClicked += OnClienteButtonClicked;
            notificacoesForm.VendasButtonClicked += OnVendasButtonClicked;
            notificacoesForm.RelatorioButtonClicked += OnRelatorioButtonClicked;
            notificacoesForm.ProducaoButtonClicked += OnProducaoButtonClicked;
            notificacoesForm.SairButtonClicked += OnSairButtonClicked;
            ShowFormInPanel(notificacoesForm);
        }

        private void OnClienteButtonClicked(object sender, EventArgs e)
        {
            tela_cliente clienteForm = new tela_cliente();
            clienteForm.FornecedorButtonClicked += OnFornecedorButtonClicked;
            clienteForm.NotificacaoButtonClicked += OnNotificacaoButtonClicked;
            clienteForm.VendasButtonClicked += OnVendasButtonClicked;
            clienteForm.RelatorioButtonClicked += OnRelatorioButtonClicked;
            clienteForm.ProducaoButtonClicked += OnProducaoButtonClicked;
            clienteForm.SairButtonClicked += OnSairButtonClicked;
            clienteForm.AddClientButtonClicked += OnAddClientButtonClicked;
            ShowFormInPanel(clienteForm);
        }

        private void OnNotificacaoButtonClicked(object sender, EventArgs e)
        {
            tela_notificações notificacoesForm = new tela_notificações();
            notificacoesForm.FornecedorButtonClicked += OnFornecedorButtonClicked;
            notificacoesForm.ClienteButtonClicked += OnClienteButtonClicked;
            notificacoesForm.VendasButtonClicked += OnVendasButtonClicked;
            notificacoesForm.RelatorioButtonClicked += OnRelatorioButtonClicked;
            notificacoesForm.ProducaoButtonClicked += OnProducaoButtonClicked;
            notificacoesForm.SairButtonClicked += OnSairButtonClicked;
            ShowFormInPanel(notificacoesForm);
        }
        private void OnFornecedorButtonClicked(object sender, EventArgs e) 
        {
            tela_fornecedor1cs fornecedorForm = new tela_fornecedor1cs();
            fornecedorForm.AddFornecedorButtonClicked += OnAddFornecedorButtonClicked;
            fornecedorForm.NotificacaoButtonClicked += OnNotificacaoButtonClicked;
            fornecedorForm.VendasButtonClicked += OnVendasButtonClicked;
            fornecedorForm.RelatorioButtonClicked += OnRelatorioButtonClicked;
            fornecedorForm.ProducaoButtonClicked += OnProducaoButtonClicked;
            fornecedorForm.SairButtonClicked += OnSairButtonClicked;
            
            ShowFormInPanel(fornecedorForm);
        }
        private void OnAddFornecedorButtonClicked(object sender, EventArgs e)
        {
            tela_fornecedor_adicionar addFornecedorForm = new tela_fornecedor_adicionar();
            addFornecedorForm.FornecedorButtonClicked += OnFornecedorButtonClicked;
            addFornecedorForm.NotificacaoButtonClicked += OnNotificacaoButtonClicked;
            addFornecedorForm.VendasButtonClicked += OnVendasButtonClicked;
            addFornecedorForm.RelatorioButtonClicked += OnRelatorioButtonClicked;
            addFornecedorForm.ProducaoButtonClicked += OnProducaoButtonClicked;
            addFornecedorForm.SairButtonClicked += OnSairButtonClicked;
            addFornecedorForm.CancelButtonClicked += OnCancelButtonClicked;
            ShowFormInPanel(addFornecedorForm);
        }
        private void OnVendasButtonClicked(object sender, EventArgs e)
        {
            tela_venda vendasForm = new tela_venda();
            ShowFormInPanel(vendasForm);
        }
        
        private void OnRelatorioButtonClicked(object sender, EventArgs e)
        {
            tela_relatório relatorioForm = new tela_relatório();
            ShowFormInPanel(relatorioForm);
        }

        private void OnProducaoButtonClicked(object sender, EventArgs e)
        {
            tela_producao producaoForm = new tela_producao();
            ShowFormInPanel(producaoForm);
        }

        private void OnAddClientButtonClicked(object sender, EventArgs e)
        {
            tela_cliente_adicionar addClienteForm = new tela_cliente_adicionar();
            addClienteForm.FornecedorButtonClicked += OnFornecedorButtonClicked;
            addClienteForm.NotificacaoButtonClicked += OnNotificacaoButtonClicked;
            addClienteForm.VendasButtonClicked += OnVendasButtonClicked;
            addClienteForm.RelatorioButtonClicked += OnRelatorioButtonClicked;
            addClienteForm.ProducaoButtonClicked += OnProducaoButtonClicked;
            addClienteForm.SairButtonClicked += OnSairButtonClicked;
            addClienteForm.CancelButtonClicked += OnCancelButtonClicked;
            ShowFormInPanel(addClienteForm);
        }
        private void OnSairButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            ShowPreviousForm();
        }

        private void ShowFormInPanel(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                panel1_main.Controls.Remove(currentForm);
            }

            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            panel1_main.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();
        }

        private void ShowPreviousForm()
        {
            if (formHistory.Count > 0)
            {
                Form previousForm = formHistory.Pop(); // Recupera o último formulário do histórico
                ShowFormInPanel(previousForm);
            }
        }
    }
}
