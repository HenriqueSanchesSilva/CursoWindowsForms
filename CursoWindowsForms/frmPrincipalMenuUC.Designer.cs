namespace CursoWindowsForms
{
    partial class frmPrincipalMenuUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalMenuUC));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.válidaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.válidaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.válidaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcAplications = new System.Windows.Forms.TabControl();
            this.imlImages = new System.Windows.Forms.ImageList(this.components);
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.açõesToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.apagarAbaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.máscaraToolStripMenuItem,
            this.válidaCPFToolStripMenuItem,
            this.válidaCPF2ToolStripMenuItem,
            this.válidaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_DemonstracaoKey;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_HelloWorld;
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.helloWorldToolStripMenuItem.Text = "Hello &World";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
            // 
            // máscaraToolStripMenuItem
            // 
            this.máscaraToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Mascara;
            this.máscaraToolStripMenuItem.Name = "máscaraToolStripMenuItem";
            this.máscaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.máscaraToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.máscaraToolStripMenuItem.Text = "&Máscara";
            this.máscaraToolStripMenuItem.Click += new System.EventHandler(this.máscaraToolStripMenuItem_Click);
            // 
            // válidaCPFToolStripMenuItem
            // 
            this.válidaCPFToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF;
            this.válidaCPFToolStripMenuItem.Name = "válidaCPFToolStripMenuItem";
            this.válidaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.válidaCPFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.válidaCPFToolStripMenuItem.Text = "Válida &CPF";
            this.válidaCPFToolStripMenuItem.Click += new System.EventHandler(this.válidaCPFToolStripMenuItem_Click);
            // 
            // válidaCPF2ToolStripMenuItem
            // 
            this.válidaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF2;
            this.válidaCPF2ToolStripMenuItem.Name = "válidaCPF2ToolStripMenuItem";
            this.válidaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.válidaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.válidaCPF2ToolStripMenuItem.Text = "Válida C&PF 2";
            this.válidaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.válidaCPF2ToolStripMenuItem_Click);
            // 
            // válidaSenhaToolStripMenuItem
            // 
            this.válidaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaSenha;
            this.válidaSenhaToolStripMenuItem.Name = "válidaSenhaToolStripMenuItem";
            this.válidaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.válidaSenhaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.válidaSenhaToolStripMenuItem.Text = "Válida &Senha";
            this.válidaSenhaToolStripMenuItem.Click += new System.EventHandler(this.válidaSenhaToolStripMenuItem_Click);
            // 
            // apagarAbaToolStripMenuItem
            // 
            this.apagarAbaToolStripMenuItem.Name = "apagarAbaToolStripMenuItem";
            this.apagarAbaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarAbaToolStripMenuItem.Text = "Apagar Aba";
            this.apagarAbaToolStripMenuItem.Click += new System.EventHandler(this.apagarAbaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // tbcAplications
            // 
            this.tbcAplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAplications.Location = new System.Drawing.Point(0, 24);
            this.tbcAplications.Name = "tbcAplications";
            this.tbcAplications.SelectedIndex = 0;
            this.tbcAplications.Size = new System.Drawing.Size(800, 426);
            this.tbcAplications.TabIndex = 1;
            // 
            // imlImages
            // 
            this.imlImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlImages.ImageStream")));
            this.imlImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imlImages.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.imlImages.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.imlImages.Images.SetKeyName(2, "Frm_Mascara.png");
            this.imlImages.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.imlImages.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.imlImages.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // frmPrincipalMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcAplications);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipalMenuUC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem válidaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem válidaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem válidaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.TabControl tbcAplications;
        private System.Windows.Forms.ImageList imlImages;
        private System.Windows.Forms.ToolStripMenuItem apagarAbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
    }
}