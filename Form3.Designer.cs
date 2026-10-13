namespace ProjetoLeiLucasTelas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            telaAjuda = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            VoltarAoInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)telaAjuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // telaAjuda
            // 
            telaAjuda.BackgroundImage = (Image)resources.GetObject("telaAjuda.BackgroundImage");
            telaAjuda.Location = new Point(1, 0);
            telaAjuda.Name = "telaAjuda";
            telaAjuda.Size = new Size(1920, 118);
            telaAjuda.TabIndex = 0;
            telaAjuda.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(1, 956);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1920, 84);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(787, 283);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(430, 362);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(787, 706);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(430, 152);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(885, 981);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(222, 48);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(77, 967);
            button1.Name = "button1";
            button1.Size = new Size(76, 62);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // VoltarAoInicio
            // 
            VoltarAoInicio.BackColor = Color.Transparent;
            VoltarAoInicio.FlatAppearance.BorderSize = 0;
            VoltarAoInicio.FlatStyle = FlatStyle.Flat;
            VoltarAoInicio.Image = (Image)resources.GetObject("VoltarAoInicio.Image");
            VoltarAoInicio.Location = new Point(1638, 967);
            VoltarAoInicio.Name = "VoltarAoInicio";
            VoltarAoInicio.Size = new Size(254, 63);
            VoltarAoInicio.TabIndex = 7;
            VoltarAoInicio.UseVisualStyleBackColor = false;
            VoltarAoInicio.Click += VoltarAoInicio_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(VoltarAoInicio);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(telaAjuda);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)telaAjuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox telaAjuda;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1;
        private Button VoltarAoInicio;
    }
}