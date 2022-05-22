using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CompanyApp
{
    public partial class Form3 : Form
    {
        private ServiceReference1.WebService1SoapClient server;
        private bool isTaskMenuPanelVisible;
        private bool isFriendsMenuPanelVisible;
        private bool isAdmin;
        private string userId;
        private int chatCode;

        public Form3(bool isAdmin, string userId, ServiceReference1.WebService1SoapClient server)
        {
            InitializeComponent();
            this.tasksPanel.Visible = false;
            this.taskMenuPanel.Visible = false;
            this.friendsMenuPanel.Visible = false;
            this.makeAdminPanel.Visible = false;
            this.makeFriendPanel.Visible = false;
            this.chatPanel.Visible = false;
            this.meetingPanel.Visible = false;
            this.isTaskMenuPanelVisible = false;
            this.isFriendsMenuPanelVisible = false;
            this.isAdmin = isAdmin;
            this.adminButton.Visible = isAdmin;
            this.userId = userId;
            this.server = server;
            this.deadlineDateTimePicker.MinDate = DateTime.Today;
            this.deadlineDateTimePicker.MaxDate = new DateTime(2024, 1, 1);
            this.displayPersons();
            this.showFriends();
            this.displayMeetings();
            this.friendButton2.Click += new EventHandler(FriendButton2_Click);
            this.friendButton1.Click += new EventHandler(FriendButton1_Click);
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            this.isTaskMenuPanelVisible = !this.isTaskMenuPanelVisible;
            if (this.isTaskMenuPanelVisible)
            {
                this.tasksPanel.Visible = true;
                this.mainPanel.Visible = false;
                this.makeFriendPanel.Visible = false;
                this.makeFriendPanel.Visible = false;
                this.showTasks();
                this.isFriendsMenuPanelVisible = false;
                this.friendsMenuPanel.Visible = false;
                if (!this.isAdmin)
                {
                    this.addUpdateTaskPanel.Visible = false;
                } else
                {
                    this.taskMenuPanel.Visible = true;
                }
            } else
            {
                this.tasksPanel.Visible = false;
                this.mainPanel.Visible = true;
                this.taskMenuPanel.Visible = false;
            }
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            this.isFriendsMenuPanelVisible = !this.isFriendsMenuPanelVisible;
            this.mainPanel.Visible = true;
            if (this.isFriendsMenuPanelVisible)
            {
                this.tasksPanel.Visible = false;
                this.friendsMenuPanel.Visible = true;
                this.isTaskMenuPanelVisible = false;
                this.taskMenuPanel.Visible = false;
            } else
            {
                this.friendsMenuPanel.Visible = false;
                this.makeFriendPanel.Visible = false;
            }
        }

        private void MeetingsButton_Click(object sender, EventArgs e)
        {
            if (this.isTaskMenuPanelVisible)
            {
                this.TaskButton_Click(sender, e);
            }
            if (this.isFriendsMenuPanelVisible)
            {
                this.FriendsButton_Click(sender, e);
            }
            this.makeAdminPanel.Visible = false;
            this.mainPanel.Visible = false;
            this.makeFriendPanel.Visible = false;
            this.meetingPanel.Visible = true;
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            if (this.isTaskMenuPanelVisible)
            {
                this.TaskButton_Click(sender, e);
            }
            if (this.isFriendsMenuPanelVisible)
            {
                this.FriendsButton_Click(sender, e);
            }
            this.makeAdminPanel.Visible = true;
            this.mainPanel.Visible = false;
            this.makeFriendPanel.Visible = false;
            this.meetingPanel.Visible = false;
        }

        private void showTasks()
        {
            this.viewTasksListBox.Items.Clear();
            DataSet tasks = this.server.getTasks();
            foreach (DataRow indexTask in tasks.Tables["Tasks"].Rows)
            {
                this.viewTasksListBox.Items.Add(indexTask["Name_Task"].ToString());
            }
        }

        private void ViewTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.viewTasksListBox.SelectedIndex != -1)
            {
                // ritchTextBox
                this.viewTasksRichTextBox.Text = "";
                DataSet tasks = server.getTasks();
                foreach (DataRow indexTask in tasks.Tables["Tasks"].Rows)
                {
                    if (indexTask["Name_Task"].ToString() == this.viewTasksListBox.SelectedItem.ToString())
                    {
                        this.viewTasksRichTextBox.Text = "Requirements: \n" + indexTask["Requirements"].ToString() + "\n Deadline: \n" + indexTask["Deadline"];
                        this.deadlineDateTimePicker.Value = Convert.ToDateTime(indexTask["Deadline"]);
                        this.requirementsRichTextBox.Text = indexTask["Requirements"].ToString();
                    }
                }
                taskNameTextBox.Text = this.viewTasksListBox.SelectedItem.ToString();
                for (int i = 0; i < this.personsCheckedListBox.Items.Count; i++)
                {
                    personsCheckedListBox.SetItemChecked(i, false);
                }
                foreach (string userIndex in this.server.getUsersByTaskName(this.viewTasksListBox.SelectedItem.ToString()))
                {
                    this.personsCheckedListBox.SetItemChecked(personsCheckedListBox.Items.IndexOf(userIndex), true);
                }
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (this.taskNameTextBox.Text != "")
            {
                if (this.requirementsRichTextBox.Text != "")
                {
                    string persons = "";
                    foreach (string person in this.personsCheckedListBox.CheckedItems)
                    {
                        persons = persons + this.server.getUserByName(person) + ",";
                    }
                    if (persons != "")
                    {
                        this.server.addTask(this.userId, this.requirementsRichTextBox.Text, this.deadlineDateTimePicker.Value, persons, this.taskNameTextBox.Text);
                        this.viewTasksListBox.Items.Add(this.taskNameTextBox.Text);
                        this.clearComponents();
                    }
                    else
                    {
                        MessageBox.Show("Select the persons for this task.");
                    }
                }
                else
                {
                    MessageBox.Show("You don't have any requirements");
                }
            }
            else
            {
                MessageBox.Show("You don't have a Task Name");
            }
        }

        private void displayPersons()
        {
            DataSet users = server.getUsers();
            foreach (DataRow indexUser in users.Tables["Users"].Rows)
            {
                personsCheckedListBox.Items.Add(indexUser["Name"].ToString());
            }
        }

        private void clearComponents()
        {
            this.taskNameTextBox.Text = "";
            for (int i = 0; i < this.personsCheckedListBox.Items.Count; i++)
            {
                personsCheckedListBox.SetItemChecked(i, false);
            }
            this.requirementsRichTextBox.Text = "";
            this.deadlineDateTimePicker.Value = DateTime.Now;
        }

        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            this.makeFriendPanel.Visible = true;
            this.mainPanel.Visible = false;
            this.friendButton1.Visible = false;
            this.friendButton2.Text = "Send request";
            this.showUsersExceptFriends();
        }

        private void showUsersExceptFriends()
        {
            this.usersListBox.Items.Clear();
            foreach (string user in this.server.getUsersExceptFriends(this.userId))
            {
                this.usersListBox.Items.Add(user);
            }
        }

        private void FriendRequestButton_Click(object sender, EventArgs e)
        {
            this.makeFriendPanel.Visible = true;
            this.mainPanel.Visible = false;
            this.friendButton1.Visible = true;
            this.friendButton1.Text = "Accept";
            this.friendButton2.Text = "Decline";
            this.showFriendRequests();
        }

        private void UsersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.usersListBox.IndexFromPoint(e.Location) == -1)
            {
                this.usersListBox.ClearSelected();
            }
        }

        public void FriendButton2_Click(object sender, EventArgs e)
        {
            if (this.friendButton2.Text == "Send request")
            {
                if (this.usersListBox.SelectedIndex != -1)
                {
                    this.server.friendRequest(this.userId, this.server.getUserByName(this.usersListBox.SelectedItem.ToString()));
                }
                else
                {
                    MessageBox.Show("You must select an user first!");
                }
            } else
            {
                if (this.usersListBox.SelectedIndex != -1)
                {
                    this.server.declineFriendRequest(this.userId, this.server.getUserByName(this.usersListBox.SelectedItem.ToString()));
                    this.showFriendRequests();
                }
                else
                {
                    MessageBox.Show("You must select an user first!");
                }
            }
        }

        public void showFriendRequests()
        {
            this.usersListBox.Items.Clear();
            foreach (string user in this.server.getFriendRequests(this.userId))
            {
                this.usersListBox.Items.Add(this.server.getUserNameById(user));
            }
        }

        public void FriendButton1_Click(object sender, EventArgs e)
        {
            if (this.usersListBox.SelectedIndex != -1)
            {
                server.acceptFriendRequest(this.userId, server.getUserByName(this.usersListBox.SelectedItem.ToString()));
                this.showFriends();
                this.showFriendRequests();
            }
        }

        public void showFriends()
        {
            this.friendsListBox.Items.Clear();
            foreach (string index in this.server.getFriendsOfUser(this.userId))
            {
                this.friendsListBox.Items.Add(server.getUserNameById(index));
            }
        }

        private void UpdateTaskButton_Click(object sender, EventArgs e)
        {
            if (this.taskNameTextBox.Text != "")
            {
                if (this.requirementsRichTextBox.Text != "")
                {
                    string persons = "";
                    foreach (string person in this.personsCheckedListBox.CheckedItems)
                    {
                        persons = persons + this.server.getUserByName(person) + ",";
                    }
                    if (persons != "")
                    {
                        this.server.updateTask(this.server.getCodeTaskByName(this.viewTasksListBox.SelectedItem.ToString()), persons, this.requirementsRichTextBox.Text, this.deadlineDateTimePicker.Value, this.taskNameTextBox.Text);
                        this.viewTasksRichTextBox.Text = "Requirements: \n" + this.requirementsRichTextBox.Text + "\n Deadline: \n" + deadlineDateTimePicker.Value;
                        this.showTasks();

                    }
                    else
                    {
                        MessageBox.Show("Select the persons for this task.");
                    }
                }
                else
                {
                    MessageBox.Show("You don't have any requirements");
                }
            }
            else
            {
                MessageBox.Show("You don't have a Task Name");
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            this.server.deleteTask(this.viewTasksListBox.SelectedItem.ToString());
            this.clearComponents();
            this.viewTasksRichTextBox.Text = "";
            this.showTasks();
        }

        private void FriendsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.friendsListBox.SelectedIndex != -1)
            {
                this.chatPanel.Visible = true;
                this.chatPanel.BringToFront();
                this.chatCode = this.server.getChatCodeByUsers(this.userId, this.server.getUserByName(this.friendsListBox.SelectedItem.ToString()));
                this.chatRichTextBox.Text = this.server.getChatByUsers(this.userId, this.server.getUserByName(this.friendsListBox.SelectedItem.ToString()));
            }
        }

        private void ChatRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SendRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.server.addMessage(this.chatCode, this.userId + ": " + this.sendRichTextBox.Text.Substring(0, this.sendRichTextBox.Text.Length - 1));
                this.sendRichTextBox.Text = "";
                this.chatRichTextBox.Text = this.server.getChatByCode(this.chatCode);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.chatPanel.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.friendsListBox.SelectedIndex == -1)
            {
                this.showFriends();
            }
            if (this.usersListBox.SelectedIndex == -1)
            {
                if (this.friendButton1.Visible)
                {
                    this.showFriendRequests();
                } else
                {
                    this.showUsersExceptFriends();
                }
            }
            if (this.viewTasksListBox.SelectedIndex == -1)
            {
                this.showTasks();
            }
            if (this.personsCheckedListBox.SelectedItem == null)
            {
                this.displayPersons();
            }
            if (this.userListBox.SelectedIndex == -1)
            {
                this.showUsers();
            }
            this.chatRichTextBox.Text = this.server.getChatByCode(this.chatCode);
        }

        private void DeleteFriendButton_Click(object sender, EventArgs e)
        {
            if (this.friendsListBox.SelectedIndex != -1)
            {
                this.server.deleteFriend(this.userId, this.server.getUserByName(this.friendsListBox.SelectedItem.ToString()));
                this.showFriends();
            } else
            {
                MessageBox.Show("You must select a friend first!");
            }
        }

        private void showUsers()
        {
            this.userListBox.Items.Clear();
            DataSet users = this.server.getUsers();
            foreach (DataRow indexUser in users.Tables["Users"].Rows)
            {
                if (indexUser["Role"].ToString() != "Admin")
                {
                    this.userListBox.Items.Add(indexUser["Name"].ToString());
                }
            }
        }

        private void makeAdminButton_Click(object sender, EventArgs e)
        {
            this.server.makeAdmin(this.server.getUserByName(this.userListBox.SelectedItem.ToString()));
            this.showUsers();
        }

        private void addMeetingButton_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("Meetings.txt", true);
            streamWriter.WriteLine("{0} at {1}", meetingTextBox.Text, meetingDateTimePicker.Value);
            streamWriter.Close();
            this.meetingsListBox.Items.Add(meetingTextBox.Text + " at " + meetingDateTimePicker.Value);
        }

        private void displayMeetings()
        {
            StreamReader streamReader = new StreamReader("Meetings.txt");
            string indexMessage;
            while ((indexMessage = streamReader.ReadLine()) != null)
            {
                meetingsListBox.Items.Add(indexMessage);
            }
        }
    }
}
