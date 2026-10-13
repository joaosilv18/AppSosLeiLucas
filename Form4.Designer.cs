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
            VoltarAoInicio = new Button();
            button1 = new Button();
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
            // VoltarAoInicio
            // 
            VoltarAoInicio.BackColor = Color.Transparent;
            VoltarAoInicio.FlatAppearance.BorderSize = 0;
            VoltarAoInicio.FlatStyle = FlatStyle.Flat;
            VoltarAoInicio.Image = (Image)resources.GetObject("VoltarAoInicio.Image");
            VoltarAoInicio.Location = new Point(1604, 984);
            VoltarAoInicio.Name = "VoltarAoInicio";
            VoltarAoInicio.Size = new Size(254, 63);
            VoltarAoInicio.TabIndex = 8;
            VoltarAoInicio.UseVisualStyleBackColor = false;
            VoltarAoInicio.Click += VoltarAoInicio_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(39, 985);
            button1.Name = "button1";
            button1.Size = new Size(76, 62);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            // 
            // telaInforLei
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(VoltarAoInicio);
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
        private Button VoltarAoInicio;
        private Button button1;
    }
}