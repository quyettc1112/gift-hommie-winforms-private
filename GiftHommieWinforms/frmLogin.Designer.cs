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
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(318, 322);
            btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(108, 38);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(202, 322);
            btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(108, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(169, 210);
            lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(87, 25);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(169, 125);
            lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(140, 25);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email/Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(169, 240);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(306, 31);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(169, 155);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(306, 31);
            txtEmail.TabIndex = 2;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(262, 45);
            lbLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(122, 54);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(645, 405);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbLogin);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login | Hommie Store";
            Load += frmLogin_Load;
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
    }
}