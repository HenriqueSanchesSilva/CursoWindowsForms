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
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnModificaLabel_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = txtConteudoLabel.Text;
        }
    }
}
