using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormEngCriancas01 : Form
    {
        public FormEngCriancas01()
        {
            InitializeComponent();
        }

        private void btnVoltarPagBebe01_Click(object sender, EventArgs e)
        {
            TelaSelecao telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
