namespace CursoWindowsForms
{
    partial class frmHelloWorldUC
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
            this.txtConteudoLabel = new System.Windows.Forms.TextBox();
            this.btnModificaLabel = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConteudoLabel
            // 
            this.txtConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConteudoLabel.Location = new System.Drawing.Point(26, 77);
            this.txtConteudoLabel.Name = "txtConteudoLabel";
            this.txtConteudoLabel.Size = new System.Drawing.Size(602, 20);
            this.txtConteudoLabel.TabIndex = 6;
            // 
            // btnModificaLabel
            // 
            this.btnModificaLabel.Location = new System.Drawing.Point(26, 48);
            this.btnModificaLabel.Name = "btnModificaLabel";
            this.btnModificaLabel.Size = new System.Drawing.Size(209, 23);
            this.btnModificaLabel.TabIndex = 5;
            this.btnModificaLabel.Text = "Modifica Texto do Label";
            this.btnModificaLabel.UseVisualStyleBackColor = true;
            this.btnModificaLabel.Click += new System.EventHandler(this.btnModificaLabel_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 19);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Visual Studio .NET Version";
            // 
            // frmHelloWorldUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtConteudoLabel);
            this.Controls.Add(this.btnModificaLabel);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmHelloWorldUC";
            this.Size = new System.Drawing.Size(663, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConteudoLabel;
        private System.Windows.Forms.Button btnModificaLabel;
        private System.Windows.Forms.Label lblTitulo;
    }
}
