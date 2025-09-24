using MySql.Data.MySqlClient;

namespace PA_3_Tri_av1___individual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (FormSharedValues.Instance == null)
                new FormSharedValues();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txtbusuario.Text;
            string senha = txtbsenha.Text;

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT * FROM Funcionario WHERE nome = @nome AND senha = @senha";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show($"Bem-vindo!");


                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }


        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuCadastro menuc = new MenuCadastro();
            menuc.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                MessageBox.Show("Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
