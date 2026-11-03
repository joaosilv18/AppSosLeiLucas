using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormTreinamento : Form
    {
        public FormTreinamento()
        {
            InitializeComponent();
        }

        private void BtnVoltarPagAntTrein_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnVoltarInicioTrein_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
