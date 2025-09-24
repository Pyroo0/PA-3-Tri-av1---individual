using System.Data;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace PA_3_Tri_av1___individual
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
            cmbbcargos.Items.Add("Funcionário");
            cmbbcargos.Items.Add("Administrador");

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, nome, cargo, salario, senha FROM Funcionario";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
                }

            }
        }


        public void CriarExcel()
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook funcionarios = app.Workbooks.Add();
            Excel.Worksheet planilhafuncionarios;
            planilhafuncionarios = funcionarios.Worksheets.Add();
            planilhafuncionarios.Name = "Funcionários";

            Excel.Range cabecalho = planilhafuncionarios.Range["A1", "E1"];
            cabecalho.Merge();
            cabecalho.Value = "Funcionários";
            cabecalho.Font.Size = 20;
            cabecalho.Font.Bold = true;
            cabecalho.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            planilhafuncionarios.Columns["D"].NumberFormat = "R$ #,###.00";

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                planilhafuncionarios.Cells[2, coluna.Index + 1].Value = coluna.HeaderText;
                planilhafuncionarios.Cells[2, coluna.Index + 1].Font.Bold = true;
                planilhafuncionarios.Cells[2, coluna.Index + 1].Font.Size = 12;
            }


            int linhaExcel = 3;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.IsNewRow) continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    planilhafuncionarios.Cells[linhaExcel, col + 1].Value = linha.Cells[col].Value;
                    planilhafuncionarios.Columns.AutoFit();
                }
                linhaExcel++;
            }

            planilhafuncionarios.SaveAs(@"C:Funcionarios - PedroSteck.xlsx");
            funcionarios.Close();
            app.Quit();
            MessageBox.Show("Excel criado em C:Funcionarios.xlsx");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];

                txtbId.Text = linha.Cells["id"].Value.ToString();
                txtbnome.Text = linha.Cells["nome"].Value.ToString();
                txtbsalario.Text = linha.Cells["salario"].Value.ToString();
                txtbsenha.Text = linha.Cells["senha"].Value.ToString();

                string cargo = linha.Cells["cargo"].Value.ToString();
                cmbbcargos.SelectedItem = cargo;
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nomeusuario = txtbnome.Text;
            string cargo = cmbbcargos.SelectedItem.ToString();
            float salario = float.Parse(txtbsalario.Text);
            string senhausuario = txtbsenha.Text;

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "INSERT INTO Funcionario (nome, cargo, salario, senha) VALUES (@nome, @cargo, @salario, @senha)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nomeusuario);
                cmd.Parameters.AddWithValue("@salario", salario);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@senha", senhausuario);

                cmd.ExecuteNonQuery();
                MessageBox.Show("funcionário cadastrado com sucesso!");
                Refresh();

            }
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbId.Text);
            string nome = txtbnome.Text;
            string cargo = cmbbcargos.SelectedItem.ToString();
            decimal salario = Convert.ToDecimal(txtbsalario.Text);

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE Funcionario 
                           SET nome = @nome, cargo = @cargo, salario = @salario, senha = @senha
                           WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@salario", salario);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@senha", txtbsenha.Text);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Funcionário atualizado com sucesso!");
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum funcionário foi atualizado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbId.Text))
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja excluir este funcionário?",
                "Confirmação",
                MessageBoxButtons.YesNo
            );

            if (confirmacao == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtbId.Text);
                string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    try
                    {
                        conn.Open();
                        string sql = "DELETE FROM Funcionario WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Funcionário excluído com sucesso!");
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                    }
                }
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT id, nome, cargo, salario, senha FROM Funcionario";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnexcelfunc_Click(object sender, EventArgs e)
        {
            CriarExcel();
        }

        public void btnpdffunc_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook funcionarios = app.Workbooks.Add();
            Excel.Worksheet planilhafuncionarios;
            planilhafuncionarios = funcionarios.Worksheets.Add();
            planilhafuncionarios.Name = "Funcionários";

            Excel.Range cabecalho = planilhafuncionarios.Range["A1", "E1"];
            cabecalho.Merge();
            cabecalho.Value = "Funcionários";
            cabecalho.Font.Size = 20;
            cabecalho.Font.Bold = true;
            cabecalho.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            planilhafuncionarios.Columns["D"].NumberFormat = "R$ #,###.00";

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                planilhafuncionarios.Cells[2, coluna.Index + 1].Value = coluna.HeaderText;
                planilhafuncionarios.Cells[2, coluna.Index + 1].Font.Bold = true;
                planilhafuncionarios.Cells[2, coluna.Index + 1].Font.Size = 12;
            }


            int linhaExcel = 3;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.IsNewRow) continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    planilhafuncionarios.Cells[linhaExcel, col + 1].Value = linha.Cells[col].Value;
                    planilhafuncionarios.Columns.AutoFit();
                }
                linhaExcel++;
            }

            string caminhoPDF = @"C:\Funcionarios - PedroSteck.pdf";
            planilhafuncionarios.ExportAsFixedFormat(
                Excel.XlFixedFormatType.xlTypePDF,
                caminhoPDF
            );

            funcionarios.Close(false);
            app.Quit();

            MessageBox.Show("PDF gerado em: C:Funcionarios.pdf");

        }
    }
}
