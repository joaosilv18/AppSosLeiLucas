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
            Program.Inicio.Show();
            this.Hide();
        }

        private void BtnVoltarInicioTrein_Click(object sender, EventArgs e)
        {
            Program.Inicio.Show();
            this.Hide();
        }

        private void FormTreinamento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
