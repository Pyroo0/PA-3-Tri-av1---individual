namespace PA_3_Tri_av1___individual
{
    partial class FormFuncionario
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
            dataGridView1 = new DataGridView();
            txtbnome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbsalario = new TextBox();
            label4 = new Label();
            txtbsenha = new TextBox();
            cmbbcargos = new ComboBox();
            btncadastrar = new Button();
            btnatualizar = new Button();
            btnexcluir = new Button();
            btnrefresh = new Button();
            label5 = new Label();
            txtbId = new TextBox();
            label6 = new Label();
            btnexcelfunc = new Button();
            btnpdffunc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtbnome
            // 
            txtbnome.Location = new Point(42, 117);
            txtbnome.Name = "txtbnome";
            txtbnome.Size = new Size(246, 23);
            txtbnome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 99);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 156);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 209);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Salário";
            // 
            // txtbsalario
            // 
            txtbsalario.Location = new Point(42, 236);
            txtbsalario.Name = "txtbsalario";
            txtbsalario.Size = new Size(244, 23);
            txtbsalario.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 275);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // txtbsenha
            // 
            txtbsenha.Location = new Point(42, 293);
            txtbsenha.Name = "txtbsenha";
            txtbsenha.Size = new Size(246, 23);
            txtbsenha.TabIndex = 8;
            // 
            // cmbbcargos
            // 
            cmbbcargos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbcargos.FormattingEnabled = true;
            cmbbcargos.Location = new Point(42, 174);
            cmbbcargos.Name = "cmbbcargos";
            cmbbcargos.Size = new Size(244, 23);
            cmbbcargos.TabIndex = 10;
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(12, 390);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(75, 23);
            btncadastrar.TabIndex = 11;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // btnatualizar
            // 
            btnatualizar.Location = new Point(125, 390);
            btnatualizar.Name = "btnatualizar";
            btnatualizar.Size = new Size(75, 23);
            btnatualizar.TabIndex = 12;
            btnatualizar.Text = "Atualizar";
            btnatualizar.UseVisualStyleBackColor = true;
            btnatualizar.Click += btnatualizar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(240, 390);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 13;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(831, 390);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 14;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 46);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 15;
            label5.Text = "ID";
            // 
            // txtbId
            // 
            txtbId.Location = new Point(42, 64);
            txtbId.MaxLength = 999999;
            txtbId.Name = "txtbId";
            txtbId.ReadOnly = true;
            txtbId.Size = new Size(246, 23);
            txtbId.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(994, 35);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 17;
            label6.Text = "Relatórios";
            // 
            // btnexcelfunc
            // 
            btnexcelfunc.Location = new Point(997, 99);
            btnexcelfunc.Name = "btnexcelfunc";
            btnexcelfunc.Size = new Size(96, 29);
            btnexcelfunc.TabIndex = 18;
            btnexcelfunc.Text = "Excel";
            btnexcelfunc.UseVisualStyleBackColor = true;
            btnexcelfunc.Click += btnexcelfunc_Click;
            // 
            // btnpdffunc
            // 
            btnpdffunc.Location = new Point(997, 195);
            btnpdffunc.Name = "btnpdffunc";
            btnpdffunc.Size = new Size(96, 29);
            btnpdffunc.TabIndex = 19;
            btnpdffunc.Text = "PDF";
            btnpdffunc.UseVisualStyleBackColor = true;
            btnpdffunc.Click += btnpdffunc_Click;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 450);
            Controls.Add(btnpdffunc);
            Controls.Add(btnexcelfunc);
            Controls.Add(label6);
            Controls.Add(txtbId);
            Controls.Add(label5);
            Controls.Add(btnrefresh);
            Controls.Add(btnexcluir);
            Controls.Add(btnatualizar);
            Controls.Add(btncadastrar);
            Controls.Add(cmbbcargos);
            Controls.Add(txtbsenha);
            Controls.Add(label4);
            Controls.Add(txtbsalario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbnome);
            Controls.Add(dataGridView1);
            Name = "FormFuncionario";
            Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtbnome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbsalario;
        private Label label4;
        private TextBox txtbsenha;
        private ComboBox cmbbcargos;
        private Button btncadastrar;
        private Button btnatualizar;
        private Button btnexcluir;
        private Button btnrefresh;
        private Label label5;
        private TextBox txtbId;
        private Label label6;
        private Button btnexcelfunc;
        private Button btnpdffunc;
    }
}