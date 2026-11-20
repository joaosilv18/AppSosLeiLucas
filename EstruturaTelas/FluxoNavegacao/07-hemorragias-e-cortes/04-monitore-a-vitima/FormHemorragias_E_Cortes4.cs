using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormHemorragias_E_Cortes4 : Form
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
        public FormHemorragias_E_Cortes4()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnVoltarTelaProtHemoCortes04_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVerificacaoHemoCortes04_Click(object sender, EventArgs e)
        {
            FormHemorragia_E_Cortes1 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnSoliciteAjudaHemoCortes04_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnManobrasHemoCortes04_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnMonitoreVitHemoCortes04_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes4 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnAcioneSamuHemoCortes04_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnVoltarPagHemoCortes04_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagHemoCortes04_Click(object sender, EventArgs e)
        {
            FormHemorragias_E_Cortes5 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void FormHemorragias_E_Cortes4_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBoxHEmorragiapasso4_Click(object sender, EventArgs e)
        {

        }
    }
}