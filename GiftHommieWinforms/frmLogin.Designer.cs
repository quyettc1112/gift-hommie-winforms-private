namespace GiftHommieWinforms
{
    partial class frmLogin
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
            btnReset = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            lbPassword = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lbLogin = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lbRegister = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(274, 278);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(86, 30);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(147, 278);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(86, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(115, 168);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(115, 100);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(118, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email/Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(115, 192);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(292, 27);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(115, 124);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(292, 27);
            txtEmail.TabIndex = 2;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(210, 36);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(103, 46);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label1.Location = new System.Drawing.Point(115, 245);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(191, 20);
            label1.TabIndex = 7;
            label1.Text = "Don't have an account yet? ";
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Location = new System.Drawing.Point(312, 245);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new System.Drawing.Size(95, 20);
            lbRegister.TabIndex = 8;
            lbRegister.TabStop = true;
            lbRegister.Text = "Register now";
            lbRegister.LinkClicked += lbRegister_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(511, 368);
            Controls.Add(lbRegister);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbLogin);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login | Hommie Store";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbRegister;
    }
}