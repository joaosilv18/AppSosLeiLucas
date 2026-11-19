using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormEngBebe04 : Form
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
        public FormEngBebe04()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void btnVoltarTelaProtBebe04_Click_1(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoBebe04_Click(object sender, EventArgs e)
        {
            Form6 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarPagBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagBebe04_Click(object sender, EventArgs e)
        {
            FormEngBebe05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void FormEngBebe04_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
