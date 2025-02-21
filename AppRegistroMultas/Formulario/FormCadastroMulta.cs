using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models;

namespace AppRegistroMultas.Formulario
{
    public partial class FormCadastroMulta : Form
    {
        private static int IdMulta = 1;

        private List<Multa> ListaTempMultas = new List<Multa>();
        private Veiculo VeiculoSelecionado = new Veiculo();

        public FormCadastroMulta()
        {
            InitializeComponent();
            VeiculoContext veiculos = new VeiculoContext();
            cbVeiculo.DataSource = veiculos.ListarVeiculos().ToList();
            cbVeiculo.DisplayMember = "Modelo";
            cbVeiculo.SelectedIndex = -1;
        }
        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = cbVeiculo.SelectedIndex;

            if (indiceSelecionado > -1)
            {
                VeiculoContext veiculos = new VeiculoContext();
                var veicSelec = veiculos.ListarVeiculos()[indiceSelecionado];

                txtModelo.Text = veicSelec.Modelo;
                txtMarca.Text = veicSelec.Marca;
                txtPlaca.Text = veicSelec.Placa;

                VeiculoSelecionado = veicSelec;
            }
            else
            {

                LimparCaixasCarro();
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {

            Multa multa = new Multa();
            multa.Descricao = txtDescricao.Text;
            multa.ValorMulta = Convert.ToDecimal(txtValor.Text);

            multa.VeiculoId = VeiculoSelecionado.Id;

            ListaTempMultas.Add(multa);
            dtTabela.DataSource = ListaTempMultas.ToList();

            LimparCaixasMulta();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            //this.VeiculoSelecionado.ListaMultas = ListaTempMultas.ToList();

            MultaContext multas = new MultaContext();

            foreach (var multa in ListaTempMultas)
            {
                multas.InserirMulta(multa);
            }

            Context.ListaMultas.AddRange(ListaTempMultas);

            ListaTempMultas.Clear();
            LimparTudo();
            MessageBox.Show("SALVO COM SUCESSO", "2º A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimparCaixasCarro()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
        }
        private void LimparCaixasMulta()
        {
            txtDescricao.Clear();
            txtValor.Clear();
        }
        private void LimparTudo()
        {
            LimparCaixasCarro();
            LimparCaixasMulta();
            cbVeiculo.SelectedIndex = -1;
            dtTabela.DataSource = new List<Multa>();
        }
    }
}