using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormQuedasEFraturas3 : Form
    {
        public FormQuedasEFraturas3()
        {
            InitializeComponent();
        }

        private void buttonHeaderQuedas3_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVoltarQuedaVtela2_Click(object sender, EventArgs e)
        {
            FormQuedaFra2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedaProximaTela4_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fraturas4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedas3_1_Click(object sender, EventArgs e)
        {
            FormQuedafra1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedas3_2_Click(object sender, EventArgs e)
        {
            FormQuedaFra2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedas3_3_Click(object sender, EventArgs e)
        {
            FormQuedasEFraturas3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedas3_4_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fraturas4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedas3_5_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fratura5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
