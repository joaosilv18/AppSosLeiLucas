using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormConvulcoes2 : Form
    {
        public FormConvulcoes2()
        {
            InitializeComponent();
        }

        private void pictureBoxlateralesquerdoConvulcoes2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltarTelaDeProdotocolus2_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnProximoTelaDeInformacao2_Click(object sender, EventArgs e)
        {
            FormConvulcoes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarTelaDeInformacao2_Click(object sender, EventArgs e)
        {
            FormConvulcoes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoVerificaASituacao2_Click(object sender, EventArgs e)
        {
            FormConvulcoes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoSoliciteAjuda2_Click(object sender, EventArgs e)
        {
            FormConvulcoes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoInicieAsmanobras2_Click(object sender, EventArgs e)
        {
            FormConvulcoes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaomonitoramentoaVitima2_Click(object sender, EventArgs e)
        {
            FormConvulcoes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoAcioneOSamu2_Click(object sender, EventArgs e)
        {
            FormConvulcoes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
