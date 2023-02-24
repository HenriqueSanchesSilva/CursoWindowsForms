using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cursoWindowsFormsBiblioteca.clsUteis;

namespace CursoWindowsForms
{
    public partial class frmValidaSenhaUC : UserControl
    {
        bool verSenhaTxt = false;
        public frmValidaSenhaUC()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            lblResultado.Text = "";
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txtSenha.Text);
            lblResultado.Text = forca.ToString();


            if (lblResultado.Text == "Inaceitavel")
                lblResultado.ForeColor = Color.Red;
            else if (lblResultado.Text == "Fraca")
                lblResultado.ForeColor = Color.DarkRed;
            else if (lblResultado.Text == "Aceitavel")
                lblResultado.ForeColor = Color.Black;
            else if (lblResultado.Text == "Forte")
                lblResultado.ForeColor = Color.Green;
            else
                lblResultado.ForeColor = Color.DarkOliveGreen;


        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (verSenhaTxt == false)
            {
                txtSenha.PasswordChar = '*';
                btnVisible.Text = "Ver Senha";
                verSenhaTxt = true;
            }
            else
            {
                txtSenha.PasswordChar = '\0';
                btnVisible.Text = "Esconder";
                verSenhaTxt = false;
            }
        }
    }
}
