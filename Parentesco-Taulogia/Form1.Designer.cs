namespace Parentesco_Taulogia
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
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboParentesco = new System.Windows.Forms.ComboBox();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(12, 12);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(524, 426);
            this.txtLista.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(561, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 22);
            this.txtNome.TabIndex = 1;
            // 
            // cboParentesco
            // 
            this.cboParentesco.FormattingEnabled = true;
            this.cboParentesco.Location = new System.Drawing.Point(774, 12);
            this.cboParentesco.Name = "cboParentesco";
            this.cboParentesco.Size = new System.Drawing.Size(121, 24);
            this.cboParentesco.TabIndex = 2;
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(922, 14);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(183, 22);
            this.txtNome2.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(696, 55);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 46);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(869, 55);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(88, 44);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.cboParentesco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboParentesco;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVerificar;
    }
}

