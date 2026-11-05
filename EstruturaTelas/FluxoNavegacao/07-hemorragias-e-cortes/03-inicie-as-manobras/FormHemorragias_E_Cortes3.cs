using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormHemorragias_E_Cortes3 : Form
    {
        public FormHemorragias_E_Cortes3()
        {
            InitializeComponent();
        }

        private void pictureBoxHEmorragiapasso3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarTelaProtHemoCortes03_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoHemoCortes03_Click(object sender, EventArgs e)
        {
            FormHemorragia_E_Cortes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaHemoCortes03_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasHemoCortes03_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitHemoCortes03_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuHemoCortes03_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarPagHemoCortes03_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagHemoCortes03_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
