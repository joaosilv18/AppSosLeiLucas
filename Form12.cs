using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProjetoLeiLucasTelas
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSoliciteAjuda_Click(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void Proximo1_Click(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar11_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void VerificaASituacao1_Click(object sender, EventArgs e)
        {
            Form12 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void InicieAsManobras1_Click(object sender, EventArgs e)
        {
            Form14 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void MonitorasAVitima1_Click(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void AcioneOSamu1_Click(object sender, EventArgs e)
        {
            Form16 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void InicieAsManobras1_Click_1(object sender, EventArgs e)
        {
            Form14 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void MonitorasAVitima1_Click_1(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void AcioneOSamu1_Click_1(object sender, EventArgs e)
        {
            Form16 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
