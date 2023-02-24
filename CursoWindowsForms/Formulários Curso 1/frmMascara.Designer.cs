namespace CursoWindowsForms
{
    partial class frmMascara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMascara));
            this.mskTxt = new System.Windows.Forms.MaskedTextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.lblMascaraAtiva = new System.Windows.Forms.Label();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnCEP = new System.Windows.Forms.Button();
            this.btnMoeda = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnSenha = new System.Windows.Forms.Button();
            this.btnTelefone = new System.Windows.Forms.Button();
            this.btnVerConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTxt
            // 
            this.mskTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.mskTxt.Location = new System.Drawing.Point(23, 31);
            this.mskTxt.Name = "mskTxt";
            this.mskTxt.Size = new System.Drawing.Size(258, 26);
            this.mskTxt.TabIndex = 0;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.Location = new System.Drawing.Point(23, 246);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(0, 19);
            this.lblConteudo.TabIndex = 1;
            // 
            // lblMascaraAtiva
            // 
            this.lblMascaraAtiva.AutoSize = true;
            this.lblMascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.lblMascaraAtiva.Name = "lblMascaraAtiva";
            this.lblMascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.lblMascaraAtiva.TabIndex = 2;
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(23, 110);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(82, 37);
            this.btnHora.TabIndex = 3;
            this.btnHora.Text = "Hora";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(111, 110);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(82, 37);
            this.btnCEP.TabIndex = 4;
            this.btnCEP.Text = "CEP";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // btnMoeda
            // 
            this.btnMoeda.Location = new System.Drawing.Point(199, 110);
            this.btnMoeda.Name = "btnMoeda";
            this.btnMoeda.Size = new System.Drawing.Size(82, 37);
            this.btnMoeda.TabIndex = 5;
            this.btnMoeda.Text = "Moeda";
            this.btnMoeda.UseVisualStyleBackColor = true;
            this.btnMoeda.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(23, 153);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(82, 37);
            this.btnData.TabIndex = 6;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnSenha
            // 
            this.btnSenha.Location = new System.Drawing.Point(111, 153);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(82, 37);
            this.btnSenha.TabIndex = 7;
            this.btnSenha.Text = "Senha";
            this.btnSenha.UseVisualStyleBackColor = true;
            this.btnSenha.Click += new System.EventHandler(this.btnSenha_Click);
            // 
            // btnTelefone
            // 
            this.btnTelefone.Location = new System.Drawing.Point(199, 153);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(82, 37);
            this.btnTelefone.TabIndex = 8;
            this.btnTelefone.Text = "Telefone";
            this.btnTelefone.UseVisualStyleBackColor = true;
            this.btnTelefone.Click += new System.EventHandler(this.btnTelefone_Click);
            // 
            // btnVerConteudo
            // 
            this.btnVerConteudo.Location = new System.Drawing.Point(23, 196);
            this.btnVerConteudo.Name = "btnVerConteudo";
            this.btnVerConteudo.Size = new System.Drawing.Size(258, 37);
            this.btnVerConteudo.TabIndex = 9;
            this.btnVerConteudo.Text = "Ver Conteúdo";
            this.btnVerConteudo.UseVisualStyleBackColor = true;
            this.btnVerConteudo.Click += new System.EventHandler(this.btnVerConteudo_Click);
            // 
            // frmMascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.btnVerConteudo);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnMoeda);
            this.Controls.Add(this.btnCEP);
            this.Controls.Add(this.btnHora);
            this.Controls.Add(this.lblMascaraAtiva);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.mskTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos Máscaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTxt;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Label lblMascaraAtiva;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.Button btnMoeda;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.Button btnTelefone;
        private System.Windows.Forms.Button btnVerConteudo;
    }
}