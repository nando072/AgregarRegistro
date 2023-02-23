namespace trabajo_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnRegistro_Click(object sender, EventArgs e)
        {
            registro Form1 = new registro();
            Form1.Owner = this;
            Form1.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            VerLista Form1 = new VerLista();
            Form1.Owner = this;
            Form1.ShowDialog();
        }
    }
}