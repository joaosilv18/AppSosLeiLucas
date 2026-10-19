using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Enter(object sender, EventArgs e)
        {

        }

        private void VoltarAoInicio_Enter(object sender, EventArgs e)
        {

        }

        private void VoltarAoInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaAjuda = new TelaInicio();
            telaAjuda.Show();
            this.Hide();
        }

        private void VoltarAoInicio_Click_1(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicio telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
