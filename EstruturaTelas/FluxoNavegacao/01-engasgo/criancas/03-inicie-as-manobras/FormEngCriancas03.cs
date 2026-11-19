using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormEngCriancas03 : Form
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
        public FormEngCriancas03()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnVoltarTelaProtCrianca03_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoCrianca03_Click(object sender, EventArgs e)
        {
            FormEngCriancas01 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaCrianca03_Click(object sender, EventArgs e)
        {
            FormEngCriancas02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasCrianca03_Click(object sender, EventArgs e)
        {
            FormEngCriancas03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitCrianca03_Click(object sender, EventArgs e)
        {
            FormEngCriancas04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuCrianca03_Click(object sender, EventArgs e)
        {
            FormEngCriancas05 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarPagCrianca03_Click(object sender, EventArgs e)
        {
            FormEngCriancas02 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagCrianca03_Click(object sender, EventArgs e)
        {
            FormEngCriancas04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void FormEngCriancas03_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
