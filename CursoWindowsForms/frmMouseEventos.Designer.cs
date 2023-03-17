namespace CursoWindowsForms
{
    partial class frmMouseEventos
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
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(195, 135);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(368, 215);
            this.btnName.TabIndex = 0;
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnName_MouseDown);
            this.btnName.MouseEnter += new System.EventHandler(this.btnName_MouseEnter);
            this.btnName.MouseLeave += new System.EventHandler(this.btnName_MouseLeave);
            this.btnName.MouseHover += new System.EventHandler(this.btnName_MouseHover);
            this.btnName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnName_MouseUp);
            // 
            // frmMouseEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnName);
            this.Name = "frmMouseEventos";
            this.Text = "frmMouseEventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnName;
    }
}