namespace LoginForm
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.signIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LoginBox.Location = new System.Drawing.Point(102, 10);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 21);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.Text = "User_1";
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignIn_KeyDown);
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.loginText.Location = new System.Drawing.Point(12, 10);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(44, 16);
            this.loginText.TabIndex = 2;
            this.loginText.Text = "Login:";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PasswordText.Location = new System.Drawing.Point(12, 44);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(71, 16);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.Text = "Password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PasswordBox.Location = new System.Drawing.Point(102, 41);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 21);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.Text = "1234";
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignIn_KeyDown);
            // 
            // signIn
            // 
            this.signIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.signIn.Location = new System.Drawing.Point(131, 68);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 34);
            this.signIn.TabIndex = 5;
            this.signIn.Text = "Sign in";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // signUp
            // 
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.signUp.Location = new System.Drawing.Point(12, 68);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 34);
            this.signUp.TabIndex = 6;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 114);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.Text = "Welcome!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

