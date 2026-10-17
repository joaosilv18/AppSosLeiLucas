using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormConvulcoes1 : Form
    {
        public FormConvulcoes1()
        {
            InitializeComponent();
        }

        private void BtnProximoTelaDeInformacao1_Click(object sender, EventArgs e)
        {
            FormConvulcoes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarTelaDeProdotocolus1_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarTelaDeInformacao1_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoVerificaASituacao1_Click(object sender, EventArgs e)
        {
            FormConvulcoes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoSoliciteAjuda1_Click(object sender, EventArgs e)
        {
            FormConvulcoes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoInicieAsmanobras1_Click(object sender, EventArgs e)
        {
            FormConvulcoes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaomonitoramentoaVitima1_Click(object sender, EventArgs e)
        {
            FormConvulcoes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoAcioneOSamu1_Click(object sender, EventArgs e)
        {
            FormConvulcoes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
