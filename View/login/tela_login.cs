using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3_SEMESTRE.login
{
    public partial class tela_login : Form
    {
        public event EventHandler LoginSuccessful;
        public tela_login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void limparCampos() { textBox_login.Text = ""; textBox_senha.Text = "";}
        private void button_entrar_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "admin" && textBox_senha.Text == "admin")
            {
                
                MessageBox.Show("Login efetuado com sucesso!");
                OnLoginSuccessful(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
                limparCampos();
            }
        }
        protected virtual void OnLoginSuccessful(EventArgs e)
        {
            LoginSuccessful?.Invoke(this, e);
        }
    }
}
