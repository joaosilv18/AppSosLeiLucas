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
            buttonInfoVolInicio = new Button();
            pictureBoxInfoRodape = new PictureBox();
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
            pictureBoxHedarInforLei.Size = new Size(997, 96);
            pictureBoxHedarInforLei.TabIndex = 0;
            pictureBoxHedarInforLei.TabStop = false;
            // 
            // pictureBoxInforRodape
            // 
            pictureBoxInforRodape.BackgroundImage = (Image)resources.GetObject("pictureBoxInforRodape.BackgroundImage");
            pictureBoxInforRodape.Location = new Point(-1, 681);
            pictureBoxInforRodape.Name = "pictureBoxInforRodape";
            pictureBoxInforRodape.Size = new Size(1003, 72);
            pictureBoxInforRodape.TabIndex = 1;
            pictureBoxInforRodape.TabStop = false;
            // 
            // buttonInfoVolInicio
            // 
            buttonInfoVolInicio.BackgroundImage = (Image)resources.GetObject("buttonInfoVolInicio.BackgroundImage");
            buttonInfoVolInicio.FlatStyle = FlatStyle.Flat;
            buttonInfoVolInicio.Location = new Point(12, 689);
            buttonInfoVolInicio.Name = "buttonInfoVolInicio";
            buttonInfoVolInicio.Size = new Size(236, 48);
            buttonInfoVolInicio.TabIndex = 2;
            buttonInfoVolInicio.UseVisualStyleBackColor = true;
            buttonInfoVolInicio.Click += buttonInfoVolInicio_Click;
            // 
            // pictureBoxInfoRodape
            // 
            pictureBoxInfoRodape.BackgroundImage = (Image)resources.GetObject("pictureBoxInfoRodape.BackgroundImage");
            pictureBoxInfoRodape.Image = (Image)resources.GetObject("pictureBoxInfoRodape.Image");
            pictureBoxInfoRodape.Location = new Point(762, 689);
            pictureBoxInfoRodape.Name = "pictureBoxInfoRodape";
            pictureBoxInfoRodape.Size = new Size(222, 48);
            pictureBoxInfoRodape.TabIndex = 3;
            pictureBoxInfoRodape.TabStop = false;
            // 
            // telaInforLei
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(996, 749);
            Controls.Add(pictureBoxInfoRodape);
            Controls.Add(buttonInfoVolInicio);
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
        private Button buttonInfoVolInicio;
        private PictureBox pictureBoxInfoRodape;
    }
}