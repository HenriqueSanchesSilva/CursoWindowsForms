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
    public partial class frmPrincipalMenuUC : Form
    {
        public frmPrincipalMenuUC()
        {
            InitializeComponent();
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemonstracaoKey frmDemonstracaoKey = new frmDemonstracaoKey();
            frmDemonstracaoKey.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelloWorld frmHelloWorld = new frmHelloWorld();
            frmHelloWorld.ShowDialog();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMascara frmMascara = new frmMascara();
            frmMascara.ShowDialog();
        }

        private void válidaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidaCPF frmValidaCPF = new frmValidaCPF();
            frmValidaCPF.ShowDialog();
        }

        private void válidaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidaCPF2 frmValidaCPF2 = new frmValidaCPF2();
            frmValidaCPF2.ShowDialog();
        }

        private void válidaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidasenha frmValidasenha = new frmValidasenha();
            frmValidasenha.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
