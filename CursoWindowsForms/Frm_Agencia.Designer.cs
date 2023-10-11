using CursoWindowsFormsBiblioteca;

namespace CursoWindowsForms
{
    partial class Frm_Agencia
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
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.ApagatoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.byteBankDataSet = new CursoWindowsForms.ByteBankDataSet();
            this.tb_AgenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_AgenciaTableAdapter = new CursoWindowsForms.ByteBankDataSetTableAdapters.Tb_AgenciaTableAdapter();
            this.tableAdapterManager = new CursoWindowsForms.ByteBankDataSetTableAdapters.TableAdapterManager();
            this.tb_AgenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tls_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_AgenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_AgenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApagatoolStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(562, 25);
            this.Tls_Principal.TabIndex = 57;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // ApagatoolStripButton
            // 
            this.ApagatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ApagatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton.Name = "ApagatoolStripButton";
            this.ApagatoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton.Text = "toolStripButton1";
            this.ApagatoolStripButton.Click += new System.EventHandler(this.ApagatoolStripButton_Click);
            // 
            // byteBankDataSet
            // 
            this.byteBankDataSet.DataSetName = "ByteBankDataSet";
            this.byteBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_AgenciaBindingSource
            // 
            this.tb_AgenciaBindingSource.DataMember = "Tb_Agencia";
            this.tb_AgenciaBindingSource.DataSource = this.byteBankDataSet;
            // 
            // tb_AgenciaTableAdapter
            // 
            this.tb_AgenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Tb_AgenciaTableAdapter = this.tb_AgenciaTableAdapter;
            this.tableAdapterManager.Tb_ClienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CursoWindowsForms.ByteBankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_AgenciaDataGridView
            // 
            this.tb_AgenciaDataGridView.AutoGenerateColumns = false;
            this.tb_AgenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_AgenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.tb_AgenciaDataGridView.DataSource = this.tb_AgenciaBindingSource;
            this.tb_AgenciaDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tb_AgenciaDataGridView.Name = "tb_AgenciaDataGridView";
            this.tb_AgenciaDataGridView.Size = new System.Drawing.Size(562, 333);
            this.tb_AgenciaDataGridView.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Agencia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo da Agencia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome da Agencia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // Frm_Agencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.tb_AgenciaDataGridView);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Agencia";
            this.Text = "Frm_Busca";
            this.Load += new System.EventHandler(this.Frm_Agencia_Load);
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_AgenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_AgenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton;
        private ByteBankDataSet byteBankDataSet;
        private System.Windows.Forms.BindingSource tb_AgenciaBindingSource;
        private ByteBankDataSetTableAdapters.Tb_AgenciaTableAdapter tb_AgenciaTableAdapter;
        private ByteBankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView tb_AgenciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}