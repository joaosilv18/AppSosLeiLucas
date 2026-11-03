namespace ProjetoLeiLucasTelas
{
    partial class FormRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorios));
            telaAjuda = new PictureBox();
            pictureBoxInforRodape = new PictureBox();
            BtnVoltarPagAntRelat = new teste.ImageHoverButton();
            BtnVoltarInicioRelat = new teste.ImageHoverButton();
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
            telaAjuda.TabIndex = 2;
            telaAjuda.TabStop = false;
            // 
            // pictureBoxInforRodape
            // 
            pictureBoxInforRodape.BackgroundImage = (Image)resources.GetObject("pictureBoxInforRodape.BackgroundImage");
            pictureBoxInforRodape.Location = new Point(-1, 974);
            pictureBoxInforRodape.Name = "pictureBoxInforRodape";
            pictureBoxInforRodape.Size = new Size(1920, 84);
            pictureBoxInforRodape.TabIndex = 12;
            pictureBoxInforRodape.TabStop = false;
            // 
            // BtnVoltarPagAntRelat
            // 
            BtnVoltarPagAntRelat.BackColor = Color.Transparent;
            BtnVoltarPagAntRelat.BackgroundImage = (Image)resources.GetObject("BtnVoltarPagAntRelat.BackgroundImage");
            BtnVoltarPagAntRelat.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVoltarPagAntRelat.FlatAppearance.BorderSize = 0;
            BtnVoltarPagAntRelat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVoltarPagAntRelat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVoltarPagAntRelat.FlatStyle = FlatStyle.Flat;
            BtnVoltarPagAntRelat.ImagemHover = (Image)resources.GetObject("BtnVoltarPagAntRelat.ImagemHover");
            BtnVoltarPagAntRelat.ImagemNormal = (Image)resources.GetObject("BtnVoltarPagAntRelat.ImagemNormal");
            BtnVoltarPagAntRelat.Location = new Point(39, 984);
            BtnVoltarPagAntRelat.Name = "BtnVoltarPagAntRelat";
            BtnVoltarPagAntRelat.Size = new Size(76, 62);
            BtnVoltarPagAntRelat.TabIndex = 16;
            BtnVoltarPagAntRelat.UseVisualStyleBackColor = false;
            BtnVoltarPagAntRelat.Click += BtnVoltarPagAntRelat_Click;
            // 
            // BtnVoltarInicioRelat
            // 
            BtnVoltarInicioRelat.BackColor = Color.Transparent;
            BtnVoltarInicioRelat.BackgroundImage = (Image)resources.GetObject("BtnVoltarInicioRelat.BackgroundImage");
            BtnVoltarInicioRelat.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVoltarInicioRelat.FlatAppearance.BorderSize = 0;
            BtnVoltarInicioRelat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVoltarInicioRelat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVoltarInicioRelat.FlatStyle = FlatStyle.Flat;
            BtnVoltarInicioRelat.ImagemHover = (Image)resources.GetObject("BtnVoltarInicioRelat.ImagemHover");
            BtnVoltarInicioRelat.ImagemNormal = (Image)resources.GetObject("BtnVoltarInicioRelat.ImagemNormal");
            BtnVoltarInicioRelat.Location = new Point(1604, 984);
            BtnVoltarInicioRelat.Name = "BtnVoltarInicioRelat";
            BtnVoltarInicioRelat.Size = new Size(254, 63);
            BtnVoltarInicioRelat.TabIndex = 17;
            BtnVoltarInicioRelat.UseVisualStyleBackColor = false;
            BtnVoltarInicioRelat.Click += BtnVoltarInicioRelat_Click;
            // 
            // FormRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(BtnVoltarInicioRelat);
            Controls.Add(BtnVoltarPagAntRelat);
            Controls.Add(pictureBoxInforRodape);
            Controls.Add(telaAjuda);
            Name = "FormRelatorios";
            Text = "FormRelatorios";
            ((System.ComponentModel.ISupportInitialize)telaAjuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInforRodape).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox telaAjuda;
        private PictureBox pictureBoxInforRodape;
        private teste.ImageHoverButton BtnVoltarPagAntRelat;
        private teste.ImageHoverButton BtnVoltarInicioRelat;
    }
}