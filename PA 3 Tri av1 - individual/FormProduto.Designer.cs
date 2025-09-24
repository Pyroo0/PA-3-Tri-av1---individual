namespace PA_3_Tri_av1___individual
{
    partial class FormProduto
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
            txtbId = new TextBox();
            label5 = new Label();
            btnrefresh = new Button();
            btnexcluir = new Button();
            btnatualizar = new Button();
            btncadastrar = new Button();
            cmbbtipo = new ComboBox();
            txtbquantidade = new TextBox();
            label4 = new Label();
            txtbpreco = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtbnome = new TextBox();
            dataGridView1 = new DataGridView();
            btnpdfprod = new Button();
            btnexcelprod = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtbId
            // 
            txtbId.Location = new Point(58, 66);
            txtbId.MaxLength = 999999;
            txtbId.Name = "txtbId";
            txtbId.ReadOnly = true;
            txtbId.Size = new Size(246, 23);
            txtbId.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 48);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 30;
            label5.Text = "ID";
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(858, 392);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 29;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(256, 392);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 28;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btnatualizar
            // 
            btnatualizar.Location = new Point(141, 392);
            btnatualizar.Name = "btnatualizar";
            btnatualizar.Size = new Size(75, 23);
            btnatualizar.TabIndex = 27;
            btnatualizar.Text = "Atualizar";
            btnatualizar.UseVisualStyleBackColor = true;
            btnatualizar.Click += btnatualizar_Click;
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(28, 392);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(75, 23);
            btncadastrar.TabIndex = 26;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // cmbbtipo
            // 
            cmbbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbtipo.FormattingEnabled = true;
            cmbbtipo.Location = new Point(58, 176);
            cmbbtipo.Name = "cmbbtipo";
            cmbbtipo.Size = new Size(244, 23);
            cmbbtipo.TabIndex = 25;
            // 
            // txtbquantidade
            // 
            txtbquantidade.Location = new Point(58, 295);
            txtbquantidade.Name = "txtbquantidade";
            txtbquantidade.Size = new Size(246, 23);
            txtbquantidade.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 277);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 23;
            label4.Text = "Quantidade";
            // 
            // txtbpreco
            // 
            txtbpreco.Location = new Point(58, 238);
            txtbpreco.Name = "txtbpreco";
            txtbpreco.Size = new Size(244, 23);
            txtbpreco.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 220);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 21;
            label3.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 158);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 20;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 101);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 19;
            label1.Text = "Nome";
            // 
            // txtbnome
            // 
            txtbnome.Location = new Point(58, 119);
            txtbnome.Name = "txtbnome";
            txtbnome.Size = new Size(246, 23);
            txtbnome.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 351);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnpdfprod
            // 
            btnpdfprod.Location = new Point(1007, 197);
            btnpdfprod.Name = "btnpdfprod";
            btnpdfprod.Size = new Size(96, 29);
            btnpdfprod.TabIndex = 34;
            btnpdfprod.Text = "PDF";
            btnpdfprod.UseVisualStyleBackColor = true;
            btnpdfprod.Click += btnpdfprod_Click;
            // 
            // btnexcelprod
            // 
            btnexcelprod.Location = new Point(1007, 101);
            btnexcelprod.Name = "btnexcelprod";
            btnexcelprod.Size = new Size(96, 29);
            btnexcelprod.TabIndex = 33;
            btnexcelprod.Text = "Excel";
            btnexcelprod.UseVisualStyleBackColor = true;
            btnexcelprod.Click += btnexcelprod_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(1004, 37);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 32;
            label6.Text = "Relatórios";
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 450);
            Controls.Add(btnpdfprod);
            Controls.Add(btnexcelprod);
            Controls.Add(label6);
            Controls.Add(txtbId);
            Controls.Add(label5);
            Controls.Add(btnrefresh);
            Controls.Add(btnexcluir);
            Controls.Add(btnatualizar);
            Controls.Add(btncadastrar);
            Controls.Add(cmbbtipo);
            Controls.Add(txtbquantidade);
            Controls.Add(label4);
            Controls.Add(txtbpreco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbnome);
            Controls.Add(dataGridView1);
            Name = "FormProduto";
            Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbId;
        private Label label5;
        private Button btnrefresh;
        private Button btnexcluir;
        private Button btnatualizar;
        private Button btncadastrar;
        private ComboBox cmbbtipo;
        private TextBox txtbquantidade;
        private Label label4;
        private TextBox txtbpreco;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtbnome;
        private DataGridView dataGridView1;
        private Button btnpdfprod;
        private Button btnexcelprod;
        private Label label6;
    }
}