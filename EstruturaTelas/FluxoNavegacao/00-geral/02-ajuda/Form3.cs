using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLeiLucasTelas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Enter(object sender, EventArgs e)
        {

        }

        private void VoltarAoInicio_Enter(object sender, EventArgs e)
        {

        }


        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Program.Inicio.Show();
            this.Hide();
        }

        private void BtnVoltarInicio2_Click(object sender, EventArgs e)
        {
            Program.Inicio.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
