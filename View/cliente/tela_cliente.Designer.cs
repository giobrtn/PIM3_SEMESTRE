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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_clientes = new System.Windows.Forms.DataGridView();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_remover = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.dataGridView_clientes);
            this.panel1.Controls.Add(this.button_editar);
            this.panel1.Controls.Add(this.button_adicionar);
            this.panel1.Controls.Add(this.button_remover);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(531, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 765);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView_clientes
            // 
            this.dataGridView_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_clientes.EnableHeadersVisualStyles = false;
            this.dataGridView_clientes.GridColor = System.Drawing.Color.Black;
            this.dataGridView_clientes.Location = new System.Drawing.Point(68, 137);
            this.dataGridView_clientes.MultiSelect = false;
            this.dataGridView_clientes.Name = "dataGridView_clientes";
            this.dataGridView_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_clientes.RowHeadersVisible = false;
            this.dataGridView_clientes.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridView_clientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_clientes.RowTemplate.Height = 28;
            this.dataGridView_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_clientes.Size = new System.Drawing.Size(932, 489);
            this.dataGridView_clientes.TabIndex = 20;
            // 
            // button_editar
            // 
            this.button_editar.FlatAppearance.BorderSize = 0;
            this.button_editar.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.Location = new System.Drawing.Point(638, 680);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(152, 52);
            this.button_editar.TabIndex = 19;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_adicionar
            // 
            this.button_adicionar.FlatAppearance.BorderSize = 0;
            this.button_adicionar.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicionar.Location = new System.Drawing.Point(850, 680);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(152, 52);
            this.button_adicionar.TabIndex = 18;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // button_remover
            // 
            this.button_remover.FlatAppearance.BorderSize = 0;
            this.button_remover.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remover.Location = new System.Drawing.Point(418, 680);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(152, 52);
            this.button_remover.TabIndex = 17;
            this.button_remover.Text = "Remover";
            this.button_remover.UseVisualStyleBackColor = true;
            this.button_remover.Click += new System.EventHandler(this.button_remover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(165, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 41);
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
            this.panel2.Location = new System.Drawing.Point(69, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 765);
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
            this.button_notificacao.Location = new System.Drawing.Point(34, 57);
            this.button_notificacao.Name = "button_notificacao";
            this.button_notificacao.Size = new System.Drawing.Size(332, 65);
            this.button_notificacao.TabIndex = 23;
            this.button_notificacao.Text = "Notificações";
            this.button_notificacao.UseVisualStyleBackColor = false;
            this.button_notificacao.Click += new System.EventHandler(this.button_notificacao_Click);
            // 
            // button_producao
            // 
            this.button_producao.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_producao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_producao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_producao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_producao.Location = new System.Drawing.Point(34, 562);
            this.button_producao.Name = "button_producao";
            this.button_producao.Size = new System.Drawing.Size(250, 65);
            this.button_producao.TabIndex = 22;
            this.button_producao.Text = "Produção";
            this.button_producao.UseVisualStyleBackColor = false;
            this.button_producao.Click += new System.EventHandler(this.button_producao_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_sair.Location = new System.Drawing.Point(34, 655);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(250, 65);
            this.button_sair.TabIndex = 21;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_relatorio
            // 
            this.button_relatorio.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_relatorio.Location = new System.Drawing.Point(34, 468);
            this.button_relatorio.Name = "button_relatorio";
            this.button_relatorio.Size = new System.Drawing.Size(250, 65);
            this.button_relatorio.TabIndex = 20;
            this.button_relatorio.Text = "Relatório";
            this.button_relatorio.UseVisualStyleBackColor = false;
            this.button_relatorio.Click += new System.EventHandler(this.button_relatorio_Click);
            // 
            // button_vendas
            // 
            this.button_vendas.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vendas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_vendas.Location = new System.Drawing.Point(34, 374);
            this.button_vendas.Name = "button_vendas";
            this.button_vendas.Size = new System.Drawing.Size(250, 65);
            this.button_vendas.TabIndex = 19;
            this.button_vendas.Text = "Vendas";
            this.button_vendas.UseVisualStyleBackColor = false;
            this.button_vendas.Click += new System.EventHandler(this.button_vendas_Click);
            // 
            // button_cliente
            // 
            this.button_cliente.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cliente.Location = new System.Drawing.Point(34, 280);
            this.button_cliente.Name = "button_cliente";
            this.button_cliente.Size = new System.Drawing.Size(250, 65);
            this.button_cliente.TabIndex = 18;
            this.button_cliente.Text = "Clientes";
            this.button_cliente.UseVisualStyleBackColor = false;
            this.button_cliente.Click += new System.EventHandler(this.button_cliente_Click);
            // 
            // button_fornecedor
            // 
            this.button_fornecedor.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_fornecedor.FlatAppearance.BorderSize = 0;
            this.button_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_fornecedor.Location = new System.Drawing.Point(34, 186);
            this.button_fornecedor.Name = "button_fornecedor";
            this.button_fornecedor.Size = new System.Drawing.Size(250, 65);
            this.button_fornecedor.TabIndex = 17;
            this.button_fornecedor.Text = "Fornecedores";
            this.button_fornecedor.UseVisualStyleBackColor = false;
            this.button_fornecedor.Click += new System.EventHandler(this.button_fornecedor_Click);
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
            this.button11.Location = new System.Drawing.Point(69, 45);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 74);
            this.button11.TabIndex = 35;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // tela_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1658, 994);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "tela_cliente";
            this.Text = "tela_cliente";
            this.Load += new System.EventHandler(this.tela_cliente_Load);
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
        private System.Windows.Forms.DataGridView dataGridView_clientes;
    }
}