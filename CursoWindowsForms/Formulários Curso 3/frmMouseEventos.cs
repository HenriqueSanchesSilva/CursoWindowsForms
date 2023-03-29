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
    public partial class frmMouseEventos : Form
    {
        public frmMouseEventos()
        {
            InitializeComponent();
        }

        private void btnName_MouseEnter(object sender, EventArgs e)
        {
            btnName.Text = "Mouse Enter";
        }

        private void btnName_MouseLeave(object sender, EventArgs e)
        {
            btnName.Text = "Mouse Leave";
        }

        private void btnName_MouseHover(object sender, EventArgs e)
        {
            btnName.Text = "Mouse Hover";
        }

        private void btnName_MouseDown(object sender, MouseEventArgs e)
        {
            btnName.Text = "Mouse Down";
        }

        private void btnName_MouseUp(object sender, MouseEventArgs e)
        {
            btnName.Text = "Mouse Up";
        }
    }
}
