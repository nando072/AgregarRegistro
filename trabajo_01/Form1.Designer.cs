namespace trabajo_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelControlador = new Panel();
            label1 = new Label();
            btnLista = new Button();
            btnRegistro = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelControlador.SuspendLayout();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(27, 0, 224);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(976, 47);
            BarraTitulo.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(882, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 35);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(929, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 35);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelControlador
            // 
            panelControlador.BackColor = Color.FromArgb(208, 211, 212);
            panelControlador.Controls.Add(label1);
            panelControlador.Controls.Add(btnLista);
            panelControlador.Controls.Add(btnRegistro);
            panelControlador.Dock = DockStyle.Fill;
            panelControlador.ForeColor = SystemColors.Control;
            panelControlador.Location = new Point(0, 47);
            panelControlador.Name = "panelControlador";
            panelControlador.Size = new Size(976, 463);
            panelControlador.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(322, 42);
            label1.Name = "label1";
            label1.Size = new Size(320, 44);
            label1.TabIndex = 2;
            label1.Text = "Registro de Datos";
            // 
            // btnLista
            // 
            btnLista.Cursor = Cursors.Hand;
            btnLista.FlatAppearance.BorderSize = 0;
            btnLista.FlatStyle = FlatStyle.Flat;
            btnLista.Font = new Font("Bookman Old Style", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLista.ForeColor = SystemColors.ActiveCaptionText;
            btnLista.Image = (Image)resources.GetObject("btnLista.Image");
            btnLista.Location = new Point(540, 126);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(240, 240);
            btnLista.TabIndex = 1;
            btnLista.Text = "Ver Lista";
            btnLista.TextAlign = ContentAlignment.BottomCenter;
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Bookman Old Style", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistro.Image = (Image)resources.GetObject("btnRegistro.Image");
            btnRegistro.Location = new Point(214, 126);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(240, 240);
            btnRegistro.TabIndex = 0;
            btnRegistro.Text = "Registrar";
            btnRegistro.TextAlign = ContentAlignment.BottomCenter;
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 510);
            Controls.Add(panelControlador);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelControlador.ResumeLayout(false);
            panelControlador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Panel panelControlador;
        private PictureBox btnMinimizar;
        private Button btnLista;
        private Button btnRegistro;
        private Label label1;
    }
}