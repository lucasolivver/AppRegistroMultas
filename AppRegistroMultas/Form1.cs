using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroMultas.Formulario;

namespace AppRegistroMultas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastroVeiculo_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro(); 
            form.ShowDialog();
        }

        private void btCadastroMulta_Click(object sender, EventArgs e)
        {
            FormCadastroMulta form = new FormCadastroMulta();
            form.ShowDialog();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            FormConsultaVeiculo form = new FormConsultaVeiculo();
               form.ShowDialog();
        }

        private void btAtualizaMulta_Click(object sender, EventArgs e)
        {
            AtualizarMultaForm form = new AtualizarMultaForm();
            form.ShowDialog();
        }

        private void btDeletaMulta_Click(object sender, EventArgs e)
        {
            DeletarMultaForm form = new DeletarMultaForm();
            form.ShowDialog();
        }

        private void btAtualizaVeiculo_Click(object sender, EventArgs e)
        {
            AtualizarVeiculoForm form = new AtualizarVeiculoForm();
            form.ShowDialog();
        }

        private void btDeletaVeiculo_Click(object sender, EventArgs e)
        {
            DeletarVeiculoForm form = new DeletarVeiculoForm();
            form.ShowDialog();
        }
    }
}
