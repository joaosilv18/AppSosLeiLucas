using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormRcp2 : Form
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
        public FormRcp2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void bnVoltarTelaPara1Rcp_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnVerificacao2Rcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnSoliciteAjuda2Rcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bninicie2Rcp_Rcp_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnMonitoreViti2Rcp_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnAcioneSamu2Rcp_Click(object sender, EventArgs e)
        {
            FormRcp5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bn2voltarTela1_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnPasso2ProximaTela3_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void FormRcp2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
