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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
        public FormRelatorios()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void BtnVoltarPagAntRelat_Click(object sender, EventArgs e)
        {
            TelaInicio telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void BtnVoltarInicioRelat_Click(object sender, EventArgs e)
        {
            TelaInicio telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
