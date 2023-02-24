using cursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class frmValidaCpf2UC : UserControl
    {
        public frmValidaCpf2UC()
        {
            InitializeComponent();
        }
        private void btnValida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = mskCPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();

            if (vConteudo != "" && vConteudo.Length > 10)
            {
                if (MessageBox.Show("Você tem certeza do CPF informado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool ValidaCpf = false;
                    ValidaCpf = clsUteis.Valida(mskCPF.Text);
                    if (ValidaCpf == true)
                    {
                        MessageBox.Show("CPF VÁLIDO", "Valida CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Valida CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    mskCPF.Focus();
            }
            else
                MessageBox.Show("Preencha todos os campos da formulário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            mskCPF.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mskCPF.Text = "";
            mskCPF.Focus();
        }
    }
}
