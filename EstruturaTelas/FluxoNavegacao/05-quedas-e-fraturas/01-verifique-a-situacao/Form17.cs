using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormQuedafra1 : Form
    {
        public FormQuedafra1()
        {
            InitializeComponent();
        }

        private void buttonQuedaFraVolProtocolo1_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVoltarProtocoloQuedaFra1_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedaProTela2_Click(object sender, EventArgs e)
        {
            FormQuedaFra2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSBQUedaFra1_1_Click(object sender, EventArgs e)
        {
            FormQuedafra1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSBQUedaFra1_2_Click(object sender, EventArgs e)
        {
            FormQuedaFra2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSBQUedaFra1_3_Click(object sender, EventArgs e)
        {
            FormQuedasEFraturas3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSBQUedaFra1_4_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fraturas4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSBQUedaFra1_5_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fratura5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
