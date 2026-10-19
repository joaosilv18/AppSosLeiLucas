using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormQuedaFra2 : Form
    {
        public FormQuedaFra2()
        {
            InitializeComponent();
        }

        private void buttonQuedaFraVol_Tela1_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedaProximaTela3_Click(object sender, EventArgs e)
        {
            FormQuedasEFraturas3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonSBQuedaFra2_1_Click(object sender, EventArgs e)
        {
            FormQuedafra1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedaFra2_2_Click(object sender, EventArgs e)
        {
            FormQuedaFra2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedaFra2_3_Click(object sender, EventArgs e)
        {
            FormQuedasEFraturas3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedaFra2_4_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fraturas4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedaFra2_5_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fratura5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVoltarQuedatela1_Click(object sender, EventArgs e)
        {
            FormQuedafra1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
