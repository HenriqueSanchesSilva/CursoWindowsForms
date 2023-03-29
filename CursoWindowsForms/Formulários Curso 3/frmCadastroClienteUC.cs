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

            grpCodigo.Text = "Código";
            grpDadosPessoais.Text = "Dados Pessoais";
            grpEndereco.Text = "Endereço";
            grpOutros.Text = "Outros";

            lblBairro.Text = "Bairro";
            lblCep.Text = "CEP";
            lblComplemento.Text = "Complemento";
            lblCPF.Text = "CPF";
            lblEstado.Text = "Estado";
            lblLogradouro.Text = "Logradouro";
            lblNomeCliente.Text = "Nome";
            lblNomeMae.Text = "Nome da Mãe";
            lblNomePai.Text = "Nome do Pai";
            lblProfissao.Text = "Profissão";
            lblRendaFamiliar.Text = "Renda Familiar";
            lblTelefone.Text = "Telefone";
            lblCidade.Text = "Cidade";
            chkTemPai.Text = "Pai desconhecido";
            rdbMasculino.Text = "Masculino";
            rdbFeminino.Text = "Feminino";
            rdbIndefinido.Text = "Indefinido";
            gprGenero.Text = "Genero";

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Acre (AC)");
            cmbEstado.Items.Add("Alagoas(AL)");
            cmbEstado.Items.Add("Amapá(AP)");
            cmbEstado.Items.Add("Amazonas(AM)");
            cmbEstado.Items.Add("Bahia(BA)");
            cmbEstado.Items.Add("Ceará(CE)");
            cmbEstado.Items.Add("Distrito Federal(DF)");
            cmbEstado.Items.Add("Espírito Santo(ES)");
            cmbEstado.Items.Add("Goiás(GO)");
            cmbEstado.Items.Add("Maranhão(MA)");
            cmbEstado.Items.Add("Mato Grosso(MT)");
            cmbEstado.Items.Add("Mato Grosso do Sul(MS)");
            cmbEstado.Items.Add("Minas Gerais(MG)");
            cmbEstado.Items.Add("Pará(PA)");
            cmbEstado.Items.Add("Paraíba(PB)");
            cmbEstado.Items.Add("Paraná(PR)");
            cmbEstado.Items.Add("Pernambuco(PE)");
            cmbEstado.Items.Add("Piauí(PI)");
            cmbEstado.Items.Add("Rio de Janeiro(RJ)");
            cmbEstado.Items.Add("Rio Grande do Norte(RN)");
            cmbEstado.Items.Add("Rio Grande do Sul(RS)");
            cmbEstado.Items.Add("Rondônia(RO)");
            cmbEstado.Items.Add("Roraima(RR)");
            cmbEstado.Items.Add("Santa Catarina(SC)");
            cmbEstado.Items.Add("São Paulo(SP)");
            cmbEstado.Items.Add("Sergipe(SE)");
            cmbEstado.Items.Add("Tocantins(TO)");
        }

        private void chkTemPai_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTemPai.Checked)
            {
                txtNomePai.Enabled = false;
            }
            else
            {
                txtNomePai.Enabled = true;
            }
        }
    }
}
