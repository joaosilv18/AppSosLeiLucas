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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x2000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
        public Form14()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        // novo botões 
        private void VerificaASituacao3_Click_1(object sender, EventArgs e)
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

        private void IInicieAsManobras3_Click(object sender, EventArgs e)
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


        private void voltar3_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void voltar333_Click(object sender, EventArgs e)
        {
            Queimaduras2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void Proximo3_Click(object sender, EventArgs e)
        {
            Form15 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
