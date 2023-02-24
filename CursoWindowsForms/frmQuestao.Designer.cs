namespace CursoWindowsForms
{
    partial class frmQuestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestao));
            this.lblQuestao = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.Location = new System.Drawing.Point(18, 9);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(229, 20);
            this.lblQuestao.TabIndex = 0;
            this.lblQuestao.Text = "Você deseja validar o CPF?";
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(147, 60);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(115, 23);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "Sim, continue";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(147, 89);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(115, 23);
            this.btnNao.TabIndex = 2;
            this.btnNao.Text = "Não, pare";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::CursoWindowsForms.Properties.Resources.frmQuestion;
            this.pbxImage.Location = new System.Drawing.Point(13, 44);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(106, 95);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 3;
            this.pbxImage.TabStop = false;
            // 
            // frmQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblQuestao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.PictureBox pbxImage;
    }
}