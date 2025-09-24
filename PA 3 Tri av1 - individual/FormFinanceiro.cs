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
using Excel = Microsoft.Office.Interop.Excel;

namespace PA_3_Tri_av1___individual
{
    public partial class FormFinanceiro : Form
    {
        public FormFinanceiro()
        {
            InitializeComponent();
            cmbbtipo.Items.Add("Receita");
            cmbbtipo.Items.Add("Despesa");

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, data_lancamento, descricao, tipo, valor, quantidade  FROM Financeiro";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar financeiro: " + ex.Message);
                }

            }
        }

        public void Refresh()
        {
            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT id, data_lancamento, descricao, tipo, valor, quantidade  FROM Financeiro";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public void CriarExcel()
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook financeiro = app.Workbooks.Add();
            Excel.Worksheet planilhafinanceiro;
            planilhafinanceiro = financeiro.Worksheets.Add();
            planilhafinanceiro.Name = "Financeiro";

            Excel.Range cabecalho = planilhafinanceiro.Range["A1", "F1"];
            cabecalho.Merge();
            cabecalho.Value = "Financeiro";
            cabecalho.Font.Size = 20;
            cabecalho.Font.Bold = true;
            cabecalho.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            planilhafinanceiro.Columns["E"].NumberFormat = "R$ #,###.00";

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                planilhafinanceiro.Cells[2, coluna.Index + 1].Value = coluna.HeaderText;
                planilhafinanceiro.Cells[2, coluna.Index + 1].Font.Bold = true;
                planilhafinanceiro.Cells[2, coluna.Index + 1].Font.Size = 12;
            }


            int linhaExcel = 3;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.IsNewRow) continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    planilhafinanceiro.Cells[linhaExcel, col + 1].Value = linha.Cells[col].Value;
                    planilhafinanceiro.Columns.AutoFit();
                }
                linhaExcel++;
            }

            planilhafinanceiro.SaveAs(@"C:Finenaceiro - PedroSteck.xlsx");
            financeiro.Close();
            app.Quit();
            MessageBox.Show("Excel criado em C:Financeiro.xlsx");
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string descricao = txtbdescricao.Text;
            string tipo = cmbbtipo.SelectedItem.ToString();
            float valor = float.Parse(txtbvalor.Text);
            string quantidade = txtbquantidade.Text;
            string data_lancamento = dtpdata.Value.ToString("yyyy-MM-dd");

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "INSERT INTO Financeiro (descricao, tipo, valor, quantidade,data_lancamento) VALUES (@descricao, @tipo, @valor, @quantidade, @data_lancamento)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@data_lancamento", data_lancamento);

                cmd.ExecuteNonQuery();

                if (cmbbtipo.SelectedItem.ToString() == "Despesa")
                {
                    MessageBox.Show("Despesa cadastrada com sucesso!");
                }
                else if (cmbbtipo.SelectedItem.ToString() == "Receita")
                {
                    MessageBox.Show("Receita cadastrada com sucesso!");
                }
                Refresh();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];

                txtbId.Text = linha.Cells["id"].Value.ToString();
                txtbdescricao.Text = linha.Cells["descricao"].Value.ToString();
                txtbvalor.Text = linha.Cells["valor"].Value.ToString();
                txtbquantidade.Text = linha.Cells["quantidade"].Value.ToString();

                string cargo = linha.Cells["tipo"].Value.ToString();
                cmbbtipo.SelectedItem = cargo;

                string dataLancamento = linha.Cells["data_lancamento"].Value.ToString();
                if (DateTime.TryParse(dataLancamento, out DateTime data))
                {
                    dtpdata.Value = data;
                }
            }
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbId.Text);
            string descricao = txtbdescricao.Text;
            string tipo = cmbbtipo.SelectedItem.ToString();
            decimal valor = Convert.ToDecimal(txtbvalor.Text);
            string data_lancamento = dtpdata.Value.ToString("yyyy-MM-dd");

            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE Financeiro 
                           SET descricao = @descricao, tipo = @tipo, valor = @valor, quantidade = @quantidade
                           WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("descricao", descricao);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@quantidade", txtbquantidade.Text);
                    cmd.Parameters.AddWithValue("@data_lancamento", data_lancamento);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Processo atualizado com sucesso!");
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum processo foi atualizado.");
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
                MessageBox.Show("Selecione um processo para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja excluir este processo?",
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
                        string sql = "DELETE FROM Financeiro WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Processo excluído com sucesso!");
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Processo não encontrado.");
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

        private void btnexcelfinanc_Click(object sender, EventArgs e)
        {
            CriarExcel();
        }

        private void btnpdffincanc_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook financeiro = app.Workbooks.Add();
            Excel.Worksheet planilhafinanceiro;
            planilhafinanceiro = financeiro.Worksheets.Add();
            planilhafinanceiro.Name = "Financeiro";

            Excel.Range cabecalho = planilhafinanceiro.Range["A1", "F1"];
            cabecalho.Merge();
            cabecalho.Value = "Financeiro";
            cabecalho.Font.Size = 20;
            cabecalho.Font.Bold = true;
            cabecalho.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            planilhafinanceiro.Columns["E"].NumberFormat = "R$ #,###.00";

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                planilhafinanceiro.Cells[2, coluna.Index + 1].Value = coluna.HeaderText;
                planilhafinanceiro.Cells[2, coluna.Index + 1].Font.Bold = true;
                planilhafinanceiro.Cells[2, coluna.Index + 1].Font.Size = 12;
            }


            int linhaExcel = 3;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.IsNewRow) continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    planilhafinanceiro.Cells[linhaExcel, col + 1].Value = linha.Cells[col].Value;
                    planilhafinanceiro.Columns.AutoFit();
                }
                linhaExcel++;
            }
            string caminhoPDF = @"C:\Financeiro - PedroSteck.pdf";
            planilhafinanceiro.ExportAsFixedFormat(
                Excel.XlFixedFormatType.xlTypePDF,
                caminhoPDF
            );

            financeiro.Close(false);
            app.Quit();

            MessageBox.Show("PDF gerado em: C:Financeiro.pdf");

        }
    }
}
