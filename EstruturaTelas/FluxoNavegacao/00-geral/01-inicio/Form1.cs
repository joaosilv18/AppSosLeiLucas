using System.Drawing.Drawing2D;

namespace ProjetoLeiLucasTelas
{
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        Image imgNormalSair = Properties.Resources.BtnSair_Default;
        Image imgHoverSair = Properties.Resources.BtnSair_Hover;
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair1.BackgroundImage = imgHoverSair;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair1.BackgroundImage = imgNormalSair;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void imageHoverButton1_Click(object sender, EventArgs e)
        {

        }

        private void imageHoverButton1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void imageHoverButton1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void BtnIniciarTelaInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnTreinamento_Click(object sender, EventArgs e)
        {

        }

        private void BtnProtocolos_Click_1(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            Form3 telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnProtocolos2_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }

        private void imageHoverButton1_Click_1(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }

        private void BtnvoceSabia_Click(object sender, EventArgs e)
        {
            telaInforLei telaLei = new telaInforLei();
            telaLei.Show();
            this.Hide();
        }
    }
}
