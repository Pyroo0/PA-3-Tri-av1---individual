using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_3_Tri_av1___individual
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProduto produtoForm = new FormProduto();
            produtoForm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario funcionarioForm = new FormFuncionario();
            funcionarioForm.Show();

        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            FormFinanceiro financeiroForm = new FormFinanceiro();
            financeiroForm.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menulogin = new Form1();
            menulogin.Show();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
