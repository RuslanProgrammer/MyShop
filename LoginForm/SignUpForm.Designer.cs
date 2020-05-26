namespace LoginForm
{
    partial class SignUpForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(131, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sign up!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.passwordBox.Location = new System.Drawing.Point(102, 42);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 21);
            this.passwordBox.TabIndex = 10;
            this.passwordBox.Text = "1234";
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.passwordText.Location = new System.Drawing.Point(12, 45);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(71, 16);
            this.passwordText.TabIndex = 9;
            this.passwordText.Text = "Password:";
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.loginText.Location = new System.Drawing.Point(12, 11);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(44, 16);
            this.loginText.TabIndex = 8;
            this.loginText.Text = "Login:";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.loginBox.Location = new System.Drawing.Point(102, 11);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 21);
            this.loginBox.TabIndex = 7;
            this.loginBox.Text = "User_1";
            this.loginBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 114);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignUpForm";
            this.Text = "Sing up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}