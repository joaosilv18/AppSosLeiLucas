using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form15 : Form
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
        public Form15()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }


        private void VerificaASituacao3_Click(object sender, EventArgs e)
        {
            Form12 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void SoliciteAjuda4_Click(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void IInicieAsManobras4_Click(object sender, EventArgs e)
        {
            Form14 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void MonitorasAVitima4_Click(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void AcioneOSamu4_Click(object sender, EventArgs e)
        {
            Form16 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar4_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar44_Click(object sender, EventArgs e)
        {
            Form14 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void Proximo4_Click(object sender, EventArgs e)
        {
            Form16 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
