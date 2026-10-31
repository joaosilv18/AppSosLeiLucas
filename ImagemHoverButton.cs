using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace teste
{
    internal class ImageHoverButton : Button
    {


        private Image? _imagemNormal;
        private Image? _imagemHover;

        [Category("Appearance")]
        [Description("Imagem exibida quando o mouse está fora do botão.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image? ImagemNormal
        {
            get => _imagemNormal;
            set
            {
                _imagemNormal = value;
                // Assim que a imagem normal for definida, já aplicamos no botão
                if (_imagemNormal != null)
                {
                    this.BackgroundImage = _imagemNormal;
                }
            }
        }

        [Category("Appearance")]
        [Description("Imagem exibida quando o mouse passa por cima do botão.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image? ImagemHover
        {
            get => _imagemHover;
            set => _imagemHover = value;
        }

        public ImageHoverButton()
        {
            // Configurações visuais iniciais para o botão parecer limpo (sem bordas cinzas feias)
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackColor = Color.Transparent;
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            if (_imagemHover != null)
            {
                this.BackgroundImage = _imagemHover;
            }
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            if (_imagemNormal != null)
            {
                this.BackgroundImage = _imagemNormal;
            }
        }
        // Aqui está o método OnPaint que você pode adicionar à sua classe ImageHoverButton para criar um botão com cantos arredondados e remover as bordas brancas da imagem:
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // 1. Deixa o Windows Forms desenhar o texto e o fundo padrão primeiro
            base.OnPaint(pevent);

            // 2. Define o tamanho do arredondamento (ajuste esse número se precisar)
            float raioBorda = 17.5f;

            // 3. Verifica se o botão tem tamanho suficiente para ser arredondado
            if (Width <= raioBorda || Height <= raioBorda) return;

            // 4. Cria a máscara matemática arredondada que vai cortar a imagem com pontas brancas
            using (System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath())
            {
                caminho.AddArc(0, 0, raioBorda, raioBorda, 180, 90);
                caminho.AddArc(Width - raioBorda, 0, raioBorda, raioBorda, 270, 90);
                caminho.AddArc(Width - raioBorda, Height - raioBorda, raioBorda, raioBorda, 0, 90);
                caminho.AddArc(0, Height - raioBorda, raioBorda, raioBorda, 90, 90);
                caminho.CloseAllFigures();

                // 5. Aplica o corte diretamente no controle. 
                // Isso força tudo o que está fora do arredondamento (incluindo as bordas brancas da imagem) a sumir!
                this.Region = new Region(caminho);
            }
        }
    }
}

