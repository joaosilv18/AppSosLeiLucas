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
        Image imgNormalProtocolos = Properties.Resources.BtnProtocolos_Default;
        Image imgHoverProtocolos = Properties.Resources.BtnProtocolos_Hover;
        private void BtnProtocolos_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }
        private void BtnProtocolos_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = imgHoverProtocolos;
        }

        private void BtnProtocolos_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = imgNormalProtocolos;
        }

        Image imgNormalSair = Properties.Resources.BtnSair_Default;
        Image imgHoverSair = Properties.Resources.BtnSair_Hover;
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = imgHoverSair;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = imgNormalSair;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        Image imgNormalIniciarEmergencia = Properties.Resources.BtnIniciarEmergencia_Default;
        Image imgHoverIniciarEmergencia = Properties.Resources.BtnIniciarEmergencia_Hover;
        private void BtnIniciarEmergencia_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }
        private void BtnIniciarEmergencia_MouseEnter(object sender, EventArgs e)
        {
            btnIniciarEmergencia_Click.BackgroundImage = imgHoverIniciarEmergencia;
        }

        private void BtnIniciarEmergencia_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarEmergencia_Click.BackgroundImage = imgNormalIniciarEmergencia;
        }

        Image imgNormalProtocolosSideBar = Properties.Resources.BtnProtocolosSideBar_Default;
        Image imgHoverProtocolosSideBar = Properties.Resources.BtnProtocolosSideBar_Hover;
        private void BtnSideBarProtocolos_Click(object sender, EventArgs e)
        {
            Form2 telaEmergencia = new Form2();
            telaEmergencia.Show();
            this.Hide();
        }
        private void BtnSideBarProtocolos_MouseEnter(object sender, EventArgs e)
        {
            button10.BackgroundImage = imgHoverProtocolosSideBar;
        }

        private void BtnSideBarProtocolos_MouseLeave(object sender, EventArgs e)
        {
            button10.BackgroundImage = imgNormalProtocolosSideBar;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        Image imgNormalAjudaSideBar = Properties.Resources.BtnAjudaSideBar_Default;
        Image imgHoverAjudaSideBar = Properties.Resources.BtnAjudaSideBar_Hover;
        private void BtnSideBarAjuda_Click(object sender, EventArgs e)
        {
            Form3 telaAjuda = new Form3();
            telaAjuda.Show();
            this.Hide();
        }
        private void BtnSideBarAjuda_MouseEnter(object sender, EventArgs e)
        {
            BtnSideBarAjuda.BackgroundImage = imgHoverAjudaSideBar;
        }

        private void BtnSideBarAjuda_MouseLeave(object sender, EventArgs e)
        {
            BtnSideBarAjuda.BackgroundImage = imgNormalAjudaSideBar;
        }

        Image imgNormalLei = Properties.Resources.BtnLeiLucas_Default;
        Image imgHoverLei = Properties.Resources.BtnLeiLucas_Hover;
        private void button5_Click(object sender, EventArgs e)
        {
            telaInforLei telaLei = new telaInforLei();
            telaLei.Show();
            this.Hide();
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = imgHoverLei;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = imgNormalLei;
        }

        Image imgNormalCardTreinamento = Properties.Resources.CardTreinamentoDefault;
        Image imgHoverCardTreinamento = Properties.Resources.CardTreinamentoHover;
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = imgHoverCardTreinamento;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = imgNormalCardTreinamento;
        }

        Image imgNormalInicio = Properties.Resources.BtnInicioSideBar_Default;
        Image imgHoverInicio = Properties.Resources.BtnInicioSideBar_Hover;
        private void button7_Click(object sender, EventArgs e)
        {
            TelaInicio telaEmergencia = new();
            telaEmergencia.Show();
            this.Hide();
        }
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = imgHoverInicio;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = imgNormalInicio;
        }

        Image imgNormalRelatorios = Properties.Resources.BtnRelatorios_Default;
        Image imgHoverRelatorios = Properties.Resources.BtnRelatorios_Hover;
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = imgHoverRelatorios;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = imgNormalRelatorios;
        }

        Image imgNormalTreinamento = Properties.Resources.BtnTreinamentoSideBar_Default;
        Image imgHoverTreinamento = Properties.Resources.BtnTreinamentoSideBar_Hover;
        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackgroundImage = imgHoverTreinamento;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackgroundImage = imgNormalTreinamento;
        }
    }
}
