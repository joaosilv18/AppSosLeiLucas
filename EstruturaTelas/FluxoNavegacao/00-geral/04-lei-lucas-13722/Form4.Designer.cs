namespace ProjetoLeiLucasTelas
{
    partial class telaInforLei
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInforLei));
            pictureBoxHedarInforLei = new PictureBox();
            pictureBoxInforRodape = new PictureBox();
            pictureBoxInfoRodape = new PictureBox();
            BtnVoltarLeiLucas = new teste.ImageHoverButton();
            BtnVoltarInicioLeiLucas = new teste.ImageHoverButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHedarInforLei).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInforRodape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoRodape).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHedarInforLei
            // 
            pictureBoxHedarInforLei.BackgroundImage = (Image)resources.GetObject("pictureBoxHedarInforLei.BackgroundImage");
            pictureBoxHedarInforLei.Location = new Point(-1, 0);
            pictureBoxHedarInforLei.Name = "pictureBoxHedarInforLei";
            pictureBoxHedarInforLei.Size = new Size(1920, 118);
            pictureBoxHedarInforLei.TabIndex = 0;
            pictureBoxHedarInforLei.TabStop = false;
            // 
            // pictureBoxInforRodape
            // 
            pictureBoxInforRodape.BackgroundImage = (Image)resources.GetObject("pictureBoxInforRodape.BackgroundImage");
            pictureBoxInforRodape.Location = new Point(-1, 974);
            pictureBoxInforRodape.Name = "pictureBoxInforRodape";
            pictureBoxInforRodape.Size = new Size(1920, 84);
            pictureBoxInforRodape.TabIndex = 1;
            pictureBoxInforRodape.TabStop = false;
            // 
            // pictureBoxInfoRodape
            // 
            pictureBoxInfoRodape.BackgroundImage = (Image)resources.GetObject("pictureBoxInfoRodape.BackgroundImage");
            pictureBoxInfoRodape.Image = (Image)resources.GetObject("pictureBoxInfoRodape.Image");
            pictureBoxInfoRodape.Location = new Point(855, 988);
            pictureBoxInfoRodape.Name = "pictureBoxInfoRodape";
            pictureBoxInfoRodape.Size = new Size(222, 48);
            pictureBoxInfoRodape.TabIndex = 3;
            pictureBoxInfoRodape.TabStop = false;
            // 
            // BtnVoltarLeiLucas
            // 
            BtnVoltarLeiLucas.BackColor = Color.Transparent;
            BtnVoltarLeiLucas.BackgroundImage = (Image)resources.GetObject("BtnVoltarLeiLucas.BackgroundImage");
            BtnVoltarLeiLucas.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVoltarLeiLucas.FlatAppearance.BorderSize = 0;
            BtnVoltarLeiLucas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVoltarLeiLucas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVoltarLeiLucas.FlatStyle = FlatStyle.Flat;
            BtnVoltarLeiLucas.ImagemHover = (Image)resources.GetObject("BtnVoltarLeiLucas.ImagemHover");
            BtnVoltarLeiLucas.ImagemNormal = (Image)resources.GetObject("BtnVoltarLeiLucas.ImagemNormal");
            BtnVoltarLeiLucas.Location = new Point(39, 980);
            BtnVoltarLeiLucas.Name = "BtnVoltarLeiLucas";
            BtnVoltarLeiLucas.Size = new Size(76, 62);
            BtnVoltarLeiLucas.TabIndex = 10;
            BtnVoltarLeiLucas.UseVisualStyleBackColor = false;
            BtnVoltarLeiLucas.Click += BtnVoltarLeiLucas_Click;
            // 
            // BtnVoltarInicioLeiLucas
            // 
            BtnVoltarInicioLeiLucas.BackColor = Color.Transparent;
            BtnVoltarInicioLeiLucas.BackgroundImage = (Image)resources.GetObject("BtnVoltarInicioLeiLucas.BackgroundImage");
            BtnVoltarInicioLeiLucas.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVoltarInicioLeiLucas.FlatAppearance.BorderSize = 0;
            BtnVoltarInicioLeiLucas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVoltarInicioLeiLucas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVoltarInicioLeiLucas.FlatStyle = FlatStyle.Flat;
            BtnVoltarInicioLeiLucas.ImagemHover = (Image)resources.GetObject("BtnVoltarInicioLeiLucas.ImagemHover");
            BtnVoltarInicioLeiLucas.ImagemNormal = (Image)resources.GetObject("BtnVoltarInicioLeiLucas.ImagemNormal");
            BtnVoltarInicioLeiLucas.Location = new Point(1604, 978);
            BtnVoltarInicioLeiLucas.Name = "BtnVoltarInicioLeiLucas";
            BtnVoltarInicioLeiLucas.Size = new Size(254, 63);
            BtnVoltarInicioLeiLucas.TabIndex = 11;
            BtnVoltarInicioLeiLucas.UseVisualStyleBackColor = false;
            BtnVoltarInicioLeiLucas.Click += BtnVoltarInicioLeiLucas_Click;
            // 
            // telaInforLei
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(BtnVoltarInicioLeiLucas);
            Controls.Add(BtnVoltarLeiLucas);
            Controls.Add(pictureBoxInfoRodape);
            Controls.Add(pictureBoxInforRodape);
            Controls.Add(pictureBoxHedarInforLei);
            Name = "telaInforLei";
            Text = "Informações da Lei Lucas";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHedarInforLei).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInforRodape).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoRodape).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxHedarInforLei;
        private PictureBox pictureBoxInforRodape;
        private PictureBox pictureBoxInfoRodape;
        private teste.ImageHoverButton BtnVoltarLeiLucas;
        private teste.ImageHoverButton BtnVoltarInicioLeiLucas;
    }
}