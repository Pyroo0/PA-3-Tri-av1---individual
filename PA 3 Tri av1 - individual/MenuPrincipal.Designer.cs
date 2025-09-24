namespace PA_3_Tri_av1___individual
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProdutos = new Button();
            btnFuncionario = new Button();
            btnFinanceiro = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnProdutos
            // 
            btnProdutos.Font = new Font("Segoe UI", 18F);
            btnProdutos.Location = new Point(22, 64);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(121, 48);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += button1_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.Font = new Font("Segoe UI", 18F);
            btnFuncionario.Location = new Point(159, 64);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(164, 48);
            btnFuncionario.TabIndex = 2;
            btnFuncionario.Text = "Funcionários";
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.Font = new Font("Segoe UI", 18F);
            btnFinanceiro.Location = new Point(338, 64);
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.Size = new Size(134, 48);
            btnFinanceiro.TabIndex = 3;
            btnFinanceiro.Text = "Financeiro";
            btnFinanceiro.UseVisualStyleBackColor = true;
            btnFinanceiro.Click += btnFinanceiro_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(198, 172);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 222);
            Controls.Add(btnSair);
            Controls.Add(btnFinanceiro);
            Controls.Add(btnFuncionario);
            Controls.Add(btnProdutos);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            FormClosing += MenuPrincipal_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button btnProdutos;
        private Button btnFuncionario;
        private Button btnFinanceiro;
        private Button btnSair;
    }
}