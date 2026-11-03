namespace ProjetoLeiLucasTelas
{
    partial class FormTreinamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTreinamento));
            telaAjuda = new PictureBox();
            pictureBoxInforRodape = new PictureBox();
            BtnVoltarPagAntTrein = new teste.ImageHoverButton();
            BtnVoltarInicioTrein = new teste.ImageHoverButton();
            ((System.ComponentModel.ISupportInitialize)telaAjuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInforRodape).BeginInit();
            SuspendLayout();
            // 
            // telaAjuda
            // 
            telaAjuda.BackgroundImage = (Image)resources.GetObject("telaAjuda.BackgroundImage");
            telaAjuda.Location = new Point(1, 0);
            telaAjuda.Name = "telaAjuda";
            telaAjuda.Size = new Size(1920, 118);
            telaAjuda.TabIndex = 1;
            telaAjuda.TabStop = false;
            // 
            // pictureBoxInforRodape
            // 
            pictureBoxInforRodape.BackgroundImage = (Image)resources.GetObject("pictureBoxInforRodape.BackgroundImage");
            pictureBoxInforRodape.Location = new Point(-1, 974);
            pictureBoxInforRodape.Name = "pictureBoxInforRodape";
            pictureBoxInforRodape.Size = new Size(1920, 84);
            pictureBoxInforRodape.TabIndex = 11;
            pictureBoxInforRodape.TabStop = false;
            // 
            // BtnVoltarPagAntTrein
            // 
            BtnVoltarPagAntTrein.BackColor = Color.Transparent;
            BtnVoltarPagAntTrein.BackgroundImage = (Image)resources.GetObject("BtnVoltarPagAntTrein.BackgroundImage");
            BtnVoltarPagAntTrein.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVoltarPagAntTrein.FlatAppearance.BorderSize = 0;
            BtnVoltarPagAntTrein.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVoltarPagAntTrein.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVoltarPagAntTrein.FlatStyle = FlatStyle.Flat;
            BtnVoltarPagAntTrein.ImagemHover = (Image)resources.GetObject("BtnVoltarPagAntTrein.ImagemHover");
            BtnVoltarPagAntTrein.ImagemNormal = (Image)resources.GetObject("BtnVoltarPagAntTrein.ImagemNormal");
            BtnVoltarPagAntTrein.Location = new Point(39, 984);
            BtnVoltarPagAntTrein.Name = "BtnVoltarPagAntTrein";
            BtnVoltarPagAntTrein.Size = new Size(76, 62);
            BtnVoltarPagAntTrein.TabIndex = 15;
            BtnVoltarPagAntTrein.UseVisualStyleBackColor = false;
            BtnVoltarPagAntTrein.Click += BtnVoltarPagAntTrein_Click;
            // 
            // BtnVoltarInicioTrein
            // 
            BtnVoltarInicioTrein.BackColor = Color.Transparent;
            BtnVoltarInicioTrein.BackgroundImage = (Image)resources.GetObject("BtnVoltarInicioTrein.BackgroundImage");
            BtnVoltarInicioTrein.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVoltarInicioTrein.FlatAppearance.BorderSize = 0;
            BtnVoltarInicioTrein.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVoltarInicioTrein.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVoltarInicioTrein.FlatStyle = FlatStyle.Flat;
            BtnVoltarInicioTrein.ImagemHover = (Image)resources.GetObject("BtnVoltarInicioTrein.ImagemHover");
            BtnVoltarInicioTrein.ImagemNormal = (Image)resources.GetObject("BtnVoltarInicioTrein.ImagemNormal");
            BtnVoltarInicioTrein.Location = new Point(1604, 984);
            BtnVoltarInicioTrein.Name = "BtnVoltarInicioTrein";
            BtnVoltarInicioTrein.Size = new Size(254, 63);
            BtnVoltarInicioTrein.TabIndex = 16;
            BtnVoltarInicioTrein.UseVisualStyleBackColor = false;
            BtnVoltarInicioTrein.Click += BtnVoltarInicioTrein_Click;
            // 
            // FormTreinamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(BtnVoltarInicioTrein);
            Controls.Add(BtnVoltarPagAntTrein);
            Controls.Add(pictureBoxInforRodape);
            Controls.Add(telaAjuda);
            Name = "FormTreinamento";
            Text = "FormTreinamento";
            ((System.ComponentModel.ISupportInitialize)telaAjuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInforRodape).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox telaAjuda;
        private PictureBox pictureBoxInforRodape;
        private teste.ImageHoverButton BtnVoltarPagAntTrein;
        private teste.ImageHoverButton BtnVoltarInicioTrein;
    }
}