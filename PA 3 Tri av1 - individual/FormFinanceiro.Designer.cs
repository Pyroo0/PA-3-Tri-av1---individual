namespace PA_3_Tri_av1___individual
{
    partial class FormFinanceiro
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
            btnpdffincanc = new Button();
            btnexcelfinanc = new Button();
            label6 = new Label();
            txtbId = new TextBox();
            label5 = new Label();
            btnrefresh = new Button();
            btnexcluir = new Button();
            btnatualizar = new Button();
            btncadastrar = new Button();
            cmbbtipo = new ComboBox();
            txtbquantidade = new TextBox();
            label4 = new Label();
            txtbvalor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtbdescricao = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            dtpdata = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnpdffincanc
            // 
            btnpdffincanc.Location = new Point(1017, 197);
            btnpdffincanc.Name = "btnpdffincanc";
            btnpdffincanc.Size = new Size(96, 29);
            btnpdffincanc.TabIndex = 53;
            btnpdffincanc.Text = "PDF";
            btnpdffincanc.UseVisualStyleBackColor = true;
            btnpdffincanc.Click += btnpdffincanc_Click;
            // 
            // btnexcelfinanc
            // 
            btnexcelfinanc.Location = new Point(1017, 101);
            btnexcelfinanc.Name = "btnexcelfinanc";
            btnexcelfinanc.Size = new Size(96, 29);
            btnexcelfinanc.TabIndex = 52;
            btnexcelfinanc.Text = "Excel";
            btnexcelfinanc.UseVisualStyleBackColor = true;
            btnexcelfinanc.Click += btnexcelfinanc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(1014, 37);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 51;
            label6.Text = "Relatórios";
            // 
            // txtbId
            // 
            txtbId.Location = new Point(66, 42);
            txtbId.MaxLength = 999999;
            txtbId.Name = "txtbId";
            txtbId.ReadOnly = true;
            txtbId.Size = new Size(246, 23);
            txtbId.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 24);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 49;
            label5.Text = "ID";
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(919, 392);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 48;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(266, 392);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 47;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btnatualizar
            // 
            btnatualizar.Location = new Point(151, 392);
            btnatualizar.Name = "btnatualizar";
            btnatualizar.Size = new Size(75, 23);
            btnatualizar.TabIndex = 46;
            btnatualizar.Text = "Atualizar";
            btnatualizar.UseVisualStyleBackColor = true;
            btnatualizar.Click += btnatualizar_Click;
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(38, 392);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(75, 23);
            btncadastrar.TabIndex = 45;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // cmbbtipo
            // 
            cmbbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbtipo.FormattingEnabled = true;
            cmbbtipo.Location = new Point(68, 155);
            cmbbtipo.Name = "cmbbtipo";
            cmbbtipo.Size = new Size(244, 23);
            cmbbtipo.TabIndex = 44;
            // 
            // txtbquantidade
            // 
            txtbquantidade.Location = new Point(66, 275);
            txtbquantidade.Name = "txtbquantidade";
            txtbquantidade.Size = new Size(246, 23);
            txtbquantidade.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 257);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 42;
            label4.Text = "Quantidade";
            // 
            // txtbvalor
            // 
            txtbvalor.Location = new Point(66, 215);
            txtbvalor.Name = "txtbvalor";
            txtbvalor.Size = new Size(244, 23);
            txtbvalor.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 197);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 40;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 137);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 39;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 81);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 38;
            label1.Text = "Descrição";
            // 
            // txtbdescricao
            // 
            txtbdescricao.Location = new Point(66, 99);
            txtbdescricao.Name = "txtbdescricao";
            txtbdescricao.Size = new Size(246, 23);
            txtbdescricao.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 351);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 315);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 55;
            label7.Text = "Data";
            // 
            // dtpdata
            // 
            dtpdata.Location = new Point(66, 333);
            dtpdata.Name = "dtpdata";
            dtpdata.Size = new Size(246, 23);
            dtpdata.TabIndex = 56;
            // 
            // FormFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 450);
            Controls.Add(dtpdata);
            Controls.Add(label7);
            Controls.Add(btnpdffincanc);
            Controls.Add(btnexcelfinanc);
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
            Controls.Add(txtbvalor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbdescricao);
            Controls.Add(dataGridView1);
            Name = "FormFinanceiro";
            Text = "Financeiro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnpdffincanc;
        private Button btnexcelfinanc;
        private Label label6;
        private TextBox txtbId;
        private Label label5;
        private Button btnrefresh;
        private Button btnexcluir;
        private Button btnatualizar;
        private Button btncadastrar;
        private ComboBox cmbbtipo;
        private TextBox txtbquantidade;
        private Label label4;
        private TextBox txtbvalor;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtbdescricao;
        private DataGridView dataGridView1;
        private Label label7;
        private DateTimePicker dtpdata;
    }
}