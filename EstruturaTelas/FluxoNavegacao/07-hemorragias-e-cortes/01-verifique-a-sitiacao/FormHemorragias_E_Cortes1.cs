using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormHemorragia_E_Cortes1 : Form
    {
        public FormHemorragia_E_Cortes1()
        {
            InitializeComponent();
        }

        private void button1_5Hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void buttonVoltarProtocoloHemorragia_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void FormHemorragia_E_Cortes1_Load(object sender, EventArgs e)
        {

        }

        private void button1_1hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragia_E_Cortes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button1_2Hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button1_3Hemoragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button1_4Hemorragia_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void buttonVoltarProtocoHemoragia1_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void buttonProximaTelaHemorragia1_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
