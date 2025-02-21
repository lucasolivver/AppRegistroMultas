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
    public partial class AtualizarVeiculoForm : Form
    {
        int contExc = 0;
        List<Veiculo> ListaVeiculos = new List<Veiculo>();
        public AtualizarVeiculoForm()
        {
            InitializeComponent();
            VeiculoContext context = new VeiculoContext();
            ListaVeiculos = context.ListarVeiculos(); 
            cbVeiculo.DataSource = ListaVeiculos.ToList();
            cbVeiculo.DisplayMember = "Modelo";
            cbVeiculo.SelectedIndex = -1;
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbVeiculo.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var veiculoSelec = ListaVeiculos[linhaSelec];
                txtModelo.Text = veiculoSelec.Modelo;
                txtMarca.Text = veiculoSelec.Marca;
                txtPlaca.Text = veiculoSelec.Placa;
            }
            contExc++;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhasSelec = cbVeiculo.SelectedIndex;
            if (linhasSelec > -1 && contExc > 0)
            {
                var veiculoSelec = ListaVeiculos[linhasSelec];
                txtModelo.Text = veiculoSelec.Modelo;
                txtMarca.Text = veiculoSelec.Marca;
                txtPlaca.Text = veiculoSelec.Placa;


                VeiculoContext context = new VeiculoContext();
                context.AtualizarVeiculo(veiculoSelec);
                MessageBox.Show("ID:" + veiculoSelec.Id + "Atualizado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaVeiculos = context.ListarVeiculos();
                cbVeiculo.DataSource = ListaVeiculos.ToList();
                cbVeiculo.SelectedIndex = -1;
                txtModelo.Clear(); txtMarca.Clear(); txtPlaca.Clear();
                txtModelo.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtModelo.Clear(); txtMarca.Clear(); txtPlaca.Clear();
            txtModelo.Select();
        }
    }
}
