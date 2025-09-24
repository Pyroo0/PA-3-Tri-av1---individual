using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace grafico_PA_3_av1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carregaGrafico();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void carregaGrafico()
        {
            string conexao = "Server=localhost;Database=sistema_financeiro;Uid=root;Pwd=''";

            string query = @"SELECT data_lancamento, tipo, valor FROM Financeiro ORDER BY data_lancamento";

            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(conexao))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "C2";


            Series entradas = new Series("Entradas");
            entradas.ChartType = SeriesChartType.Column;
            entradas.Color = System.Drawing.Color.Green;
            entradas.LabelFormat = "C2";

            Series saidas = new Series("Saídas");
            saidas.ChartType = SeriesChartType.Column;
            saidas.Color = System.Drawing.Color.Red;
            saidas.LabelFormat = "C2";

            Series saldo = new Series("Saldo");
            saldo.ChartType = SeriesChartType.Line;
            saldo.Color = System.Drawing.Color.Blue;
            saldo.BorderWidth = 3;
            saldo.LabelFormat = "C2";

            decimal saldoAcumulado = 0;

            foreach (DataRow row in dt.Rows)
            {
                string data = Convert.ToDateTime(row["data_lancamento"]).ToString("dd/MM/yyyy");
                string tipo = row["Tipo"].ToString();
                decimal valor = Convert.ToDecimal(row["Valor"]);

                if (tipo == "Receita")
                {
                    entradas.Points.AddXY(data, valor);
                    saidas.Points.AddXY(data, 0);
                    saldoAcumulado += valor;
                }
                else if (tipo == "Despesa")
                {
                    entradas.Points.AddXY(data, 0);
                    saidas.Points.AddXY(data, valor);
                    saldoAcumulado -= valor;
                }

                saldo.Points.AddXY(data, saldoAcumulado);
            }

            chart1.Series.Add(entradas);
            chart1.Series.Add(saidas);
            chart1.Series.Add(saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carregaGrafico();
        }
    }
}
