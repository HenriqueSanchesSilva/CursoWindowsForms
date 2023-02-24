using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cursoWindowsFormsBiblioteca;

namespace CursoWindowsForms
{
    public partial class frmValidaCPF : Form
    {
        public frmValidaCPF()
        {
            InitializeComponent();
        }

        private void btnValida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = mskCPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();
            

            if (vConteudo != "")
            {
                if (MessageBox.Show("Você tem certeza do CPF informado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool ValidaCpf = false;
                    ValidaCpf = clsUteis.Valida(mskCPF.Text);

                    lblResultado.Text = ValidaCpf ? "CPF válido" : "CPF inválido";
                }
            }
            else
                MessageBox.Show("Preencha todos os campos da formulário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            mskCPF.Focus();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mskCPF.Text = "";
            lblResultado.Text = "";
            mskCPF.Focus();
        }
    }
}
