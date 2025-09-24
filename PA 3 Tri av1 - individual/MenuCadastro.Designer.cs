namespace PA_3_Tri_av1___individual
{
    partial class MenuCadastro
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
            label1 = new Label();
            txtbnomeusuario = new TextBox();
            txtbsenhausuario = new TextBox();
            btncadastro = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(75, 21);
            label1.Name = "label1";
            label1.Size = new Size(153, 46);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // txtbnomeusuario
            // 
            txtbnomeusuario.Location = new Point(61, 113);
            txtbnomeusuario.Name = "txtbnomeusuario";
            txtbnomeusuario.Size = new Size(178, 23);
            txtbnomeusuario.TabIndex = 1;
            // 
            // txtbsenhausuario
            // 
            txtbsenhausuario.Location = new Point(61, 179);
            txtbsenhausuario.Name = "txtbsenhausuario";
            txtbsenhausuario.Size = new Size(178, 23);
            txtbsenhausuario.TabIndex = 2;
            // 
            // btncadastro
            // 
            btncadastro.Location = new Point(111, 230);
            btncadastro.Name = "btncadastro";
            btncadastro.Size = new Size(75, 23);
            btncadastro.TabIndex = 3;
            btncadastro.Text = "Cadastrar";
            btncadastro.UseVisualStyleBackColor = true;
            btncadastro.Click += btncadastro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 84);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome de usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 161);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "senha";
            // 
            // button2
            // 
            button2.Location = new Point(12, 344);
            button2.Name = "button2";
            button2.Size = new Size(48, 24);
            button2.TabIndex = 6;
            button2.Text = "voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 380);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncadastro);
            Controls.Add(txtbsenhausuario);
            Controls.Add(txtbnomeusuario);
            Controls.Add(label1);
            Name = "MenuCadastro";
            Text = "MenuCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbnomeusuario;
        private TextBox txtbsenhausuario;
        private Button btncadastro;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}