using AppRegistroMultas.Contexto;
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
    public partial class DeletarMultaForm : Form
    {
        int contExc = 0;
        List<Multa> ListaMultas = new List<Multa>();
        public DeletarMultaForm()
        {
            InitializeComponent();
            MultaContext context = new MultaContext();
            ListaMultas = context.ListarMultas(); 
            cbDeletar.DataSource = ListaMultas.ToList();
            cbDeletar.DisplayMember = "Modelo";
            cbDeletar.SelectedIndex = -1;
        }

        private void cbDeletar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbDeletar.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var multaSelec = ListaMultas[linhaSelec];
                txtDescricao.Text = multaSelec.Descricao;
                txtValor.Text = multaSelec.ValorMulta.ToString();
            }
            contExc++;
        }

        private void btDELETAR_Click(object sender, EventArgs e)
        {
            var linhasSelec = cbDeletar.SelectedIndex;
            if (linhasSelec > -1 && contExc > 0)
            {
                var multaSelec = ListaMultas[linhasSelec];
                txtDescricao.Text = multaSelec.Descricao;
                txtValor.Text = multaSelec.ValorMulta.ToString();
                MultaContext context = new MultaContext();
                context.DeletarMulta(multaSelec);
                MessageBox.Show("ID:" + multaSelec.Id + "Deletado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaMultas = context.ListarMultas();
                cbDeletar.DataSource = ListaMultas.ToList();
                cbDeletar.SelectedIndex = -1;
                txtDescricao.Clear(); txtValor.Clear();
                txtDescricao.Select();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear(); txtValor.Clear();
            txtDescricao.Select();
        }
    }
}
