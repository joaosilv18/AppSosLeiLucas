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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x2000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
        public Form12()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void voltar_Click(object sender, EventArgs e)
        {

        }

        private void AcioneOSamu1_Click_1(object sender, EventArgs e)
        {
            Form16 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
        // Novos Botões
        private void VerificaASituacao1_Click_1(object sender, EventArgs e)
        {
            Form12 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void SoliciteAjuda1_Click(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void InicieAsManobras1_Click_2(object sender, EventArgs e)
        {
            Form14 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void MonitorasAVitima1_Click_2(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void AcioneOSamu1_Click_2(object sender, EventArgs e)
        {
            Form16 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar1_Click_1(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar11_Click_1(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void Proximo1_Click_1(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void VoltareProximo1_Click(object sender, EventArgs e)
        {

        }
    }
}
