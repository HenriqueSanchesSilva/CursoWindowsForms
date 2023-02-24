namespace CursoWindowsForms
{
    partial class frmHelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorld));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnModificaLabel = new System.Windows.Forms.Button();
            this.txtConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Visual Studio .NET Version";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(250, 265);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Fechar a aplicação";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnModificaLabel
            // 
            this.btnModificaLabel.Location = new System.Drawing.Point(34, 52);
            this.btnModificaLabel.Name = "btnModificaLabel";
            this.btnModificaLabel.Size = new System.Drawing.Size(209, 23);
            this.btnModificaLabel.TabIndex = 2;
            this.btnModificaLabel.Text = "Modifica Texto do Label";
            this.btnModificaLabel.UseVisualStyleBackColor = true;
            this.btnModificaLabel.Click += new System.EventHandler(this.btnModificaLabel_Click);
            // 
            // txtConteudoLabel
            // 
            this.txtConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConteudoLabel.Location = new System.Drawing.Point(34, 81);
            this.txtConteudoLabel.Name = "txtConteudoLabel";
            this.txtConteudoLabel.Size = new System.Drawing.Size(311, 20);
            this.txtConteudoLabel.TabIndex = 3;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(412, 300);
            this.Controls.Add(this.txtConteudoLabel);
            this.Controls.Add(this.btnModificaLabel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnModificaLabel;
        private System.Windows.Forms.TextBox txtConteudoLabel;
    }
}

