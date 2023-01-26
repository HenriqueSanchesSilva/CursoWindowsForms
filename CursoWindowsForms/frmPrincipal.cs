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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnDemonstraKey_Click(object sender, EventArgs e)
        {
            frmDemonstracaoKey frmDemonstracaoKey = new frmDemonstracaoKey();
            frmDemonstracaoKey.ShowDialog();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            frmHelloWorld frmHelloWorld = new frmHelloWorld();
            frmHelloWorld.ShowDialog();
        }

        private void btnMascara_Click(object sender, EventArgs e)
        {
            frmMascara frmMascara = new frmMascara();
            frmMascara.ShowDialog();
        }

        private void btnValidaCPF_Click(object sender, EventArgs e)
        {
            frmValidaCPF frmValidaCPF = new frmValidaCPF();
            frmValidaCPF.ShowDialog();
        }

        private void btnValidaCPF2_Click(object sender, EventArgs e)
        {
            frmValidaCPF2 frmValidaCPF2 = new frmValidaCPF2();
            frmValidaCPF2.ShowDialog();
        }

        private void btnValidaSenha_Click(object sender, EventArgs e)
        {
            frmValidasenha frmValidasenha = new frmValidasenha();
            frmValidasenha.ShowDialog();
        }
    }
}
