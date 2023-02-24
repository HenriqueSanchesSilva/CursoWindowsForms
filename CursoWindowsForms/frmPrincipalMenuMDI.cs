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
    public partial class frmPrincipalMenuMDI : Form
    {
        public frmPrincipalMenuMDI()
        {
            InitializeComponent();
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemonstracaoKey frmDemonstracaoKey = new frmDemonstracaoKey();
            frmDemonstracaoKey.MdiParent = this;
            frmDemonstracaoKey.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelloWorld frmHelloWorld = new frmHelloWorld();
            frmHelloWorld.MdiParent = this;
            frmHelloWorld.Show();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMascara frmMascara = new frmMascara();
            frmMascara.MdiParent = this;
            frmMascara.Show();
        }

        private void válidaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidaCPF frmValidaCPF = new frmValidaCPF();
            frmValidaCPF.MdiParent = this;
            frmValidaCPF.Show();
        }

        private void válidaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidaCPF2 frmValidaCPF2 = new frmValidaCPF2();
            frmValidaCPF2.MdiParent = this;
            frmValidaCPF2.Show();
        }

        private void válidaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidasenha frmValidasenha = new frmValidasenha();
            frmValidasenha.MdiParent = this;
            frmValidasenha.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
