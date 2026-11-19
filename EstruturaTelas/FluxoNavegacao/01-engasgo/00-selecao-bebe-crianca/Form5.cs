using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class TelaSelecao : Form
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
        public TelaSelecao()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }

        private void VoltarAoInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEngCriancas01 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarInicioSelecao_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnSelecaoBebe_Click(object sender, EventArgs e)
        {
            Form6 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnSelecaoCriancas_Click(object sender, EventArgs e)
        {
            FormEngCriancas01 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarSelecao_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void TelaSelecao_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
