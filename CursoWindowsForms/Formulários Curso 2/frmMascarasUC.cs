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
    public partial class frmMascarasUC : UserControl
    {
        public frmMascarasUC()
        {
            InitializeComponent();
        }
        private void btnHora_Click(object sender, EventArgs e)
        {
            mskTxt.UseSystemPasswordChar = false;
            mskTxt.Mask = "00:00";
            lblMascaraAtiva.Text = mskTxt.Mask;
            mskTxt.Text = "";
            mskTxt.Focus();
            lblConteudo.Text = "";

        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            mskTxt.UseSystemPasswordChar = false;
            mskTxt.Mask = "00000-000";
            lblMascaraAtiva.Text = mskTxt.Mask;
            mskTxt.Text = "";
            mskTxt.Focus();
            lblConteudo.Text = "";
        }

        private void btnMoeda_Click(object sender, EventArgs e)
        {
            mskTxt.UseSystemPasswordChar = false;
            mskTxt.Mask = "$ 000,000,000.00";
            lblMascaraAtiva.Text = mskTxt.Mask;
            mskTxt.Text = "";
            mskTxt.Focus();
            lblConteudo.Text = "";
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            mskTxt.UseSystemPasswordChar = false;
            mskTxt.Mask = "00/00/0000";
            lblMascaraAtiva.Text = mskTxt.Mask;
            mskTxt.Text = "";
            mskTxt.Focus();
            lblConteudo.Text = "";
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            mskTxt.UseSystemPasswordChar = true;
            mskTxt.Mask = "000000000000";
            lblMascaraAtiva.Text = mskTxt.Mask;
            mskTxt.Text = "";
            mskTxt.Focus();
            lblConteudo.Text = "";
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            mskTxt.UseSystemPasswordChar = false;
            mskTxt.Mask = "(00) 0000-0000";
            lblMascaraAtiva.Text = mskTxt.Mask;
            mskTxt.Text = "";
            mskTxt.Focus();
            lblConteudo.Text = "";
        }

        private void btnVerConteudo_Click(object sender, EventArgs e)
        {

            lblConteudo.Text = mskTxt.Text;
            mskTxt.Mask = "";
            mskTxt.Text = "";
            lblMascaraAtiva.Text = "";
            lblConteudo.Focus();
        }
    }
}
