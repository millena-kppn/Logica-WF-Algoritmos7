﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            //oculta a tela principal 
            this.Hide();
            //cria tela de produtos e a exibe
            new FormProdutos().Show();
        }
    }
}
