namespace WF_Login
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            txtBoxOne.Text = "Nome cadastrado";
            txtBoxOne.ForeColor = Color.Green;
            txtBoxTwo.Text = "Senha aceita";
            txtBoxTwo.ForeColor = Color.Green;
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza a janela
        }

        private void txtBoxOne_Enter(object sender, EventArgs e)
        {
            if (txtBoxOne.Text == "Nome...")
                txtBoxOne.Text = "";
        }

        private void txtBoxOne_Leave(object sender, EventArgs e)
        {
            if (txtBoxOne.Text == "")
                txtBoxOne.Text = "Nome...";
        }

        
    }
}
