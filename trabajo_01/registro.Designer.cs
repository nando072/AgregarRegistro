namespace trabajo_01
{
    partial class registro
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
            PictureBox btnRegresar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            btnRegresar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(71, 371);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(50, 50);
            btnRegresar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRegresar.TabIndex = 4;
            btnRegresar.TabStop = false;
            btnRegresar.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 0, 224);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 47);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(208, 211, 212);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(btnRegresar);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 463);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(422, 340);
            button1.Name = "button1";
            button1.Size = new Size(131, 37);
            button1.TabIndex = 3;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(265, 231);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 2;
            label5.Text = "Telefono :";
            label5.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(265, 275);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 2;
            label4.Text = "Correo :";
            label4.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(265, 183);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 2;
            label3.Text = "Apellidos :";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(265, 133);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombres :";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(389, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 30);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(389, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 30);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(389, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(389, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(208, 211, 212);
            label1.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 44);
            label1.Name = "label1";
            label1.Size = new Size(345, 44);
            label1.TabIndex = 0;
            label1.Text = "Registrar sus Datos";
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 510);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registro";
            Text = "registro";
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox btnRegresar;
        private Button button1;
    }
}