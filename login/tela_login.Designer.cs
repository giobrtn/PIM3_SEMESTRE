namespace PIM3_SEMESTRE.login
{
    partial class tela_login
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(449, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 504);
            this.panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(170, 268);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 31);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(170, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 31);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 53);
            this.button2.TabIndex = 15;
            this.button2.Text = "Entrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 41);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome App";
            // 
            // tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1424, 799);
            this.Controls.Add(this.panel1);
            this.Name = "tela_login";
            this.Text = "tela_login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}