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

        private void button4_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEngasgo = new TelaSelecao();
            telaEngasgo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            FormConvulcoes1 pictureBoxinformacoesConvulcoes1 = new FormConvulcoes1();
            pictureBoxinformacoesConvulcoes1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormQuedafra1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
