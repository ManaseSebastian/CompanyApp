using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyApp
{
    public partial class LoginWindow : Form
    {
        private ServiceReference1.WebService1SoapClient server;
        public LoginWindow()
        {
            InitializeComponent();
            this.server = new ServiceReference1.WebService1SoapClient();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            new RegisterWindow(this.server).Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (server.isUser(this.usernameTextBox.Text, this.passwordTextBox.Text))
            {
                new Form3(server.isAdmin(this.usernameTextBox.Text), this.usernameTextBox.Text, this.server).Show();
            } else
            {
                MessageBox.Show("Wrong account!");
            }
        }

        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text == "Username")
            {
                this.usernameTextBox.Text = "";
            }
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Text == "Password")
            {
                this.passwordTextBox.Text = "";
            }
        }

        private void LoginPanel_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text == "")
            {
                this.usernameTextBox.Text = "Username";
            }
            if (this.passwordTextBox.Text == "")
            {
                this.passwordTextBox.Text = "Password";
            }
        }

        private void LoginWindow_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text == "")
            {
                this.usernameTextBox.Text = "Username";
            }
            if (this.passwordTextBox.Text == "")
            {
                this.passwordTextBox.Text = "Password";
            }
        }

        private void ForgetButton_Click(object sender, EventArgs e)
        {
            new RecoveryPasswordWindow(this, this.server).Show();
            this.Enabled = false;
        }
    }
}
