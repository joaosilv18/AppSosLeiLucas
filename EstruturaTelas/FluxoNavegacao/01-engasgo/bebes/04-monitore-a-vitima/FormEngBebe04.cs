using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormEngBebe04 : Form
    {
        public FormEngBebe04()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaProtBebe04_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoBebe04_Click(object sender, EventArgs e)
        {
            Form6 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarPagBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
