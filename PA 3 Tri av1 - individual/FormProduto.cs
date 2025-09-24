using System.Data;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace PA_3_Tri_av1___individual
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            cmbbtipo.Items.Add("Produto");
            cmbbtipo.Items.Add("Serviço");
            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, nome, tipo, preco, quantidade_estoque FROM Produto";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }

            }
        }

        public void CriarExcel()
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook produtos = app.Workbooks.Add();
            Excel.Worksheet planilhaprodutos;
            planilhaprodutos = produtos.Worksheets.Add();
            planilhaprodutos.Name = "Produtos - Pedro Steck";

            Excel.Range cabecalho = planilhaprodutos.Range["A1", "E1"];
            cabecalho.Merge();
            cabecalho.Value = "Produtos";
            cabecalho.Font.Size = 20;
            cabecalho.Font.Bold = true;
            cabecalho.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            planilhaprodutos.Columns["D"].NumberFormat = "R$ #,###.00";

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                planilhaprodutos.Cells[2, coluna.Index + 1].Value = coluna.HeaderText;
                planilhaprodutos.Cells[2, coluna.Index + 1].Font.Bold = true;
                planilhaprodutos.Cells[2, coluna.Index + 1].Font.Size = 12;
            }


            int linhaExcel = 3;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.IsNewRow) continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    planilhaprodutos.Cells[linhaExcel, col + 1].Value = linha.Cells[col].Value;
                    planilhaprodutos.Columns.AutoFit();
                }
                linhaExcel++;
            }

            planilhaprodutos.SaveAs(@"C:Produtos-PedroSteck.xlsx");
            produtos.Close();
            app.Quit();
            MessageBox.Show("Excel criado em C:Produtos - PedroSteck.xlsx");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];

                txtbId.Text = linha.Cells["id"].Value.ToString();
                txtbnome.Text = linha.Cells["nome"].Value.ToString();
                txtbpreco.Text = linha.Cells["preco"].Value.ToString();
                txtbquantidade.Text = linha.Cells["quantidade_estoque"].Value.ToString();

                string tipo = linha.Cells["tipo"].Value.ToString();
                cmbbtipo.SelectedItem = tipo;
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nomeproduto = txtbnome.Text;
            string tipo = cmbbtipo.SelectedItem.ToString();
            float preco = float.Parse(txtbpreco.Text);
            string quantidade = txtbquantidade.Text;

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "INSERT INTO Produto (nome, tipo, preco, quantidade_estoque) VALUES (@nome, @tipo, @preco, @quantidade_estoque)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nomeproduto);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@quantidade_estoque", quantidade);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!");

            }
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbId.Text);
            string nome = txtbnome.Text;
            string tipo = cmbbtipo.SelectedItem.ToString();
            decimal preco = Convert.ToDecimal(txtbpreco.Text);

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE Produto
                           SET nome = @nome, tipo = @tipo, preco = @preco, quantidade_estoque = @quantidade_estoque
                           WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@quantidade_estoque", txtbquantidade.Text);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Produto atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto foi atualizado.");
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
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja excluir este produto?",
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
                        string sql = "DELETE FROM Produto WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Produto excluído com sucesso!");

                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.");
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
            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT id, nome, tipo, preco, quantidade_estoque FROM Produto";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void btnexcelprod_Click(object sender, EventArgs e)
        {
            CriarExcel();
        }

        private void btnpdfprod_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook produtos = app.Workbooks.Add();
            Excel.Worksheet planilhaprodutos;
            planilhaprodutos = produtos.Worksheets.Add();
            planilhaprodutos.Name = "Produtos - Pedro Steck";

            Excel.Range cabecalho = planilhaprodutos.Range["A1", "E1"];
            cabecalho.Merge();
            cabecalho.Value = "Produtos";
            cabecalho.Font.Size = 20;
            cabecalho.Font.Bold = true;
            cabecalho.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            planilhaprodutos.Columns["D"].NumberFormat = "R$ #,###.00";

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                planilhaprodutos.Cells[2, coluna.Index + 1].Value = coluna.HeaderText;
                planilhaprodutos.Cells[2, coluna.Index + 1].Font.Bold = true;
                planilhaprodutos.Cells[2, coluna.Index + 1].Font.Size = 12;
            }


            int linhaExcel = 3;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.IsNewRow) continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    planilhaprodutos.Cells[linhaExcel, col + 1].Value = linha.Cells[col].Value;
                    planilhaprodutos.Columns.AutoFit();
                }
                linhaExcel++;
            }


            string caminhoPDF = @"C:\Produtos - PedroSteck.pdf";
            planilhaprodutos.ExportAsFixedFormat(
                Excel.XlFixedFormatType.xlTypePDF,
                caminhoPDF
            );

            produtos.Close(false);
            app.Quit();

            MessageBox.Show("PDF gerado em: C:Produtos - PedroSteck.pdf");

        }
    }
}
