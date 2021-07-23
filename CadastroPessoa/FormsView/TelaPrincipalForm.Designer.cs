
namespace FormsView
{
    partial class TelaPrincipalForm
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Location = new System.Drawing.Point(134, 152);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(214, 36);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Menu Principal";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.BackColor = System.Drawing.SystemColors.Window;
            this.btnPessoaFisica.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPessoaFisica.Location = new System.Drawing.Point(178, 237);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(120, 23);
            this.btnPessoaFisica.TabIndex = 1;
            this.btnPessoaFisica.Text = "Pessoa Física";
            this.btnPessoaFisica.UseVisualStyleBackColor = false;
            this.btnPessoaFisica.Click += new System.EventHandler(this.btnPessoaFisica_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(178, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pessoa Jurídica";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPessoaFisica);
            this.Controls.Add(this.lbTitulo);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "TelaPrincipalForm";
            this.Load += new System.EventHandler(this.TelaPrincipalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();


        }



        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Button button1;
    }
}

