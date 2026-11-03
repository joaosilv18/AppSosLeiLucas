using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void BtnVoltarPagAntRelat_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarInicioRelat_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
