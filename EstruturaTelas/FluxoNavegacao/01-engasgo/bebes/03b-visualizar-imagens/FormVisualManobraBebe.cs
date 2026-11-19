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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public FormVisualManobraBebe()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FormVisualManobraBebe_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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
