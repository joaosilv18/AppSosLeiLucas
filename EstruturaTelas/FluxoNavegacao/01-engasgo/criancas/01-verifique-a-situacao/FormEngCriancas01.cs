using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormEngCriancas01 : Form
    {
        public FormEngCriancas01()
        {
            InitializeComponent();
        }

        private void btnVoltarPagBebe01_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoCrianca01_Click(object sender, EventArgs e)
        {
            FormEngCriancas01 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaCrianca01_Click(object sender, EventArgs e)
        {
            FormEngCriancas02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasCrianca01_Click(object sender, EventArgs e)
        {
            FormEngCriancas03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitCrianca01_Click(object sender, EventArgs e)
        {
            FormEngCriancas04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuCrianca01_Click(object sender, EventArgs e)
        {
            FormEngCriancas05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarTelaProtCrianca01_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagCrianca01_Click(object sender, EventArgs e)
        {
            FormEngCriancas02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
