namespace CursoWindowsForms
{
    partial class frmPrincipal
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
            this.btnDemonstraKey = new System.Windows.Forms.Button();
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnMascara = new System.Windows.Forms.Button();
            this.btnValidaCPF = new System.Windows.Forms.Button();
            this.btnValidaCPF2 = new System.Windows.Forms.Button();
            this.btnValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemonstraKey
            // 
            this.btnDemonstraKey.Location = new System.Drawing.Point(12, 12);
            this.btnDemonstraKey.Name = "btnDemonstraKey";
            this.btnDemonstraKey.Size = new System.Drawing.Size(114, 48);
            this.btnDemonstraKey.TabIndex = 0;
            this.btnDemonstraKey.Text = "Demonstração Key";
            this.btnDemonstraKey.UseVisualStyleBackColor = true;
            this.btnDemonstraKey.Click += new System.EventHandler(this.btnDemonstraKey_Click);
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(132, 12);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(114, 48);
            this.btnHelloWorld.TabIndex = 1;
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // btnMascara
            // 
            this.btnMascara.Location = new System.Drawing.Point(252, 12);
            this.btnMascara.Name = "btnMascara";
            this.btnMascara.Size = new System.Drawing.Size(114, 48);
            this.btnMascara.TabIndex = 2;
            this.btnMascara.Text = "Máscara";
            this.btnMascara.UseVisualStyleBackColor = true;
            this.btnMascara.Click += new System.EventHandler(this.btnMascara_Click);
            // 
            // btnValidaCPF
            // 
            this.btnValidaCPF.Location = new System.Drawing.Point(12, 66);
            this.btnValidaCPF.Name = "btnValidaCPF";
            this.btnValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.btnValidaCPF.TabIndex = 3;
            this.btnValidaCPF.Text = "Válida CPF";
            this.btnValidaCPF.UseVisualStyleBackColor = true;
            this.btnValidaCPF.Click += new System.EventHandler(this.btnValidaCPF_Click);
            // 
            // btnValidaCPF2
            // 
            this.btnValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.btnValidaCPF2.Name = "btnValidaCPF2";
            this.btnValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.btnValidaCPF2.TabIndex = 4;
            this.btnValidaCPF2.Text = "Válida CPF 2";
            this.btnValidaCPF2.UseVisualStyleBackColor = true;
            this.btnValidaCPF2.Click += new System.EventHandler(this.btnValidaCPF2_Click);
            // 
            // btnValidaSenha
            // 
            this.btnValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.btnValidaSenha.Name = "btnValidaSenha";
            this.btnValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.btnValidaSenha.TabIndex = 5;
            this.btnValidaSenha.Text = "Válida Senha";
            this.btnValidaSenha.UseVisualStyleBackColor = true;
            this.btnValidaSenha.Click += new System.EventHandler(this.btnValidaSenha_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.btnValidaSenha);
            this.Controls.Add(this.btnValidaCPF2);
            this.Controls.Add(this.btnValidaCPF);
            this.Controls.Add(this.btnMascara);
            this.Controls.Add(this.btnHelloWorld);
            this.Controls.Add(this.btnDemonstraKey);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemonstraKey;
        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnMascara;
        private System.Windows.Forms.Button btnValidaCPF;
        private System.Windows.Forms.Button btnValidaCPF2;
        private System.Windows.Forms.Button btnValidaSenha;
    }
}