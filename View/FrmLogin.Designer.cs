namespace SistemaAtendimento.View
{
    partial class FrmLogin
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
            btnEntrar = new Button();
            Login = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(123, 191);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(166, 37);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 15.75F);
            Login.Location = new Point(35, 84);
            Login.Name = "Login";
            Login.Size = new Size(71, 30);
            Login.TabIndex = 1;
            Login.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(35, 134);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15.75F);
            txtEmail.Location = new Point(111, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 35);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "edson@email.com";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 15.75F);
            txtSenha.Location = new Point(111, 131);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(279, 35);
            txtSenha.TabIndex = 4;
            txtSenha.Text = "senha123";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 47);
            label1.TabIndex = 5;
            label1.Text = "Bem vindo";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 260);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(Login);
            Controls.Add(btnEntrar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label Login;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label1;
    }
}