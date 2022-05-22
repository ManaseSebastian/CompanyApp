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
    public partial class RegisterWindow : Form
    {
        ServiceReference1.WebService1SoapClient server;
        public RegisterWindow(ServiceReference1.WebService1SoapClient server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.server.addUser(this.usernameTextBox.Text, this.nameTextBox.Text, this.passwordTextBox.Text, getMail(this.mailTextBox.Text));
            this.Close();
        }

        private string getMail(string mail) {
           string[] s =  mail.Split('@');
            if (s[0] == mail) {
                mail = mail + "@yahoo.com";
            }
            return mail;
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text == "Name")
            {
                this.nameTextBox.Text = "";
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

        private void MailTextBox_Click(object sender, EventArgs e)
        {
            if (this.mailTextBox.Text == "Mail@yahoo.com")
            {
                this.mailTextBox.Text = "";
            }
        }

        private void AccountPanel_Click(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text == "")
            {
                this.nameTextBox.Text = "Name";
            }
            if (this.usernameTextBox.Text == "")
            {
                this.usernameTextBox.Text = "Username";
            }
            if (this.passwordTextBox.Text == "")
            {
                this.passwordTextBox.Text = "Password";
            }
            if (this.mailTextBox.Text == "")
            {
                this.mailTextBox.Text = "Mail@yahoo.com";
            }
        }

        private void RegisterWindow_Click(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text == "")
            {
                this.nameTextBox.Text = "Name";
            }
            if (this.usernameTextBox.Text == "")
            {
                this.usernameTextBox.Text = "Username";
            }
            if (this.passwordTextBox.Text == "")
            {
                this.passwordTextBox.Text = "Password";
            }
            if (this.mailTextBox.Text == "")
            {
                this.mailTextBox.Text = "Mail@yahoo.com";
            }
        }
    }
}
