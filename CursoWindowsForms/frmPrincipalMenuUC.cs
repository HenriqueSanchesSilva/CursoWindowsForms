using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class frmPrincipalMenuUC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;
        int ControleCadastroClientes = 0;

        ToolStripMenuItem desenhaItemMenu(string text, string nomeImagem)
        {
            var toolTip = new ToolStripMenuItem();
            toolTip.Text = text;
            Image myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            toolTip.Image = myImage;

            return toolTip;
        }

        void apagaAba(TabPage TB)
        {
            if (TB.Name == "Cadastro de Clientes")
            {
                ControleCadastroClientes = 0;
            }
            tbcAplications.TabPages.Remove(TB);
        }

        void apagaEsquerda(int itemSelecionado)
        {
            for (int i = itemSelecionado - 1; i >= 0; i += -1)
            {
                apagaAba(tbcAplications.TabPages[i]);
            }
        }

        void apagaDireita(int itemSelecionado)
        {
            for (int i = tbcAplications.TabCount - 1; i > itemSelecionado; i += -1)
            {
                apagaAba(tbcAplications.TabPages[i]);
            }
        }

        void toolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(tbcAplications.SelectedTab == null))
            {
                apagaAba(tbcAplications.SelectedTab);
            }
        }

        void toolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(tbcAplications.SelectedTab == null))
            {
                apagaEsquerda(tbcAplications.SelectedIndex);
            }
        }

        void toolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(tbcAplications.SelectedTab == null))
            {
                apagaDireita(tbcAplications.SelectedIndex);
            }
        }

        void toolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(tbcAplications.SelectedTab == null))
            {
                apagaEsquerda(tbcAplications.SelectedIndex);
                apagaDireita(tbcAplications.SelectedIndex);
            }
        }

        public frmPrincipalMenuUC()
        {
            InitializeComponent();
            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;

        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;
            frmDemonstraKeyUC U = new frmDemonstraKeyUC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Demonstração Key " + ControleDemonstracaoKey;
            TB.Text = "Demonstração Key " + ControleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            tbcAplications.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            frmHelloWorldUC uc = new frmHelloWorldUC();
            TabPage tb = new TabPage();
            tb.Name = "Hello World" + ControleHelloWorld;
            tb.Text = "Hello World" + ControleHelloWorld;
            tb.ImageIndex = 1;
            tb.Controls.Add(uc);
            tbcAplications.TabPages.Add(tb);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            frmMascarasUC U = new frmMascarasUC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Máscara " + ControleMascara;
            TB.Text = "Máscara " + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            tbcAplications.TabPages.Add(TB);
        }

        private void válidaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            frmValidaCpfUC U = new frmValidaCpfUC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = "Valída CPF " + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            tbcAplications.TabPages.Add(TB);
        }

        private void válidaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            frmValidaCpf2UC U = new frmValidaCpf2UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF2 " + ControleValidaCPF2;
            TB.Text = "Valída CPF2 " + ControleValidaCPF2;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            tbcAplications.TabPages.Add(TB);
        }

        private void válidaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            frmValidasenha U = new frmValidasenha();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha " + ControleValidaSenha;
            TB.Text = "Valída Senha " + ControleValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            tbcAplications.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(tbcAplications.SelectedTab == null))
            {
                apagaAba(tbcAplications.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\WindowsForms\\Curso\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;

                ControleArquivoImagem += 1;
                frmArquivoImagemUC U = new frmArquivoImagemUC(nomeArquivoImagem);
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Arquivo Imagem " + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem " + ControleArquivoImagem;
                TB.ImageIndex = 6; // Coloque aqui o índice da imagem que representa uma pasta
                TB.Controls.Add(U);
                tbcAplications.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin F = new frmLogin();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {

                string senha = F.senha;
                string login = F.login;

                if (cursoWindowsFormsBiblioteca.clsUteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    cadastrosToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuestao Db = new frmQuestao("frmQuestion", "Você deseja se desconectar ?");
            Db.ShowDialog();
            //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            if (Db.DialogResult == DialogResult.Yes)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                for (int i = tbcAplications.TabPages.Count - 1; i >= 0; i += -1)
                {
                    apagaAba(tbcAplications.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;
            }
        }

        private void tbcAplications_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var contextMenu = new ContextMenuStrip();
                var toolTip001 = desenhaItemMenu("Fechar aba", "DeleteTab");
                var toolTip002 = desenhaItemMenu("Fechar todas abas à esquerda", "DeleteLeft");
                var toolTip003 = desenhaItemMenu("Fechar todas abas à direita", "DeleteRight");
                var toolTip004 = desenhaItemMenu("Fechar todas abas, menos esta", "DeleteAll");
                contextMenu.Items.Add(toolTip001);
                contextMenu.Items.Add(toolTip002);
                contextMenu.Items.Add(toolTip003);
                contextMenu.Items.Add(toolTip004);
                contextMenu.Show(this, new Point(e.X, e.Y));
                toolTip001.Click += new System.EventHandler(toolTip001_Click);
                toolTip002.Click += new System.EventHandler(toolTip002_Click);
                toolTip003.Click += new System.EventHandler(toolTip003_Click);
                toolTip004.Click += new System.EventHandler(toolTip004_Click);
            }
        }

        private void frmPrincipalMenuUC_Load(object sender, EventArgs e)
        {
            cadastrosToolStripMenuItem.Enabled = false;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastroClientes == 0)
            {
                ControleCadastroClientes += 1;
                frmCadastroClienteUC U = new frmCadastroClienteUC();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Cadastro de Clientes";
                TB.Text = "Cadastro de Clientes";
                TB.ImageIndex = 7;
                TB.Controls.Add(U);
                tbcAplications.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Não posso abrir o Cadastro de Clientes, porque ele já está aberto.",
                    "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
