using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormRcp5 : Form
    {
        public FormRcp5()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bnVoltarTelaPara4Rcp_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnVerificacao5Rcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnSoliciteAjuda5Rcp_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bninicie5Rcp_Rcp_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnMonitoreViti5Rcp_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnAcioneSamu5Rcp_Click(object sender, EventArgs e)
        {
            FormRcp5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnPasso5voltarTela4Rcp_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
