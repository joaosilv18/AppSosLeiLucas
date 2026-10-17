using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void voltar33_Click(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar3_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void proximo3_Click(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void proximo3_Click_1(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void VerificaASituacao3_Click(object sender, EventArgs e)
        {
            Form12 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void SoliciteAjuda3_Click(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void InicieAsManobras3_Click(object sender, EventArgs e)
        {
            Form14 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void MonitorasAVitima3_Click(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void AcioneOSamu3_Click(object sender, EventArgs e)
        {
            Form16 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
