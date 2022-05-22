namespace CompanyApp
{
    partial class RecoveryPasswordWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryPasswordWindow));
            this.recoveryPasswordPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mailPictureBox = new System.Windows.Forms.PictureBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.usernamePictureBox = new System.Windows.Forms.PictureBox();
            this.recoveryPasswordLabel = new System.Windows.Forms.Label();
            this.recoveryPasswordButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.recoveryPasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // recoveryPasswordPanel
            // 
            this.recoveryPasswordPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recoveryPasswordPanel.BackgroundImage")));
            this.recoveryPasswordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recoveryPasswordPanel.Controls.Add(this.panel4);
            this.recoveryPasswordPanel.Controls.Add(this.mailPictureBox);
            this.recoveryPasswordPanel.Controls.Add(this.mailTextBox);
            this.recoveryPasswordPanel.Controls.Add(this.panel2);
            this.recoveryPasswordPanel.Controls.Add(this.loginPictureBox);
            this.recoveryPasswordPanel.Controls.Add(this.usernamePictureBox);
            this.recoveryPasswordPanel.Controls.Add(this.recoveryPasswordLabel);
            this.recoveryPasswordPanel.Controls.Add(this.recoveryPasswordButton);
            this.recoveryPasswordPanel.Controls.Add(this.usernameTextBox);
            this.recoveryPasswordPanel.Location = new System.Drawing.Point(31, 36);
            this.recoveryPasswordPanel.Name = "recoveryPasswordPanel";
            this.recoveryPasswordPanel.Size = new System.Drawing.Size(380, 500);
            this.recoveryPasswordPanel.TabIndex = 5;
            this.recoveryPasswordPanel.Click += new System.EventHandler(this.RecoveryPasswordPanel_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(55, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 1);
            this.panel4.TabIndex = 9;
            // 
            // mailPictureBox
            // 
            this.mailPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mailPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mailPictureBox.BackgroundImage")));
            this.mailPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailPictureBox.Location = new System.Drawing.Point(55, 261);
            this.mailPictureBox.Name = "mailPictureBox";
            this.mailPictureBox.Size = new System.Drawing.Size(38, 25);
            this.mailPictureBox.TabIndex = 10;
            this.mailPictureBox.TabStop = false;
            // 
            // mailTextBox
            // 
            this.mailTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mailTextBox.Location = new System.Drawing.Point(103, 268);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(242, 21);
            this.mailTextBox.TabIndex = 8;
            this.mailTextBox.Text = "Mail@yahoo.com";
            this.mailTextBox.Click += new System.EventHandler(this.MailTextBox_Click);
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
            // recoveryPasswordLabel
            // 
            this.recoveryPasswordLabel.AutoSize = true;
            this.recoveryPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.recoveryPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryPasswordLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.recoveryPasswordLabel.Location = new System.Drawing.Point(81, 128);
            this.recoveryPasswordLabel.Name = "recoveryPasswordLabel";
            this.recoveryPasswordLabel.Size = new System.Drawing.Size(227, 29);
            this.recoveryPasswordLabel.TabIndex = 2;
            this.recoveryPasswordLabel.Text = "Recovery Password";
            // 
            // recoveryPasswordButton
            // 
            this.recoveryPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.recoveryPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoveryPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recoveryPasswordButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryPasswordButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.recoveryPasswordButton.Location = new System.Drawing.Point(53, 369);
            this.recoveryPasswordButton.Name = "recoveryPasswordButton";
            this.recoveryPasswordButton.Size = new System.Drawing.Size(290, 37);
            this.recoveryPasswordButton.TabIndex = 0;
            this.recoveryPasswordButton.Text = "Password";
            this.recoveryPasswordButton.UseVisualStyleBackColor = false;
            this.recoveryPasswordButton.Click += new System.EventHandler(this.RecoveryPasswordButton_Click);
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
            this.buttonClose.Location = new System.Drawing.Point(415, 9);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // RecoveryPasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 570);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.recoveryPasswordPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoveryPasswordWindow";
            this.Text = "Recovery Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecoveryPasswordWindow_FormClosing);
            this.Click += new System.EventHandler(this.RecoveryPasswordWindow_Click);
            this.recoveryPasswordPanel.ResumeLayout(false);
            this.recoveryPasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recoveryPasswordPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox usernamePictureBox;
        private System.Windows.Forms.Label recoveryPasswordLabel;
        private System.Windows.Forms.Button recoveryPasswordButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox mailPictureBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Button buttonClose;
    }
}