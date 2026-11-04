using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormConvulcoes3 : Form
    {
        public FormConvulcoes3()
        {
            InitializeComponent();
        }
        // novos botões 
        private void BtnTelaConvulcaoVerificaASituacao3_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoSoliciteAjuda3_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoInicieAsmanobras3_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaomonitoramentoaVitima3_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoAcioneOSamu3_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarTelaDeInformacao2_Click(object sender, EventArgs e)
        {
            FormConvulcoes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarTelaDeProdotocolus3_Click_1(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnProximoTelaDeInformacao3_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
