using System.Drawing.Drawing2D;

namespace ProjetoLeiLucasTelas
{
    public partial class TelaInicio : Form
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
    
        public TelaInicio()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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
            DialogResult respostaSair = MessageBox.Show("Deseja fechar o Programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respostaSair == DialogResult.Yes) Application.Exit();
            else return;
        }



        private void BtnIniciarTelaInicio_Click(object sender, EventArgs e)
        {
            TelaInicio telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void BtnTreinamento_Click(object sender, EventArgs e)
        {
            FormTreinamento telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void BtnProtocolos_Click_1(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            Form3 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void BtnProtocolos2_Click(object sender, EventArgs e)
        {
            Form2 telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void imageHoverButton1_Click_1(object sender, EventArgs e)
        {
            Program.Emergencia.Show();
            this.Hide();   
        }

        private void BtnvoceSabia_Click(object sender, EventArgs e)
        {
            telaInforLei telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void BtnTreinamento2_Click(object sender, EventArgs e)
        {
            FormTreinamento telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }

        private void BtnRelatorios2_Click(object sender, EventArgs e)
        {
            FormRelatorios telaemergencia = new();
            telaemergencia.Show();
            this.Hide();
        }
    }
}
