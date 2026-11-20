using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class FormCreditos : Form
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
        public FormCreditos()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void BtnCreditoVoltarInicioLeiLucas_Click(object sender, EventArgs e)
        {
            TelaInicio telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
