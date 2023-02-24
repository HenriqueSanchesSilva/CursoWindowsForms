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
    public partial class frmQuestao : Form
    {
        public frmQuestao(string nomeImagem, string mensagem)
        {
            InitializeComponent();

            Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            pbxImage.Image = MyImage;
            lblQuestao.Text = mensagem;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            this.Close();   
        }
    }
}
