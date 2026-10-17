namespace ProjetoLeiLucasTelas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button2 = new Button();
            VoltarAoInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(565, 854);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(753, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(163, 205);
            button5.Name = "button5";
            button5.Size = new Size(514, 306);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(163, 514);
            button3.Name = "button3";
            button3.Size = new Size(514, 306);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            button3.Click += BtnQueimaduras_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(695, 205);
            button4.Name = "button4";
            button4.Size = new Size(514, 306);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(695, 514);
            button6.Name = "button6";
            button6.Size = new Size(514, 306);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1229, 205);
            button7.Name = "button7";
            button7.Size = new Size(514, 306);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(1229, 514);
            button8.Name = "button8";
            button8.Size = new Size(514, 306);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(39, 45);
            button2.Name = "button2";
            button2.Size = new Size(76, 61);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // VoltarAoInicio
            // 
            VoltarAoInicio.BackColor = Color.Transparent;
            VoltarAoInicio.FlatAppearance.BorderSize = 0;
            VoltarAoInicio.FlatStyle = FlatStyle.Flat;
            VoltarAoInicio.Image = (Image)resources.GetObject("VoltarAoInicio.Image");
            VoltarAoInicio.Location = new Point(1593, 49);
            VoltarAoInicio.Name = "VoltarAoInicio";
            VoltarAoInicio.Size = new Size(254, 62);
            VoltarAoInicio.TabIndex = 15;
            VoltarAoInicio.UseVisualStyleBackColor = false;
            VoltarAoInicio.Click += VoltarAoInicio_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(VoltarAoInicio);
            Controls.Add(button2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button2;
        private Button VoltarAoInicio;
    }
}