using CursoWindowsForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var posX = e.X;
                var posY = e.Y;

            //    MessageBox.Show("Cliquei com o botão direito. A posição relativa foi ("+posX.ToString() +", "+posY.ToString()+").");
                var contextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Item do Menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item do Menu 2", "Frm_ValidaSenha");
                contextMenu.Items.Add(vToolTip001);
                contextMenu.Items.Add(vToolTip002);
                contextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do menu 001");
            }
            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do menu 002");
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                var toolTip = new ToolStripMenuItem();
                toolTip.Text = text;
                Image myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                toolTip.Image = myImage;
                
                return toolTip;
            }
        }
    }
}
