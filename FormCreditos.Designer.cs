namespace ProjetoLeiLucasTelas
{
    partial class FormCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditos));
            pictureBoxCreditos = new PictureBox();
            BtnCreditoVoltarInicioLeiLucas = new teste.ImageHoverButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreditos).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCreditos
            // 
            pictureBoxCreditos.BackgroundImage = (Image)resources.GetObject("pictureBoxCreditos.BackgroundImage");
            pictureBoxCreditos.Location = new Point(0, 0);
            pictureBoxCreditos.Name = "pictureBoxCreditos";
            pictureBoxCreditos.Size = new Size(1920, 118);
            pictureBoxCreditos.TabIndex = 0;
            pictureBoxCreditos.TabStop = false;
            // 
            // BtnCreditoVoltarInicioLeiLucas
            // 
            BtnCreditoVoltarInicioLeiLucas.BackColor = Color.Transparent;
            BtnCreditoVoltarInicioLeiLucas.BackgroundImage = (Image)resources.GetObject("BtnCreditoVoltarInicioLeiLucas.BackgroundImage");
            BtnCreditoVoltarInicioLeiLucas.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCreditoVoltarInicioLeiLucas.FlatAppearance.BorderSize = 0;
            BtnCreditoVoltarInicioLeiLucas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnCreditoVoltarInicioLeiLucas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnCreditoVoltarInicioLeiLucas.FlatStyle = FlatStyle.Flat;
            BtnCreditoVoltarInicioLeiLucas.ImagemHover = (Image)resources.GetObject("BtnCreditoVoltarInicioLeiLucas.ImagemHover");
            BtnCreditoVoltarInicioLeiLucas.ImagemNormal = (Image)resources.GetObject("BtnCreditoVoltarInicioLeiLucas.ImagemNormal");
            BtnCreditoVoltarInicioLeiLucas.Location = new Point(1621, 29);
            BtnCreditoVoltarInicioLeiLucas.Name = "BtnCreditoVoltarInicioLeiLucas";
            BtnCreditoVoltarInicioLeiLucas.Size = new Size(254, 63);
            BtnCreditoVoltarInicioLeiLucas.TabIndex = 12;
            BtnCreditoVoltarInicioLeiLucas.UseVisualStyleBackColor = false;
            BtnCreditoVoltarInicioLeiLucas.Click += BtnCreditoVoltarInicioLeiLucas_Click;
            // 
            // FormCreditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(BtnCreditoVoltarInicioLeiLucas);
            Controls.Add(pictureBoxCreditos);
            Name = "FormCreditos";
            Text = "Créditos";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreditos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCreditos;
        private teste.ImageHoverButton BtnCreditoVoltarInicioLeiLucas;
    }
}