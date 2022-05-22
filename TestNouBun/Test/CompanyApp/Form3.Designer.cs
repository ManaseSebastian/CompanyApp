namespace CompanyApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.adminButton = new System.Windows.Forms.Button();
            this.meetingsButton = new System.Windows.Forms.Button();
            this.friendsMenuPanel = new System.Windows.Forms.Panel();
            this.friendRequestButton = new System.Windows.Forms.Button();
            this.deleteFriendButton = new System.Windows.Forms.Button();
            this.addFriendButton = new System.Windows.Forms.Button();
            this.friendsButton = new System.Windows.Forms.Button();
            this.taskMenuPanel = new System.Windows.Forms.Panel();
            this.updateTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.friendsPanel = new System.Windows.Forms.Panel();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.friendsImagePanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.viewTasksPanel = new System.Windows.Forms.Panel();
            this.viewTasksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.viewTasksListBox = new System.Windows.Forms.ListBox();
            this.addUpdateTaskPanel = new System.Windows.Forms.Panel();
            this.requirementsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.requirementsLabel = new System.Windows.Forms.Label();
            this.personsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.personsLabel = new System.Windows.Forms.Label();
            this.deadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.makeFriendPanel = new System.Windows.Forms.Panel();
            this.friendButton2 = new System.Windows.Forms.Button();
            this.friendButton1 = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.makeAdminPanel = new System.Windows.Forms.Panel();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.makeAdminButton = new System.Windows.Forms.Button();
            this.meetingPanel = new System.Windows.Forms.Panel();
            this.meetingsListBox = new System.Windows.Forms.ListBox();
            this.addMeetingButton = new System.Windows.Forms.Button();
            this.meetingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.meetingTextBox = new System.Windows.Forms.TextBox();
            this.meetingLabel = new System.Windows.Forms.Label();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.sendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.friendsMenuPanel.SuspendLayout();
            this.taskMenuPanel.SuspendLayout();
            this.friendsPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tasksPanel.SuspendLayout();
            this.viewTasksPanel.SuspendLayout();
            this.addUpdateTaskPanel.SuspendLayout();
            this.makeFriendPanel.SuspendLayout();
            this.makeAdminPanel.SuspendLayout();
            this.meetingPanel.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Black;
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuPanel.Controls.Add(this.adminButton);
            this.menuPanel.Controls.Add(this.meetingsButton);
            this.menuPanel.Controls.Add(this.friendsMenuPanel);
            this.menuPanel.Controls.Add(this.friendsButton);
            this.menuPanel.Controls.Add(this.taskMenuPanel);
            this.menuPanel.Controls.Add(this.taskButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(207, 520);
            this.menuPanel.TabIndex = 0;
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.Transparent;
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.Location = new System.Drawing.Point(0, 466);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(207, 40);
            this.adminButton.TabIndex = 29;
            this.adminButton.Text = "Make Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // meetingsButton
            // 
            this.meetingsButton.BackColor = System.Drawing.Color.Transparent;
            this.meetingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.meetingsButton.ForeColor = System.Drawing.Color.White;
            this.meetingsButton.Location = new System.Drawing.Point(0, 426);
            this.meetingsButton.Name = "meetingsButton";
            this.meetingsButton.Size = new System.Drawing.Size(207, 40);
            this.meetingsButton.TabIndex = 28;
            this.meetingsButton.Text = "Meetings";
            this.meetingsButton.UseVisualStyleBackColor = false;
            this.meetingsButton.Click += new System.EventHandler(this.MeetingsButton_Click);
            // 
            // friendsMenuPanel
            // 
            this.friendsMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.friendsMenuPanel.Controls.Add(this.friendRequestButton);
            this.friendsMenuPanel.Controls.Add(this.deleteFriendButton);
            this.friendsMenuPanel.Controls.Add(this.addFriendButton);
            this.friendsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendsMenuPanel.Location = new System.Drawing.Point(0, 310);
            this.friendsMenuPanel.Name = "friendsMenuPanel";
            this.friendsMenuPanel.Size = new System.Drawing.Size(207, 116);
            this.friendsMenuPanel.TabIndex = 5;
            // 
            // friendRequestButton
            // 
            this.friendRequestButton.BackColor = System.Drawing.Color.Transparent;
            this.friendRequestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.friendRequestButton.ForeColor = System.Drawing.Color.White;
            this.friendRequestButton.Location = new System.Drawing.Point(0, 80);
            this.friendRequestButton.Name = "friendRequestButton";
            this.friendRequestButton.Size = new System.Drawing.Size(207, 40);
            this.friendRequestButton.TabIndex = 11;
            this.friendRequestButton.Text = "Friend Request";
            this.friendRequestButton.UseVisualStyleBackColor = false;
            this.friendRequestButton.Click += new System.EventHandler(this.FriendRequestButton_Click);
            // 
            // deleteFriendButton
            // 
            this.deleteFriendButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteFriendButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteFriendButton.ForeColor = System.Drawing.Color.White;
            this.deleteFriendButton.Location = new System.Drawing.Point(0, 40);
            this.deleteFriendButton.Name = "deleteFriendButton";
            this.deleteFriendButton.Size = new System.Drawing.Size(207, 40);
            this.deleteFriendButton.TabIndex = 10;
            this.deleteFriendButton.Text = "Delete Friend";
            this.deleteFriendButton.UseVisualStyleBackColor = false;
            this.deleteFriendButton.Click += new System.EventHandler(this.DeleteFriendButton_Click);
            // 
            // addFriendButton
            // 
            this.addFriendButton.BackColor = System.Drawing.Color.Transparent;
            this.addFriendButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addFriendButton.ForeColor = System.Drawing.Color.White;
            this.addFriendButton.Location = new System.Drawing.Point(0, 0);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(207, 40);
            this.addFriendButton.TabIndex = 9;
            this.addFriendButton.Text = "Add Friend";
            this.addFriendButton.UseVisualStyleBackColor = false;
            this.addFriendButton.Click += new System.EventHandler(this.AddFriendButton_Click);
            // 
            // friendsButton
            // 
            this.friendsButton.BackColor = System.Drawing.Color.Transparent;
            this.friendsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.friendsButton.ForeColor = System.Drawing.Color.White;
            this.friendsButton.Location = new System.Drawing.Point(0, 270);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(207, 40);
            this.friendsButton.TabIndex = 10;
            this.friendsButton.Text = "Friends";
            this.friendsButton.UseVisualStyleBackColor = false;
            this.friendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // taskMenuPanel
            // 
            this.taskMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.taskMenuPanel.Controls.Add(this.updateTaskButton);
            this.taskMenuPanel.Controls.Add(this.deleteTaskButton);
            this.taskMenuPanel.Controls.Add(this.addTaskButton);
            this.taskMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskMenuPanel.Location = new System.Drawing.Point(0, 150);
            this.taskMenuPanel.Name = "taskMenuPanel";
            this.taskMenuPanel.Size = new System.Drawing.Size(207, 120);
            this.taskMenuPanel.TabIndex = 8;
            // 
            // updateTaskButton
            // 
            this.updateTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.updateTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateTaskButton.ForeColor = System.Drawing.Color.White;
            this.updateTaskButton.Location = new System.Drawing.Point(0, 80);
            this.updateTaskButton.Name = "updateTaskButton";
            this.updateTaskButton.Size = new System.Drawing.Size(207, 40);
            this.updateTaskButton.TabIndex = 19;
            this.updateTaskButton.Text = "Update Task";
            this.updateTaskButton.UseVisualStyleBackColor = false;
            this.updateTaskButton.Click += new System.EventHandler(this.UpdateTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteTaskButton.ForeColor = System.Drawing.Color.White;
            this.deleteTaskButton.Location = new System.Drawing.Point(0, 40);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(207, 40);
            this.deleteTaskButton.TabIndex = 18;
            this.deleteTaskButton.Text = "Delete Task";
            this.deleteTaskButton.UseVisualStyleBackColor = false;
            this.deleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.addTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Location = new System.Drawing.Point(0, 0);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(207, 40);
            this.addTaskButton.TabIndex = 17;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // taskButton
            // 
            this.taskButton.BackColor = System.Drawing.Color.Transparent;
            this.taskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskButton.ForeColor = System.Drawing.Color.White;
            this.taskButton.Location = new System.Drawing.Point(0, 110);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(207, 40);
            this.taskButton.TabIndex = 7;
            this.taskButton.Text = "Task";
            this.taskButton.UseVisualStyleBackColor = false;
            this.taskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Transparent;
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(207, 110);
            this.logoPanel.TabIndex = 5;
            // 
            // friendsPanel
            // 
            this.friendsPanel.BackColor = System.Drawing.Color.Black;
            this.friendsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("friendsPanel.BackgroundImage")));
            this.friendsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.friendsPanel.Controls.Add(this.friendsListBox);
            this.friendsPanel.Controls.Add(this.friendsImagePanel);
            this.friendsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.friendsPanel.Location = new System.Drawing.Point(931, 0);
            this.friendsPanel.Name = "friendsPanel";
            this.friendsPanel.Size = new System.Drawing.Size(196, 520);
            this.friendsPanel.TabIndex = 1;
            // 
            // friendsListBox
            // 
            this.friendsListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.friendsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.friendsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsListBox.ForeColor = System.Drawing.Color.White;
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 18;
            this.friendsListBox.Items.AddRange(new object[] {
            "Cristi",
            "Sebi"});
            this.friendsListBox.Location = new System.Drawing.Point(0, 128);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(196, 392);
            this.friendsListBox.TabIndex = 3;
            this.friendsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FriendsListBox_MouseDoubleClick);
            // 
            // friendsImagePanel
            // 
            this.friendsImagePanel.BackColor = System.Drawing.Color.Transparent;
            this.friendsImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("friendsImagePanel.BackgroundImage")));
            this.friendsImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.friendsImagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendsImagePanel.Location = new System.Drawing.Point(0, 0);
            this.friendsImagePanel.Name = "friendsImagePanel";
            this.friendsImagePanel.Size = new System.Drawing.Size(196, 128);
            this.friendsImagePanel.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Controls.Add(this.mainPanel);
            this.panel7.Controls.Add(this.tasksPanel);
            this.panel7.Controls.Add(this.makeFriendPanel);
            this.panel7.Controls.Add(this.makeAdminPanel);
            this.panel7.Controls.Add(this.meetingPanel);
            this.panel7.Controls.Add(this.chatPanel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(207, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(724, 520);
            this.panel7.TabIndex = 4;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(724, 520);
            this.mainPanel.TabIndex = 9;
            // 
            // tasksPanel
            // 
            this.tasksPanel.BackColor = System.Drawing.Color.Transparent;
            this.tasksPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tasksPanel.BackgroundImage")));
            this.tasksPanel.Controls.Add(this.viewTasksPanel);
            this.tasksPanel.Controls.Add(this.addUpdateTaskPanel);
            this.tasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksPanel.Location = new System.Drawing.Point(0, 0);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(724, 520);
            this.tasksPanel.TabIndex = 7;
            // 
            // viewTasksPanel
            // 
            this.viewTasksPanel.Controls.Add(this.viewTasksRichTextBox);
            this.viewTasksPanel.Controls.Add(this.viewTasksListBox);
            this.viewTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTasksPanel.Location = new System.Drawing.Point(267, 0);
            this.viewTasksPanel.Name = "viewTasksPanel";
            this.viewTasksPanel.Size = new System.Drawing.Size(457, 520);
            this.viewTasksPanel.TabIndex = 2;
            // 
            // viewTasksRichTextBox
            // 
            this.viewTasksRichTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.viewTasksRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTasksRichTextBox.ForeColor = System.Drawing.Color.White;
            this.viewTasksRichTextBox.Location = new System.Drawing.Point(195, 0);
            this.viewTasksRichTextBox.Name = "viewTasksRichTextBox";
            this.viewTasksRichTextBox.Size = new System.Drawing.Size(262, 520);
            this.viewTasksRichTextBox.TabIndex = 4;
            this.viewTasksRichTextBox.Text = "";
            // 
            // viewTasksListBox
            // 
            this.viewTasksListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.viewTasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewTasksListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewTasksListBox.ForeColor = System.Drawing.Color.White;
            this.viewTasksListBox.FormattingEnabled = true;
            this.viewTasksListBox.ItemHeight = 16;
            this.viewTasksListBox.Location = new System.Drawing.Point(0, 0);
            this.viewTasksListBox.Name = "viewTasksListBox";
            this.viewTasksListBox.Size = new System.Drawing.Size(195, 520);
            this.viewTasksListBox.TabIndex = 3;
            this.viewTasksListBox.SelectedIndexChanged += new System.EventHandler(this.ViewTasksListBox_SelectedIndexChanged);
            // 
            // addUpdateTaskPanel
            // 
            this.addUpdateTaskPanel.Controls.Add(this.requirementsRichTextBox);
            this.addUpdateTaskPanel.Controls.Add(this.requirementsLabel);
            this.addUpdateTaskPanel.Controls.Add(this.personsCheckedListBox);
            this.addUpdateTaskPanel.Controls.Add(this.personsLabel);
            this.addUpdateTaskPanel.Controls.Add(this.deadlineDateTimePicker);
            this.addUpdateTaskPanel.Controls.Add(this.deadlineLabel);
            this.addUpdateTaskPanel.Controls.Add(this.taskNameTextBox);
            this.addUpdateTaskPanel.Controls.Add(this.taskNameLabel);
            this.addUpdateTaskPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.addUpdateTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.addUpdateTaskPanel.Name = "addUpdateTaskPanel";
            this.addUpdateTaskPanel.Size = new System.Drawing.Size(267, 520);
            this.addUpdateTaskPanel.TabIndex = 1;
            // 
            // requirementsRichTextBox
            // 
            this.requirementsRichTextBox.BackColor = System.Drawing.Color.White;
            this.requirementsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementsRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.requirementsRichTextBox.Location = new System.Drawing.Point(0, 230);
            this.requirementsRichTextBox.Name = "requirementsRichTextBox";
            this.requirementsRichTextBox.Size = new System.Drawing.Size(267, 290);
            this.requirementsRichTextBox.TabIndex = 17;
            this.requirementsRichTextBox.Text = "";
            // 
            // requirementsLabel
            // 
            this.requirementsLabel.AutoSize = true;
            this.requirementsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requirementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requirementsLabel.ForeColor = System.Drawing.Color.White;
            this.requirementsLabel.Location = new System.Drawing.Point(0, 210);
            this.requirementsLabel.Name = "requirementsLabel";
            this.requirementsLabel.Size = new System.Drawing.Size(113, 20);
            this.requirementsLabel.TabIndex = 16;
            this.requirementsLabel.Text = "Requirements";
            // 
            // personsCheckedListBox
            // 
            this.personsCheckedListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.personsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.personsCheckedListBox.FormattingEnabled = true;
            this.personsCheckedListBox.Location = new System.Drawing.Point(0, 104);
            this.personsCheckedListBox.Name = "personsCheckedListBox";
            this.personsCheckedListBox.Size = new System.Drawing.Size(267, 106);
            this.personsCheckedListBox.TabIndex = 15;
            // 
            // personsLabel
            // 
            this.personsLabel.AutoSize = true;
            this.personsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personsLabel.ForeColor = System.Drawing.Color.White;
            this.personsLabel.Location = new System.Drawing.Point(0, 84);
            this.personsLabel.Name = "personsLabel";
            this.personsLabel.Size = new System.Drawing.Size(71, 20);
            this.personsLabel.TabIndex = 14;
            this.personsLabel.Text = "Persons";
            // 
            // deadlineDateTimePicker
            // 
            this.deadlineDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.deadlineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deadlineDateTimePicker.Location = new System.Drawing.Point(0, 62);
            this.deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            this.deadlineDateTimePicker.Size = new System.Drawing.Size(267, 22);
            this.deadlineDateTimePicker.TabIndex = 13;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deadlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineLabel.ForeColor = System.Drawing.Color.White;
            this.deadlineLabel.Location = new System.Drawing.Point(0, 42);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(75, 20);
            this.deadlineLabel.TabIndex = 2;
            this.deadlineLabel.Text = "Deadline";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.BackColor = System.Drawing.Color.White;
            this.taskNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.taskNameTextBox.Location = new System.Drawing.Point(0, 20);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(267, 22);
            this.taskNameTextBox.TabIndex = 1;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.ForeColor = System.Drawing.Color.White;
            this.taskNameLabel.Location = new System.Drawing.Point(0, 0);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(91, 20);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task name";
            // 
            // makeFriendPanel
            // 
            this.makeFriendPanel.BackColor = System.Drawing.Color.Transparent;
            this.makeFriendPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("makeFriendPanel.BackgroundImage")));
            this.makeFriendPanel.Controls.Add(this.friendButton2);
            this.makeFriendPanel.Controls.Add(this.friendButton1);
            this.makeFriendPanel.Controls.Add(this.usersListBox);
            this.makeFriendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeFriendPanel.Location = new System.Drawing.Point(0, 0);
            this.makeFriendPanel.Name = "makeFriendPanel";
            this.makeFriendPanel.Size = new System.Drawing.Size(724, 520);
            this.makeFriendPanel.TabIndex = 6;
            // 
            // friendButton2
            // 
            this.friendButton2.BackColor = System.Drawing.Color.Transparent;
            this.friendButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.friendButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.friendButton2.ForeColor = System.Drawing.Color.White;
            this.friendButton2.Location = new System.Drawing.Point(215, 402);
            this.friendButton2.Name = "friendButton2";
            this.friendButton2.Size = new System.Drawing.Size(509, 59);
            this.friendButton2.TabIndex = 11;
            this.friendButton2.Text = "Decline";
            this.friendButton2.UseVisualStyleBackColor = false;
            // 
            // friendButton1
            // 
            this.friendButton1.BackColor = System.Drawing.Color.Transparent;
            this.friendButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.friendButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.friendButton1.ForeColor = System.Drawing.Color.White;
            this.friendButton1.Location = new System.Drawing.Point(215, 461);
            this.friendButton1.Name = "friendButton1";
            this.friendButton1.Size = new System.Drawing.Size(509, 59);
            this.friendButton1.TabIndex = 10;
            this.friendButton1.Text = "Accept";
            this.friendButton1.UseVisualStyleBackColor = false;
            // 
            // usersListBox
            // 
            this.usersListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 16;
            this.usersListBox.Location = new System.Drawing.Point(0, 0);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(215, 520);
            this.usersListBox.TabIndex = 1;
            this.usersListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersListBox_MouseClick);
            // 
            // makeAdminPanel
            // 
            this.makeAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.makeAdminPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("makeAdminPanel.BackgroundImage")));
            this.makeAdminPanel.Controls.Add(this.userListBox);
            this.makeAdminPanel.Controls.Add(this.makeAdminButton);
            this.makeAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.makeAdminPanel.Name = "makeAdminPanel";
            this.makeAdminPanel.Size = new System.Drawing.Size(724, 520);
            this.makeAdminPanel.TabIndex = 8;
            // 
            // userListBox
            // 
            this.userListBox.BackColor = System.Drawing.Color.Black;
            this.userListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.userListBox.ForeColor = System.Drawing.Color.White;
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 16;
            this.userListBox.Location = new System.Drawing.Point(0, 0);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(261, 445);
            this.userListBox.TabIndex = 31;
            // 
            // makeAdminButton
            // 
            this.makeAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.makeAdminButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.makeAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeAdminButton.ForeColor = System.Drawing.Color.White;
            this.makeAdminButton.Location = new System.Drawing.Point(0, 445);
            this.makeAdminButton.Name = "makeAdminButton";
            this.makeAdminButton.Size = new System.Drawing.Size(724, 75);
            this.makeAdminButton.TabIndex = 30;
            this.makeAdminButton.Text = "Make Admin";
            this.makeAdminButton.UseVisualStyleBackColor = false;
            this.makeAdminButton.Click += new System.EventHandler(this.makeAdminButton_Click);
            // 
            // meetingPanel
            // 
            this.meetingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.meetingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("meetingPanel.BackgroundImage")));
            this.meetingPanel.Controls.Add(this.meetingsListBox);
            this.meetingPanel.Controls.Add(this.addMeetingButton);
            this.meetingPanel.Controls.Add(this.meetingDateTimePicker);
            this.meetingPanel.Controls.Add(this.timeLabel);
            this.meetingPanel.Controls.Add(this.meetingTextBox);
            this.meetingPanel.Controls.Add(this.meetingLabel);
            this.meetingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meetingPanel.Location = new System.Drawing.Point(0, 0);
            this.meetingPanel.Name = "meetingPanel";
            this.meetingPanel.Size = new System.Drawing.Size(724, 520);
            this.meetingPanel.TabIndex = 30;
            // 
            // meetingsListBox
            // 
            this.meetingsListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetingsListBox.FormattingEnabled = true;
            this.meetingsListBox.ItemHeight = 16;
            this.meetingsListBox.Location = new System.Drawing.Point(0, 78);
            this.meetingsListBox.Name = "meetingsListBox";
            this.meetingsListBox.Size = new System.Drawing.Size(724, 292);
            this.meetingsListBox.TabIndex = 30;
            // 
            // addMeetingButton
            // 
            this.addMeetingButton.BackColor = System.Drawing.Color.Transparent;
            this.addMeetingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addMeetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMeetingButton.ForeColor = System.Drawing.Color.White;
            this.addMeetingButton.Location = new System.Drawing.Point(0, 480);
            this.addMeetingButton.Name = "addMeetingButton";
            this.addMeetingButton.Size = new System.Drawing.Size(724, 40);
            this.addMeetingButton.TabIndex = 29;
            this.addMeetingButton.Text = "Meetings";
            this.addMeetingButton.UseVisualStyleBackColor = false;
            this.addMeetingButton.Click += new System.EventHandler(this.addMeetingButton_Click);
            // 
            // meetingDateTimePicker
            // 
            this.meetingDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.meetingDateTimePicker.Location = new System.Drawing.Point(0, 56);
            this.meetingDateTimePicker.Name = "meetingDateTimePicker";
            this.meetingDateTimePicker.Size = new System.Drawing.Size(724, 22);
            this.meetingDateTimePicker.TabIndex = 6;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(0, 39);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(38, 17);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Date";
            // 
            // meetingTextBox
            // 
            this.meetingTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetingTextBox.Location = new System.Drawing.Point(0, 17);
            this.meetingTextBox.Name = "meetingTextBox";
            this.meetingTextBox.Size = new System.Drawing.Size(724, 22);
            this.meetingTextBox.TabIndex = 3;
            // 
            // meetingLabel
            // 
            this.meetingLabel.AutoSize = true;
            this.meetingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetingLabel.ForeColor = System.Drawing.Color.White;
            this.meetingLabel.Location = new System.Drawing.Point(0, 0);
            this.meetingLabel.Name = "meetingLabel";
            this.meetingLabel.Size = new System.Drawing.Size(58, 17);
            this.meetingLabel.TabIndex = 1;
            this.meetingLabel.Text = "Meeting";
            // 
            // chatPanel
            // 
            this.chatPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chatPanel.BackgroundImage")));
            this.chatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chatPanel.Controls.Add(this.buttonClose);
            this.chatPanel.Controls.Add(this.sendRichTextBox);
            this.chatPanel.Controls.Add(this.chatRichTextBox);
            this.chatPanel.Location = new System.Drawing.Point(430, 210);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(288, 307);
            this.chatPanel.TabIndex = 4;
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
            this.buttonClose.Location = new System.Drawing.Point(262, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // sendRichTextBox
            // 
            this.sendRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendRichTextBox.Location = new System.Drawing.Point(0, 251);
            this.sendRichTextBox.Name = "sendRichTextBox";
            this.sendRichTextBox.Size = new System.Drawing.Size(288, 56);
            this.sendRichTextBox.TabIndex = 1;
            this.sendRichTextBox.Text = "";
            this.sendRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SendRichTextBox_KeyPress);
            // 
            // chatRichTextBox
            // 
            this.chatRichTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.chatRichTextBox.ForeColor = System.Drawing.Color.White;
            this.chatRichTextBox.Location = new System.Drawing.Point(21, 26);
            this.chatRichTextBox.Name = "chatRichTextBox";
            this.chatRichTextBox.Size = new System.Drawing.Size(238, 219);
            this.chatRichTextBox.TabIndex = 0;
            this.chatRichTextBox.Text = "";
            this.chatRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChatRichTextBox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 520);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.friendsPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form3";
            this.Text = "MainWindow";
            this.menuPanel.ResumeLayout(false);
            this.friendsMenuPanel.ResumeLayout(false);
            this.taskMenuPanel.ResumeLayout(false);
            this.friendsPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tasksPanel.ResumeLayout(false);
            this.viewTasksPanel.ResumeLayout(false);
            this.addUpdateTaskPanel.ResumeLayout(false);
            this.addUpdateTaskPanel.PerformLayout();
            this.makeFriendPanel.ResumeLayout(false);
            this.makeAdminPanel.ResumeLayout(false);
            this.meetingPanel.ResumeLayout(false);
            this.meetingPanel.PerformLayout();
            this.chatPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel friendsPanel;
        private System.Windows.Forms.Panel friendsImagePanel;
        private System.Windows.Forms.Panel friendsMenuPanel;
        private System.Windows.Forms.Button friendRequestButton;
        private System.Windows.Forms.Button deleteFriendButton;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.Button meetingsButton;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.Panel taskMenuPanel;
        private System.Windows.Forms.Button updateTaskButton;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel tasksPanel;
        private System.Windows.Forms.Panel viewTasksPanel;
        private System.Windows.Forms.RichTextBox viewTasksRichTextBox;
        private System.Windows.Forms.ListBox viewTasksListBox;
        private System.Windows.Forms.Panel addUpdateTaskPanel;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Panel makeFriendPanel;
        private System.Windows.Forms.Button friendButton2;
        private System.Windows.Forms.Button friendButton1;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.RichTextBox requirementsRichTextBox;
        private System.Windows.Forms.Label requirementsLabel;
        private System.Windows.Forms.CheckedListBox personsCheckedListBox;
        private System.Windows.Forms.Label personsLabel;
        private System.Windows.Forms.DateTimePicker deadlineDateTimePicker;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel makeAdminPanel;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button makeAdminButton;
        private System.Windows.Forms.Panel meetingPanel;
        private System.Windows.Forms.DateTimePicker meetingDateTimePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox meetingTextBox;
        private System.Windows.Forms.Label meetingLabel;
        private System.Windows.Forms.ListBox meetingsListBox;
        private System.Windows.Forms.Button addMeetingButton;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RichTextBox sendRichTextBox;
        private System.Windows.Forms.RichTextBox chatRichTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}