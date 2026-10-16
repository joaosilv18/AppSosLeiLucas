namespace ProjetoLeiLucasTelas
{
    partial class FormEngCriancas01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEngCriancas01));
            richTextBox1 = new RichTextBox();
            btnVoltarPagBebe01 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.MenuText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.Cross;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(860, 540);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(125, 20);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Em Desenvolvimento...";
            // 
            // btnVoltarPagBebe01
            // 
            btnVoltarPagBebe01.BackgroundImage = (Image)resources.GetObject("btnVoltarPagBebe01.BackgroundImage");
            btnVoltarPagBebe01.FlatStyle = FlatStyle.Flat;
            btnVoltarPagBebe01.Image = (Image)resources.GetObject("btnVoltarPagBebe01.Image");
            btnVoltarPagBebe01.Location = new Point(35, 28);
            btnVoltarPagBebe01.Name = "btnVoltarPagBebe01";
            btnVoltarPagBebe01.Size = new Size(272, 76);
            btnVoltarPagBebe01.TabIndex = 23;
            btnVoltarPagBebe01.UseVisualStyleBackColor = true;
            btnVoltarPagBebe01.Click += btnVoltarPagBebe01_Click;
            // 
            // FormEngCriancas01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnVoltarPagBebe01);
            Controls.Add(richTextBox1);
            Name = "FormEngCriancas01";
            Text = "FormEngCriancas01";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnVoltarPagBebe01;
    }
}