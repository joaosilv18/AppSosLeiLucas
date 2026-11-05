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



  





        private void bnVoltarProtocoloRcp_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnVerificacaoRcp_Click(object sender, EventArgs e)
        {
            Form_RCP1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnSoliciteAjudaRcp_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bninicieRcp_Rcp_Click(object sender, EventArgs e)
        {
            FormRcp3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void MonitorasAVitima5_Click(object sender, EventArgs e)
        {
            FormRcp4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void AcioneOSamuRcp_Click(object sender, EventArgs e)
        {
            FormRcp5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void voltar11_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void bnRCP1proximo_Click(object sender, EventArgs e)
        {
            FormRcp2 telaemergencia = new FormRcp2();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
