
namespace MenuForm
{
    partial class MenuForm
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnPJ = new System.Windows.Forms.Button();
            this.btnPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(58, 85);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(248, 41);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Principal";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPJ
            // 
            this.btnPJ.Image = global::MenuForm.Properties.Resources.PessoaJuridica;
            this.btnPJ.Location = new System.Drawing.Point(12, 182);
            this.btnPJ.Name = "btnPJ";
            this.btnPJ.Size = new System.Drawing.Size(155, 193);
            this.btnPJ.TabIndex = 1;
            this.btnPJ.UseVisualStyleBackColor = true;
            this.btnPJ.Click += new System.EventHandler(this.btnPJ_Click);
            // 
            // btnPF
            // 
            this.btnPF.Image = global::MenuForm.Properties.Resources.PessoaFisica;
            this.btnPF.Location = new System.Drawing.Point(206, 182);
            this.btnPF.Name = "btnPF";
            this.btnPF.Size = new System.Drawing.Size(155, 193);
            this.btnPF.TabIndex = 1;
            this.btnPF.UseVisualStyleBackColor = true;
            this.btnPF.Click += new System.EventHandler(this.btnPF_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 461);
            this.Controls.Add(this.btnPF);
            this.Controls.Add(this.btnPJ);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(389, 500);
            this.MinimumSize = new System.Drawing.Size(389, 500);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Pessoas V5.0.32";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnPJ;
        private System.Windows.Forms.Button btnPF;
    }
}

