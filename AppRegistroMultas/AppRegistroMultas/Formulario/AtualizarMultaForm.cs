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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace AppRegistroMultas.Formulario
{
    public partial class AtualizarMultaForm : Form
    {
        int contExc = 0;
        List<Multa> ListaMultas = new List<Multa>();
        public AtualizarMultaForm()
        {
            InitializeComponent();
            MultaContext context = new MultaContext();
            ListaMultas = context.ListarMultas();
            cbAtualizar.DataSource = ListaMultas.ToList();
            cbAtualizar.DisplayMember = "Modelo";
            cbAtualizar.SelectedIndex = -1;
        }

        private void cbAtualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbAtualizar.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var multaSelec = ListaMultas[linhaSelec];
                txtDescricao.Text = multaSelec.Descricao;
                txtValor.Text = multaSelec.ValorMulta.ToString();
            }
            contExc++;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhasSelec = cbAtualizar.SelectedIndex;
            if (linhasSelec > -1 && contExc > 0)
            {
                var multaSelec = ListaMultas[linhasSelec];
                txtDescricao.Text = multaSelec.Descricao;
                txtValor.Text = multaSelec.ValorMulta.ToString(); 
                MultaContext context = new MultaContext();
                context.AtualizarMulta(multaSelec);
                MessageBox.Show("ID:" + multaSelec.Id + "Atualizado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaMultas = context.ListarMultas();
                cbAtualizar.DataSource = ListaMultas.ToList();
                cbAtualizar.SelectedIndex = -1;
                txtDescricao.Clear(); txtValor.Clear(); 
                txtDescricao.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear(); txtValor.Clear();
            txtDescricao.Select();
        }
    }
}
