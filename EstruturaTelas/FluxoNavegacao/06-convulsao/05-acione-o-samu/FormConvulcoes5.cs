using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormConvulcoes5 : Form
    {
        public FormConvulcoes5()
        {
            InitializeComponent();
        }

        // novos botões
        private void BtnTelaConvulcaoVerificaASituacao4_Click(object sender, EventArgs e)
        {
            FormConvulcoes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoSoliciteAjuda5_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoInicieAsmanobras5_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaomonitoramentoaVitima5_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTelaConvulcaoAcioneOSamu5_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarTelaDeInformacao5_Click_1(object sender, EventArgs e)
        {
            FormConvulcoes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarTelaDeProdotocolus5_Click_1(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
