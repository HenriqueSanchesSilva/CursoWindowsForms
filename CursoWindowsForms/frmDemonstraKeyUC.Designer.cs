﻿namespace CursoWindowsForms
{
    partial class frmDemonstraKeyUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemonstracaoKey));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblMaius = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(8, 8);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.Location = new System.Drawing.Point(8, 40);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(304, 232);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(328, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpa";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMinus
            // 
            this.lblMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinus.Location = new System.Drawing.Point(320, 104);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(40, 16);
            this.lblMinus.TabIndex = 3;
            this.lblMinus.Text = "Minus.";
            // 
            // lblMaius
            // 
            this.lblMaius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaius.Location = new System.Drawing.Point(320, 56);
            this.lblMaius.Name = "lblMaius";
            this.lblMaius.Size = new System.Drawing.Size(40, 16);
            this.lblMaius.TabIndex = 4;
            this.lblMaius.Text = "Maius.";
            // 
            // lblUpper
            // 
            this.lblUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpper.Location = new System.Drawing.Point(368, 56);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(32, 23);
            this.lblUpper.TabIndex = 5;
            // 
            // lblLower
            // 
            this.lblLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLower.Location = new System.Drawing.Point(368, 104);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(32, 23);
            this.lblLower.TabIndex = 6;
            // 
            // frmDemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lblMaius);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtInput);
            this.Name = "frmDemonstracaoKey";
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblMaius;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;
    }
}