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
            var resposta = MessageBox.Show("Voc� realmente deseja sair?", "Sair",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde o formul�rio atual
            var formPrincipal = new FormPrincipal(); // Cria uma nova inst�ncia do formul�rio principal
            formPrincipal.Show(); // Mostra o formul�rio principal
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

        private void txtBoxTwo_Enter(object sender, EventArgs e)
        {
            if (txtBoxTwo.Text == "Senha...")
                txtBoxTwo.Text = "";
        }

        private void txtBoxTwo_Leave(object sender, EventArgs e)
        {
            if (txtBoxTwo.Text == "")
                txtBoxTwo.Text = "Senha...";
        }
    }
}
