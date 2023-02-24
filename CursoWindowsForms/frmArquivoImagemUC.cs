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
    public partial class frmArquivoImagemUC : UserControl
    {
        public frmArquivoImagemUC(string nomeArquivoImagem)
        {
            InitializeComponent();

            lblArquivoImagem.Text = nomeArquivoImagem;
            picArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                lblArquivoImagem.ForeColor = CDb.Color;
            }
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();
            if (FDb.ShowDialog() == DialogResult.OK)
            {
                lblArquivoImagem.Font = FDb.Font;
            }
        }
    }
}
