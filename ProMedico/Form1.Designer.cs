namespace ProMedico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeSintoma = new System.Windows.Forms.TextBox();
            this.btnNovoSintoma = new System.Windows.Forms.Button();
            this.btnSalvarDoenca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chklSintomasCadastro = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDoenca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVerificarSintomas = new System.Windows.Forms.Button();
            this.chklSintomas = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvarDoenca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chklSintomasCadastro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeDoenca);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Doença";
            // 
            // txtNomeSintoma
            // 
            this.txtNomeSintoma.Location = new System.Drawing.Point(11, 27);
            this.txtNomeSintoma.Name = "txtNomeSintoma";
            this.txtNomeSintoma.Size = new System.Drawing.Size(298, 22);
            this.txtNomeSintoma.TabIndex = 6;
            // 
            // btnNovoSintoma
            // 
            this.btnNovoSintoma.Location = new System.Drawing.Point(315, 21);
            this.btnNovoSintoma.Name = "btnNovoSintoma";
            this.btnNovoSintoma.Size = new System.Drawing.Size(137, 32);
            this.btnNovoSintoma.TabIndex = 5;
            this.btnNovoSintoma.Text = "Novo Síntoma";
            this.btnNovoSintoma.UseVisualStyleBackColor = true;
            this.btnNovoSintoma.Click += new System.EventHandler(this.BtnNovoSintoma_Click);
            // 
            // btnSalvarDoenca
            // 
            this.btnSalvarDoenca.Location = new System.Drawing.Point(587, 141);
            this.btnSalvarDoenca.Name = "btnSalvarDoenca";
            this.btnSalvarDoenca.Size = new System.Drawing.Size(75, 67);
            this.btnSalvarDoenca.TabIndex = 4;
            this.btnSalvarDoenca.Text = "Salvar";
            this.btnSalvarDoenca.UseVisualStyleBackColor = true;
            this.btnSalvarDoenca.Click += new System.EventHandler(this.BtnSalvarDoenca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Síntomas";
            // 
            // chklSintomasCadastro
            // 
            this.chklSintomasCadastro.FormattingEnabled = true;
            this.chklSintomasCadastro.Location = new System.Drawing.Point(10, 85);
            this.chklSintomasCadastro.Name = "chklSintomasCadastro";
            this.chklSintomasCadastro.Size = new System.Drawing.Size(444, 89);
            this.chklSintomasCadastro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da doença";
            // 
            // txtNomeDoenca
            // 
            this.txtNomeDoenca.Location = new System.Drawing.Point(129, 22);
            this.txtNomeDoenca.Name = "txtNomeDoenca";
            this.txtNomeDoenca.Size = new System.Drawing.Size(325, 22);
            this.txtNomeDoenca.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnVerificarSintomas);
            this.groupBox2.Controls.Add(this.chklSintomas);
            this.groupBox2.Location = new System.Drawing.Point(701, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 440);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Síntomas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResultado);
            this.groupBox3.Location = new System.Drawing.Point(6, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 37);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 0;
            // 
            // btnVerificarSintomas
            // 
            this.btnVerificarSintomas.Location = new System.Drawing.Point(591, 141);
            this.btnVerificarSintomas.Name = "btnVerificarSintomas";
            this.btnVerificarSintomas.Size = new System.Drawing.Size(75, 39);
            this.btnVerificarSintomas.TabIndex = 1;
            this.btnVerificarSintomas.Text = "Verificar";
            this.btnVerificarSintomas.UseVisualStyleBackColor = true;
            this.btnVerificarSintomas.Click += new System.EventHandler(this.BtnVerificarSintomas_Click);
            // 
            // chklSintomas
            // 
            this.chklSintomas.FormattingEnabled = true;
            this.chklSintomas.Location = new System.Drawing.Point(6, 22);
            this.chklSintomas.Name = "chklSintomas";
            this.chklSintomas.Size = new System.Drawing.Size(660, 106);
            this.chklSintomas.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNomeSintoma);
            this.groupBox4.Controls.Add(this.btnNovoSintoma);
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(455, 65);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadastro Sintomas";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(13, 314);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(668, 139);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.GroupBox5_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weverton Neves do Couto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "1811514291";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "RA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 465);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovoSintoma;
        private System.Windows.Forms.Button btnSalvarDoenca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chklSintomasCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDoenca;
        private System.Windows.Forms.TextBox txtNomeSintoma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerificarSintomas;
        private System.Windows.Forms.CheckedListBox chklSintomas;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

