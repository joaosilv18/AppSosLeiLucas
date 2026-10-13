using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltarInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new TelaInicio();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
