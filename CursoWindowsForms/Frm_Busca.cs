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
    public partial class frmBusca : Form
    {

        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect { get; set; }

        public frmBusca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar a seleção";
            Tls_Principal.Items[1].ToolTipText = "Fechar a seleção";
            PreencherLista();
            lstBusca.Sorted = true;
        }

        private void PreencherLista()
        {
            lstBusca.Items.Clear();
            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBusca[i][0];
                X.nome = _ListaBusca[i][1];
                lstBusca.Items.Add(X);
            }
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado = (ItemBox)lstBusca.Items[lstBusca.SelectedIndex];
            idSelect = ItemSelecionado.id;
            this.Close();
        }

        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}
