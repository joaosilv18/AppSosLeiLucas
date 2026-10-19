using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormQuedas_E_Fratura5 : Form
    {
        public FormQuedas_E_Fratura5()
        {
            InitializeComponent();
        }

        private void buttonQueda5_3_Click(object sender, EventArgs e)
        {
            FormQuedasEFraturas3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVoltarProtocoloQueda5_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonVoltarQuedaVtela4_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fraturas4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedas5_1_Click(object sender, EventArgs e)
        {
            FormQuedafra1 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQuedas5_2_Click(object sender, EventArgs e)
        {
            FormQuedaFra2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQueda5_4_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fraturas4 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void buttonQueda5_5_Click(object sender, EventArgs e)
        {
            FormQuedas_E_Fratura5 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
