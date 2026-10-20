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

        private void buttonVoltartelaHemoragia2_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void pictureBoxHEmorragiapasso3_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltarProtocoloHemorragia3_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button3_1hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragia_E_Cortes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void buttonProximaTelaHemorragia3_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button3_2Hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button3_3Hemoragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button3_4Hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button3_5Hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
