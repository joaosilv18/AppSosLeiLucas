using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form6 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public Form6()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarPagBebe1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarTelaProtBebe01_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarSelecao_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoBebe01_Click(object sender, EventArgs e)
        {
            Form6 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasBebe01_Click(object sender, EventArgs e)
        {
            FormEngBebe03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaBebe01_Click(object sender, EventArgs e)
        {
            FormEngBebe02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitBebe01_Click(object sender, EventArgs e)
        {
            FormEngBebe04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuBebe01_Click(object sender, EventArgs e)
        {
            FormEngBebe05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagBebe01_Click(object sender, EventArgs e)
        {
            FormEngBebe02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
