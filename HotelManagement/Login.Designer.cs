namespace HotelManagement
{
    partial class Login
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
            usernameLabel = new Label();
            signinButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            lblSignIn = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(219, 160);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // signinButton
            // 
            signinButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signinButton.BackColor = Color.Green;
            signinButton.ForeColor = Color.White;
            signinButton.Location = new Point(220, 359);
            signinButton.Margin = new Padding(4, 5, 4, 5);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(312, 85);
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign in";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(219, 269);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(313, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.BackColor = Color.FromArgb(225, 225, 225);
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(219, 185);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(313, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(217, 244);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.BackColor = SystemColors.Control;
            lblSignIn.ForeColor = Color.Red;
            lblSignIn.Location = new Point(250, 334);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(253, 20);
            lblSignIn.TabIndex = 7;
            lblSignIn.Text = "Please enter username and password";
            lblSignIn.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 619);
            Controls.Add(lblSignIn);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(signinButton);
            Controls.Add(usernameTextBox);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Login";
            Padding = new Padding(27, 92, 27, 31);
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private Label lblSignIn;
    }
}
