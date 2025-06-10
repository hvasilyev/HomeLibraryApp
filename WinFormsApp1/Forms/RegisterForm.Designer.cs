namespace HomeLibrary
{
    partial class RegisterForm
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
            txtNewPassword = new TextBox();
            txtNewUsername = new TextBox();
            btnCreateAccount = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(121, 40);
            label1.Name = "label1";
            label1.Size = new Size(270, 48);
            label1.TabIndex = 1;
            label1.Text = "Create account";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNewPassword.Location = new Point(43, 219);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Password";
            txtNewPassword.Size = new Size(406, 69);
            txtNewPassword.TabIndex = 8;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNewUsername.Location = new Point(43, 133);
            txtNewUsername.Multiline = true;
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.PlaceholderText = "Username";
            txtNewUsername.Size = new Size(406, 69);
            txtNewUsername.TabIndex = 7;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Orange;
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(43, 325);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(406, 69);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCreateAccount);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(txtNewUsername);
            panel1.Location = new Point(301, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 436);
            panel1.TabIndex = 9;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 695);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNewPassword;
        private TextBox txtNewUsername;
        private Button btnCreateAccount;
        private Panel panel1;
    }
}