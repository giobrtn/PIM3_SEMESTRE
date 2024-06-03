namespace PIM3_SEMESTRE.cliente
{
    partial class tela_cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_remover = new System.Windows.Forms.Button();
            this.dataGridView_clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_notificacao = new System.Windows.Forms.Button();
            this.button_producao = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_relatorio = new System.Windows.Forms.Button();
            this.button_vendas = new System.Windows.Forms.Button();
            this.button_cliente = new System.Windows.Forms.Button();
            this.button_fornecedor = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.button_editar);
            this.panel1.Controls.Add(this.button_adicionar);
            this.panel1.Controls.Add(this.button_remover);
            this.panel1.Controls.Add(this.dataGridView_clientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(354, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 497);
            this.panel1.TabIndex = 18;
            // 
            // button_editar
            // 
            this.button_editar.FlatAppearance.BorderSize = 0;
            this.button_editar.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.Location = new System.Drawing.Point(425, 442);
            this.button_editar.Margin = new System.Windows.Forms.Padding(2);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(101, 34);
            this.button_editar.TabIndex = 19;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            // 
            // button_adicionar
            // 
            this.button_adicionar.FlatAppearance.BorderSize = 0;
            this.button_adicionar.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicionar.Location = new System.Drawing.Point(567, 442);
            this.button_adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(101, 34);
            this.button_adicionar.TabIndex = 18;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            // 
            // button_remover
            // 
            this.button_remover.FlatAppearance.BorderSize = 0;
            this.button_remover.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remover.Location = new System.Drawing.Point(279, 442);
            this.button_remover.Margin = new System.Windows.Forms.Padding(2);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(101, 34);
            this.button_remover.TabIndex = 17;
            this.button_remover.Text = "Remover";
            this.button_remover.UseVisualStyleBackColor = true;
            // 
            // dataGridView_clientes
            // 
            this.dataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientes.Location = new System.Drawing.Point(47, 83);
            this.dataGridView_clientes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_clientes.Name = "dataGridView_clientes";
            this.dataGridView_clientes.RowHeadersWidth = 62;
            this.dataGridView_clientes.RowTemplate.Height = 28;
            this.dataGridView_clientes.Size = new System.Drawing.Size(621, 318);
            this.dataGridView_clientes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(110, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "Green Urban";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.button_notificacao);
            this.panel2.Controls.Add(this.button_producao);
            this.panel2.Controls.Add(this.button_sair);
            this.panel2.Controls.Add(this.button_relatorio);
            this.panel2.Controls.Add(this.button_vendas);
            this.panel2.Controls.Add(this.button_cliente);
            this.panel2.Controls.Add(this.button_fornecedor);
            this.panel2.Location = new System.Drawing.Point(46, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 497);
            this.panel2.TabIndex = 30;
            // 
            // button_notificacao
            // 
            this.button_notificacao.BackColor = System.Drawing.Color.DarkGreen;
            this.button_notificacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_notificacao.FlatAppearance.BorderSize = 0;
            this.button_notificacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_notificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_notificacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_notificacao.Image = global::PIM3_SEMESTRE.Properties.Resources.icons8_notification_alert_both_on_phone_and_tablet_pc_24;
            this.button_notificacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_notificacao.Location = new System.Drawing.Point(23, 37);
            this.button_notificacao.Margin = new System.Windows.Forms.Padding(2);
            this.button_notificacao.Name = "button_notificacao";
            this.button_notificacao.Size = new System.Drawing.Size(221, 42);
            this.button_notificacao.TabIndex = 23;
            this.button_notificacao.Text = "Notificações";
            this.button_notificacao.UseVisualStyleBackColor = false;
            // 
            // button_producao
            // 
            this.button_producao.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_producao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_producao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_producao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_producao.Location = new System.Drawing.Point(23, 365);
            this.button_producao.Margin = new System.Windows.Forms.Padding(2);
            this.button_producao.Name = "button_producao";
            this.button_producao.Size = new System.Drawing.Size(167, 42);
            this.button_producao.TabIndex = 22;
            this.button_producao.Text = "Produção";
            this.button_producao.UseVisualStyleBackColor = false;
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_sair.Location = new System.Drawing.Point(23, 426);
            this.button_sair.Margin = new System.Windows.Forms.Padding(2);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(167, 42);
            this.button_sair.TabIndex = 21;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = false;
            // 
            // button_relatorio
            // 
            this.button_relatorio.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_relatorio.Location = new System.Drawing.Point(23, 304);
            this.button_relatorio.Margin = new System.Windows.Forms.Padding(2);
            this.button_relatorio.Name = "button_relatorio";
            this.button_relatorio.Size = new System.Drawing.Size(167, 42);
            this.button_relatorio.TabIndex = 20;
            this.button_relatorio.Text = "Relatório";
            this.button_relatorio.UseVisualStyleBackColor = false;
            // 
            // button_vendas
            // 
            this.button_vendas.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vendas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_vendas.Location = new System.Drawing.Point(23, 243);
            this.button_vendas.Margin = new System.Windows.Forms.Padding(2);
            this.button_vendas.Name = "button_vendas";
            this.button_vendas.Size = new System.Drawing.Size(167, 42);
            this.button_vendas.TabIndex = 19;
            this.button_vendas.Text = "Vendas";
            this.button_vendas.UseVisualStyleBackColor = false;
            // 
            // button_cliente
            // 
            this.button_cliente.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cliente.Location = new System.Drawing.Point(23, 182);
            this.button_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.button_cliente.Name = "button_cliente";
            this.button_cliente.Size = new System.Drawing.Size(167, 42);
            this.button_cliente.TabIndex = 18;
            this.button_cliente.Text = "Clientes";
            this.button_cliente.UseVisualStyleBackColor = false;
            // 
            // button_fornecedor
            // 
            this.button_fornecedor.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_fornecedor.FlatAppearance.BorderSize = 0;
            this.button_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_fornecedor.Location = new System.Drawing.Point(23, 121);
            this.button_fornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.button_fornecedor.Name = "button_fornecedor";
            this.button_fornecedor.Size = new System.Drawing.Size(167, 42);
            this.button_fornecedor.TabIndex = 17;
            this.button_fornecedor.Text = "Fornecedores";
            this.button_fornecedor.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Image = global::PIM3_SEMESTRE.Properties.Resources.icons8_organic_food_48;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(46, 29);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 48);
            this.button11.TabIndex = 35;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // tela_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1105, 646);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tela_cliente";
            this.Text = "tela_cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_remover;
        private System.Windows.Forms.DataGridView dataGridView_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_notificacao;
        private System.Windows.Forms.Button button_producao;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_relatorio;
        private System.Windows.Forms.Button button_vendas;
        private System.Windows.Forms.Button button_cliente;
        private System.Windows.Forms.Button button_fornecedor;
        private System.Windows.Forms.Button button11;
    }
}