using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void BtnVoltarInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }
        private void VoltarAoInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnQueimaduras_Click(object sender, EventArgs e)
        {
            Form12 InformacaoQueimadura1 = new Form12();
            InformacaoQueimadura1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnProtoEngasgo_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEngasgo = new TelaSelecao();
            telaEngasgo.Show();
            this.Hide();
        }

        private void BtnProtoRcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtProtoHemorragiaCortes_Click(object sender, EventArgs e)
        {
            FormHemorragia_E_Cortes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnLevaTelaInicio_Click(object sender, EventArgs e)
        {
            Form12 InformacaoQueimadura1 = new Form12();
            InformacaoQueimadura1.Show();
            this.Hide();
        }

        private void BtnLevaTelaDeQuedas_Click(object sender, EventArgs e)
        {
            FormQuedafra1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnLevaTelaDeConvulcoes_Click(object sender, EventArgs e)
        {
            FormConvulcoes1 pictureBoxinformacoesConvulcoes1 = new FormConvulcoes1();
            pictureBoxinformacoesConvulcoes1.Show();
            this.Hide();
        }

        private void BtnVoltarInicio_Click_1(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
