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
    public partial class RecoveryPasswordWindow : Form
    {

        ServiceReference1.WebService1SoapClient server;
        LoginWindow loginWindow;
        public RecoveryPasswordWindow(LoginWindow loginWindow, ServiceReference1.WebService1SoapClient server)
        {
            InitializeComponent();
            this.server = server;
            this.loginWindow = loginWindow;
        }

        private void RecoveryPasswordButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.server.getPassword(this.usernameTextBox.Text, getMail(this.mailTextBox.Text)));
            this.Close();
        }

        private string getMail(string mail)
        {
            string[] s = mail.Split('@');
            if (s[0] == mail)
            {
                mail = mail + "@yahoo.com";
            }
            return mail;
        }

        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text == "Username")
            {
                this.usernameTextBox.Text = "";
            }
        }

        private void MailTextBox_Click(object sender, EventArgs e)
        {
            if (this.mailTextBox.Text == "Mail@yahoo.com")
            {
                this.mailTextBox.Text = "";
            }
        }

        private void RecoveryPasswordPanel_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text == "")
            {
                this.usernameTextBox.Text = "Username";
            }
            if (this.mailTextBox.Text == "")
            {
                this.mailTextBox.Text = "Mail@yahoo.com";
            }
        }

        private void RecoveryPasswordWindow_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text == "")
            {
                this.usernameTextBox.Text = "Username";
            }
            if (this.mailTextBox.Text == "")
            {
                this.mailTextBox.Text = "Mail@yahoo.com";
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecoveryPasswordWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginWindow.Enabled = true;
        }
    }
}
