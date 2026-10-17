using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormVisualManobraBebe : Form
    {
        public FormVisualManobraBebe()
        {
            InitializeComponent();
        }

        private void FormVisualManobraBebe_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarPagVisualManobraBebe03_Click(object sender, EventArgs e)
        {
            FormEngBebe03 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void btnProximaPagVisualManobraBebe03_Click(object sender, EventArgs e)
        {
            FormEngBebe04 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
    }
}
