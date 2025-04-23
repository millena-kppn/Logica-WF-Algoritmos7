using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Login
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void buttonProdutosVoltar_Click(object sender, EventArgs e)
        {   //oculta a tela produtos
            this.Hide();
            //cria tela principal e a exibe
            new FormPrincipal().Show();
        }
    }
}
