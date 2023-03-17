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
    public partial class frmMenuFlutuante : Form
    {
        public frmMenuFlutuante()
        {
            InitializeComponent();
        }

        private void frmMenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            string str1 = e.Button.ToString();
            MessageBox.Show(str1);
        }
    }
}
