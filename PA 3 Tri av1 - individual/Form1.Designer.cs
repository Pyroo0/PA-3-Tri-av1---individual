namespace PA_3_Tri_av1___individual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbllogin = new Label();
            lblusuario = new Label();
            lblsenha = new Label();
            txtbusuario = new TextBox();
            txtbsenha = new TextBox();
            btnlogin = new Button();
            lblcadastro = new Label();
            btncadastro = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 25F);
            lbllogin.Location = new Point(97, 19);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(103, 46);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "Login";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(123, 88);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(47, 15);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(123, 161);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(39, 15);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha";
            // 
            // txtbusuario
            // 
            txtbusuario.Location = new Point(53, 106);
            txtbusuario.Name = "txtbusuario";
            txtbusuario.Size = new Size(193, 23);
            txtbusuario.TabIndex = 3;
            // 
            // txtbsenha
            // 
            txtbsenha.Location = new Point(53, 179);
            txtbsenha.Name = "txtbsenha";
            txtbsenha.Size = new Size(193, 23);
            txtbsenha.TabIndex = 4;
            txtbsenha.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(107, 219);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Entrar";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblcadastro
            // 
            lblcadastro.AutoSize = true;
            lblcadastro.Location = new Point(69, 257);
            lblcadastro.Name = "lblcadastro";
            lblcadastro.Size = new Size(165, 15);
            lblcadastro.TabIndex = 6;
            lblcadastro.Text = "não possui login? cadastre-se:";
            // 
            // btncadastro
            // 
            btncadastro.Location = new Point(107, 287);
            btncadastro.Name = "btncadastro";
            btncadastro.Size = new Size(75, 23);
            btncadastro.TabIndex = 7;
            btncadastro.Text = "cadastro";
            btncadastro.UseVisualStyleBackColor = true;
            btncadastro.Click += btncadastro_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7F);
            button1.Location = new Point(212, 348);
            button1.Name = "button1";
            button1.Size = new Size(80, 20);
            button1.TabIndex = 8;
            button1.Text = "Testar conexão";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 380);
            Controls.Add(button1);
            Controls.Add(btncadastro);
            Controls.Add(lblcadastro);
            Controls.Add(btnlogin);
            Controls.Add(txtbsenha);
            Controls.Add(txtbusuario);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "login";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private Label lblsenha;
        private TextBox txtbusuario;
        private TextBox txtbsenha;
        private Button btnlogin;
        private Label lblcadastro;
        private Button btncadastro;
        private Button button1;
    }
}
