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
    public partial class frmCadastroClienteUC : UserControl
    {
        public frmCadastroClienteUC()
        {
            InitializeComponent();

            lblBairro.Text = "Bairro";
            lblCep.Text = "CEP";
            lblComplemento.Text = "Complemento";
            lblCPF.Text = "CPF";
            lblEstado.Text = "Estado";
            lblGenero.Text = "Genero";
            lblLogradouro.Text = "Logradouro";
            lblNomeCliente.Text = "Nome";
            lblNomeMae.Text = "Nome da Mãe";
            lblNomePai.Text = "Nome do Pai";
            lblProfissao.Text = "Profissão";
            lblRendaFamiliar.Text = "Renda Familiar";
            lblTelefone.Text = "Telefone";
        }
    }
}
