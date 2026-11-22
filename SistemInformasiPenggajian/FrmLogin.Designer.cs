namespace SistemInformasiPenggajian
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtKeluar = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 40);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 6;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 81);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(85, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(132, 23);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(85, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(132, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtKeluar
            // 
            txtKeluar.Location = new Point(130, 131);
            txtKeluar.Name = "txtKeluar";
            txtKeluar.Size = new Size(87, 28);
            txtKeluar.TabIndex = 10;
            txtKeluar.Text = "Keluar";
            txtKeluar.UseVisualStyleBackColor = true;
            txtKeluar.Click += txtKeluar_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(26, 131);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 28);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 181);
            Controls.Add(btnLogin);
            Controls.Add(txtKeluar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button txtKeluar;
        private Button btnLogin;
    }
}
