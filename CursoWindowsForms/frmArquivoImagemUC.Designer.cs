namespace CursoWindowsForms
{
    partial class frmArquivoImagemUC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArquivoImagem = new System.Windows.Forms.Label();
            this.btnCor = new System.Windows.Forms.Button();
            this.btnFonte = new System.Windows.Forms.Button();
            this.picArquivoImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArquivoImagem
            // 
            this.lblArquivoImagem.AutoSize = true;
            this.lblArquivoImagem.Location = new System.Drawing.Point(17, 36);
            this.lblArquivoImagem.Name = "lblArquivoImagem";
            this.lblArquivoImagem.Size = new System.Drawing.Size(35, 13);
            this.lblArquivoImagem.TabIndex = 0;
            this.lblArquivoImagem.Text = "label1";
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(20, 4);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(75, 23);
            this.btnCor.TabIndex = 1;
            this.btnCor.Text = "Cor";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // btnFonte
            // 
            this.btnFonte.Location = new System.Drawing.Point(101, 4);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(75, 23);
            this.btnFonte.TabIndex = 2;
            this.btnFonte.Text = "Fonte";
            this.btnFonte.UseVisualStyleBackColor = true;
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // picArquivoImagem
            // 
            this.picArquivoImagem.Location = new System.Drawing.Point(20, 76);
            this.picArquivoImagem.Name = "picArquivoImagem";
            this.picArquivoImagem.Size = new System.Drawing.Size(209, 106);
            this.picArquivoImagem.TabIndex = 3;
            this.picArquivoImagem.TabStop = false;
            // 
            // frmArquivoImagemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picArquivoImagem);
            this.Controls.Add(this.btnFonte);
            this.Controls.Add(this.btnCor);
            this.Controls.Add(this.lblArquivoImagem);
            this.Name = "frmArquivoImagemUC";
            this.Size = new System.Drawing.Size(548, 290);
            ((System.ComponentModel.ISupportInitialize)(this.picArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArquivoImagem;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.Button btnFonte;
        private System.Windows.Forms.PictureBox picArquivoImagem;
    }
}
