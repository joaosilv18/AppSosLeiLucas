using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormRcp3 : Form
    {
        public FormRcp3()
        {
            InitializeComponent();
        }


        private void bnVoltarTelaPara2Rcp_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnVerificacao3Rcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnSoliciteAjuda3Rcp_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bninicie3Rcp_Rcp_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnMonitoreViti3Rcp_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnAcioneSamu3Rcp_Click(object sender, EventArgs e)
        {
            FormRcp5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnPasso3voltarTela2Rcp_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnPasso3ProximaTela4Rcp_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
