using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PA_3_Tri_av1___individual
{
    public partial class MenuCadastro : Form
    {
        public MenuCadastro()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            string nomeusuario = txtbnomeusuario.Text;
            string senhausuario = txtbsenhausuario.Text;

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "INSERT INTO Funcionario (nome, cargo, senha) VALUES (@nome, @cargo, @senha)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nomeusuario);
                cmd.Parameters.AddWithValue("@senha", senhausuario);
                cmd.Parameters.AddWithValue("@cargo", "funcionario");

                cmd.ExecuteNonQuery();
                MessageBox.Show("funcionário cadastrado com sucesso!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menulogin = new Form1();
            menulogin.Show();
        }
    }
}
