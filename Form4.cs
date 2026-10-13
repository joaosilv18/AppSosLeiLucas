using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class telaInforLei : Form
    {
        public telaInforLei()
        {
            InitializeComponent();
        }

        private void buttonInfoVolInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telainforma = new TelaInicio();
            telainforma.Show();
            this.Hide();
        }
    }
}
