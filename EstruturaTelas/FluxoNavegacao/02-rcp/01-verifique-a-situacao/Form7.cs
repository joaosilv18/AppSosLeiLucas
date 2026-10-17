using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form_RCP1 : Form
    {
        public Form_RCP1()
        {
            InitializeComponent();
        }

        private void pictureBoxFooterRcp_Click(object sender, EventArgs e)
        {

        }

        private void buttoninicieRcp_Rcp_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonRCP1proximo_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new FormRcp2();
            telaemergencia.Show();
            this.Hide();
        }

        private void button1voltarRcp1_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVoltarProtocoloRcp_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVerificacaoRcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSoliciteAjudaRcp_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonMonitoreVitiRcp_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonAcioneSamuRcp_Click(object sender, EventArgs e)
        {
            FormRcp5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
