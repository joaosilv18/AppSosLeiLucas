using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormHemorragias_E_Cortes5 : Form
    {
        public FormHemorragias_E_Cortes5()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaProtHemoCortes05_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoHemoCortes05_Click(object sender, EventArgs e)
        {
            FormHemorragia_E_Cortes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaHemoCortes05_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasHemoCortes05_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitHemoCortes05_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuHemoCortes05_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarPagHemoCortes05_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
