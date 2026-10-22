using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormEngCriancas02 : Form
    {
        public FormEngCriancas02()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaProtCrianca02_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoCrianca02_Click(object sender, EventArgs e)
        {
            FormEngCriancas01 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaCrianca02_Click(object sender, EventArgs e)
        {
            FormEngCriancas02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasCrianca02_Click(object sender, EventArgs e)
        {
            FormEngCriancas03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitCrianca02_Click(object sender, EventArgs e)
        {
            FormEngCriancas04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuCrianca02_Click(object sender, EventArgs e)
        {
            FormEngCriancas05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarPagCrianca02_Click(object sender, EventArgs e)
        {
            FormEngCriancas01 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagCrianca02_Click(object sender, EventArgs e)
        {
            FormEngCriancas03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
