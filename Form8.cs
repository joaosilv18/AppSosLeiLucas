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
        public FormRcp2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPasso2ProximaTela3_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVoltarTelaPara1Rcp_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttoPasso2voltarTela1_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVerificacao2Rcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSoliciteAjuda2Rcp_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttoninicie2Rcp_Rcp_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonMonitoreViti2Rcp_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonAcioneSamu2Rcp_Click(object sender, EventArgs e)
        {
            FormRcp5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
