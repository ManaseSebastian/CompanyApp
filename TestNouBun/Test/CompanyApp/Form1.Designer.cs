namespace CompanyApp
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.buttonClose = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.usernamePictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.forgetButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.Location = new System.Drawing.Point(415, 8);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPanel.BackgroundImage")));
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.panel2);
            this.loginPanel.Controls.Add(this.loginPictureBox);
            this.loginPanel.Controls.Add(this.passwordPictureBox);
            this.loginPanel.Controls.Add(this.usernamePictureBox);
            this.loginPanel.Controls.Add(this.panel3);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.forgetButton);
            this.loginPanel.Controls.Add(this.registerButton);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Location = new System.Drawing.Point(30, 50);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(380, 500);
            this.loginPanel.TabIndex = 4;
            this.loginPanel.Click += new System.EventHandler(this.LoginPanel_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(55, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 5;
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPictureBox.BackgroundImage")));
            this.loginPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPictureBox.Location = new System.Drawing.Point(133, 3);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(115, 109);
            this.loginPictureBox.TabIndex = 7;
            this.loginPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordPictureBox.BackgroundImage")));
            this.passwordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordPictureBox.Location = new System.Drawing.Point(55, 241);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(41, 31);
            this.passwordPictureBox.TabIndex = 6;
            this.passwordPictureBox.TabStop = false;
            // 
            // usernamePictureBox
            // 
            this.usernamePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.usernamePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernamePictureBox.BackgroundImage")));
            this.usernamePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usernamePictureBox.Location = new System.Drawing.Point(55, 180);
            this.usernamePictureBox.Name = "usernamePictureBox";
            this.usernamePictureBox.Size = new System.Drawing.Size(41, 33);
            this.usernamePictureBox.TabIndex = 6;
            this.usernamePictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(55, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 1);
            this.panel3.TabIndex = 4;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginLabel.Location = new System.Drawing.Point(73, 127);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(247, 29);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login to Your Account";
            // 
            // forgetButton
            // 
            this.forgetButton.BackColor = System.Drawing.Color.Transparent;
            this.forgetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.forgetButton.FlatAppearance.BorderSize = 0;
            this.forgetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.forgetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.forgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.forgetButton.Location = new System.Drawing.Point(54, 302);
            this.forgetButton.Name = "forgetButton";
            this.forgetButton.Size = new System.Drawing.Size(188, 31);
            this.forgetButton.TabIndex = 0;
            this.forgetButton.Text = "Forget Password?";
            this.forgetButton.UseVisualStyleBackColor = false;
            this.forgetButton.Click += new System.EventHandler(this.ForgetButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.registerButton.Location = new System.Drawing.Point(54, 410);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(290, 37);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogin.Location = new System.Drawing.Point(54, 353);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(290, 37);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTextBox.Location = new System.Drawing.Point(102, 251);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(242, 21);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameTextBox.Location = new System.Drawing.Point(102, 192);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(242, 21);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Click += new System.EventHandler(this.UsernameTextBox_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 570);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.buttonClose);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWindow";
            this.Click += new System.EventHandler(this.LoginWindow_Click);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.PictureBox usernamePictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button forgetButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}

