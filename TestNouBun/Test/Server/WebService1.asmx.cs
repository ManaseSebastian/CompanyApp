using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Server
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private SqlConnection databaseConnection;
        private DataSet usersDataSet;
        private DataSet tasksDataSet;
        private DataSet chatDataSet;
        private DataSet friendsDataSet;
        private SqlDataAdapter usersDataAdapter;
        private SqlDataAdapter tasksDataAdapter;
        private SqlDataAdapter chatDataAdapter;
        private SqlDataAdapter friendsDataAdapter;
        private SqlCommandBuilder usersCommandBuilder;
        private SqlCommandBuilder tasksCommandBuilder;
        private SqlCommandBuilder chatCommandBuilder;
        private SqlCommandBuilder friendsCommandBuilder;

        public WebService1()
        {
            this.databaseConnection = new SqlConnection();
            this.databaseConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Facultate\\TestNouBun\\Test\\Server\\App_Data\\Database1.mdf;Integrated Security=True";
            this.databaseConnection.Open();
            this.usersDataAdapter = new SqlDataAdapter("SELECT * FROM Users", this.databaseConnection);
            this.tasksDataAdapter = new SqlDataAdapter("SELECT * FROM Tasks", this.databaseConnection);
            this.chatDataAdapter = new SqlDataAdapter("SELECT * FROM Chat", this.databaseConnection);
            this.friendsDataAdapter = new SqlDataAdapter("SELECT * FROM Friends", this.databaseConnection);
            this.usersDataSet = new DataSet();
            this.tasksDataSet = new DataSet();
            this.chatDataSet = new DataSet();
            this.friendsDataSet = new DataSet();
            this.usersDataAdapter.Fill(this.usersDataSet, "Users");
            this.tasksDataAdapter.Fill(this.tasksDataSet, "Tasks");
            this.chatDataAdapter.Fill(this.chatDataSet, "Chat");
            this.friendsDataAdapter.Fill(this.friendsDataSet, "Friends");
            this.databaseConnection.Close();
            this.usersCommandBuilder = new SqlCommandBuilder(this.usersDataAdapter);
            this.tasksCommandBuilder = new SqlCommandBuilder(this.tasksDataAdapter);
            this.chatCommandBuilder = new SqlCommandBuilder(this.chatDataAdapter);
            this.friendsCommandBuilder = new SqlCommandBuilder(this.friendsDataAdapter);
        }

        [WebMethod]
        public DataSet getUsers()
        {
            return this.usersDataSet;
        }

        [WebMethod]
        public void addUser(string userId, string userName, string userPassword, string userMail)
        {
            try
            {
                this.databaseConnection.Open();
                DataRow newUser = this.usersDataSet.Tables["Users"].NewRow();
                newUser["Id_User"] = userId;
                newUser["Name"] = userName;
                newUser["Password"] = userPassword;
                newUser["Mail"] = userMail;
                newUser["Role"] = "User";
                newUser["Friend_Requests"] = null;
                this.usersDataSet.Tables["Users"].Rows.Add(newUser);
                this.usersDataAdapter.Update(this.usersDataSet, "Users");
                this.databaseConnection.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public void updateUser(string userId, string userRole)
        {
            try
            {
                if (userRole == "Admin" || userRole == "User")
                {
                    this.databaseConnection.Open();
                    foreach (DataRow indexUsers in this.usersDataSet.Tables["Users"].Rows)
                    {
                        if (indexUsers["Id_User"].ToString() == userId)
                        {
                            indexUsers["Role"] = userRole;
                            break;
                        }
                    }
                    this.usersDataAdapter.Update(this.usersDataSet, "Users");
                    this.databaseConnection.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        [WebMethod]
        public bool isUser(string userId, string userPassword)
        {
            foreach (DataRow indexUsers in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUsers["Id_User"].ToString() == userId && indexUsers["Password"].ToString() == userPassword)
                {
                    return true;
                }
            }
            return false;
        }

        [WebMethod]
        public bool isAdmin(string userId)
        {
            foreach (DataRow indexUsers in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUsers["Id_User"].ToString() == userId && indexUsers["Role"].ToString() == "Admin")
                {
                    return true;
                }
            }
            return false;
        }

        [WebMethod]
        public string getUserByName(string userName)
        {
            foreach (DataRow indexUsers in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUsers["Name"].ToString() == userName)
                {
                    return indexUsers["Id_User"].ToString();
                }
            }
            return null;
        }

        [WebMethod]
        public string getPassword(string userId, string userMail)
        {
            foreach (DataRow indexUser in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUser["Id_User"].ToString() == userId && indexUser["Mail"].ToString() == userMail)
                {
                    return indexUser["Password"].ToString();
                }
            }
            return null;
        }

        [WebMethod]
        public List<string> getUsersExceptFriends(string userId)
        {
            List<string> users = new List<string>();
            foreach (DataRow indexUsers in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUsers["Id_User"].ToString() != userId)
                {
                    bool isFriend = false;
                    foreach (DataRow indexFriends in this.friendsDataSet.Tables["Friends"].Rows)
                    {
                        if (indexFriends["Id_User1"].ToString() == userId && indexFriends["Id_User2"].ToString() == indexUsers["Id_User"].ToString())
                        {
                            isFriend = true;
                            break;
                        }
                    }
                    if (!isFriend)
                    {
                        users.Add(indexUsers["Name"].ToString());
                    }
                }
            }
            return users;
        }

        [WebMethod]
        public string getUserNameById(string userId)
        {
            foreach (DataRow indexUser in this.usersDataSet.Tables["Users"].Rows)
            {

                if (indexUser["Id_User"].ToString() == userId)
                {
                    return indexUser["Name"].ToString();
                }
            }
            return null;
        }

        [WebMethod]
        public void friendRequest(string userId1, string userId2)
        {
            this.databaseConnection.Open();
            foreach (DataRow indexUser in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUser["Id_User"].ToString() == userId2)
                {
                    string[] users = indexUser["Friend_Requests"].ToString().Split(',');
                    bool isRequest = false;
                    foreach (string index in users)
                    {
                        if (index == userId1)
                        {
                            isRequest = true;
                            break;
                        }
                    }
                    if (!isRequest)
                    {
                        indexUser["Friend_Requests"] += userId1 + ",";
                    }
                    break;
                }
            }
            this.usersDataAdapter.Update(this.usersDataSet, "Users");
            this.databaseConnection.Close();
        }

        [WebMethod]
        public void declineFriendRequest(string userId1, string userId2)
        {
            this.databaseConnection.Open();
            foreach (DataRow indexUser in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUser["Id_User"].ToString() == userId1)
                {
                    string[] users = indexUser["Friend_Requests"].ToString().Split(',');
                    string requests = "";
                    foreach (string index in users)
                    {
                        if (index != userId2 && index != "")
                        {
                            requests += index + ",";
                        }
                    }
                    indexUser["Friend_Requests"] = requests;
                    break;
                }
            }
            this.usersDataAdapter.Update(this.usersDataSet, "Users");
            this.databaseConnection.Close();
        }

        [WebMethod]
        public void acceptFriendRequest(string userId1, string userId2)
        {
            this.addFriend(userId1, userId2);
            this.addFriend(userId2, userId1);
            this.declineFriendRequest(userId1, userId2);
        }

        [WebMethod]
        public List<string> getFriendRequests(string userId)
        {
            List<string> requests = new List<string>();
            foreach (DataRow indexUser in this.usersDataSet.Tables["Users"].Rows)
            {
                if (indexUser["Id_User"].ToString() == userId)
                {
                    string[] req = indexUser["Friend_Requests"].ToString().Split(',');
                    foreach (string index in req)
                    {
                        if (index != "")
                        {
                            requests.Add(index);
                        }
                    }
                }
            }
            return requests;
        }

        [WebMethod]
        public DataSet getTasks()
        {
            return this.tasksDataSet; 
        }

        [WebMethod]
        public List<string> getTasksByUser(string userId)
        {
            List<string> tasksByUser = new List<string>();
            foreach (DataRow indexTasks in this.tasksDataSet.Tables["Tasks"].Rows)
            {
                string[] persons = indexTasks["Persons"].ToString().Split(',');
                foreach (string indexPersons in persons)
                {
                    if (indexPersons == userId)
                    {
                        tasksByUser.Add(indexTasks["Name_Task"].ToString());
                    }
                }

            }
            return tasksByUser;
        }

        [WebMethod]
        public List<string> getUsersByTaskName(string taskName)
        {
            List<string> usersByTaskName = new List<string>();
            foreach (DataRow indexTasks in this.tasksDataSet.Tables["Tasks"].Rows)
            {
                if (indexTasks["Name_Task"].ToString() == taskName)
                {
                    string[] persons = indexTasks["Persons"].ToString().Split(',');
                    foreach (string indexPersons in persons)
                    {
                        foreach (DataRow indexUser in this.usersDataSet.Tables["Users"].Rows)
                        {
                            if (indexUser["Id_User"].ToString() == indexPersons)
                            {
                                usersByTaskName.Add(indexUser["Name"].ToString());
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return usersByTaskName;
        }

        [WebMethod] 
        public void addTask(string userId, string taskRequirements, DateTime taskDeadline, string taskPersons, string taskName)
        {
            try
            {
                this.databaseConnection.Open();
                DataRow newTask = this.tasksDataSet.Tables["Tasks"].NewRow();
                newTask["Code_Task"] = this.tasksDataSet.Tables["Tasks"].Rows.Count + 1;
                newTask["Id_User"] = userId;
                newTask["Requirements"] = taskRequirements;
                newTask["Deadline"] = taskDeadline;
                newTask["Persons"] = taskPersons;
                newTask["Name_Task"] = taskName;
                this.tasksDataSet.Tables["Tasks"].Rows.Add(newTask);
                this.tasksDataAdapter.Update(this.tasksDataSet, "Tasks");
                this.databaseConnection.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex);
            }
        }

        [WebMethod]
        public void updateTask(int idTask, string persons, string taskRequirements, DateTime taskDeadline, string taskName)
        {
            try
            {
                this.databaseConnection.Open();
                foreach (DataRow indexTask in this.tasksDataSet.Tables["Tasks"].Rows)
                {
                    if (Convert.ToInt32(indexTask["Code_Task"]) == idTask)
                    {
                        indexTask["Persons"] = persons;
                        indexTask["Requirements"] = taskRequirements;
                        indexTask["Deadline"] = taskDeadline;
                        indexTask["Name_Task"] = taskName;
                        break;
                    }
                }
                this.tasksDataAdapter.Update(this.tasksDataSet, "Tasks");
                this.databaseConnection.Close();
            }
            catch (FormatException ex) {
                Console.WriteLine("Error: " + ex);
            }
        }

        [WebMethod]
        public void deleteTask(string taskName)
        {
            this.databaseConnection.Open();
            foreach (DataRow indexTask in this.tasksDataSet.Tables["Tasks"].Rows)
            {
                if (indexTask["Name_Task"].ToString() == taskName)
                {
                    indexTask.Delete();
                    break;
                }
            }
            this.tasksDataAdapter.Update(this.tasksDataSet, "Tasks");

            int counter = 1;
            foreach (DataRow indexTask in this.tasksDataSet.Tables["Tasks"].Rows)
            {
                if (int.Parse(indexTask["Code_Task"].ToString()) != counter)
                {
                    indexTask["Code_Task"] = counter;
                }
                counter++;
            }
            this.tasksDataAdapter.Update(this.tasksDataSet, "Tasks");
            this.databaseConnection.Close();
        }

        [WebMethod]
        public int getCodeTaskByName(string name)
        {
            DataSet tasks = this.getTasks();
            foreach (DataRow indexTask in tasks.Tables["Tasks"].Rows)
            {
                if (indexTask["Name_Task"].ToString() == name)
                {
                    return Convert.ToInt32(indexTask["Code_Task"]);
                }
            }
            return -1;
        }

        [WebMethod]
        public string getChatByCode(int chatCode)
        {
            foreach (DataRow indexChat in this.chatDataSet.Tables["Chat"].Rows)
            {
                if (int.Parse(indexChat["Code_Chat"].ToString()) == chatCode)
                {
                    return indexChat["Messages"].ToString();
                }
            }
            return null;
        }

        [WebMethod]
        public string getChatByUsers(string userId1, string userId2)
        {
            foreach (DataRow indexFriends in this.friendsDataSet.Tables["Friends"].Rows)
            {
                if (indexFriends["Id_User1"].ToString() == userId1 && indexFriends["Id_User2"].ToString() == userId2)
                {
                    return this.getChatByCode(int.Parse(indexFriends["Code_Chat"].ToString()));
                }
            }
            return null;
        }

        [WebMethod]
        public int getChatCodeByUsers(string userId1, string userId2)
        {
            foreach (DataRow indexFriends in this.friendsDataSet.Tables["Friends"].Rows)
            {
                if (indexFriends["Id_User1"].ToString() == userId1 && indexFriends["Id_User2"].ToString() == userId2)
                {
                    return int.Parse(indexFriends["Code_Chat"].ToString());
                }
            }
            return -1;
        }

        [WebMethod]
        public void addMessage(int chatCode, string message)
        {
            this.databaseConnection.Open();
            foreach (DataRow indexChat in this.chatDataSet.Tables["Chat"].Rows)
            {
                if (int.Parse(indexChat["Code_Chat"].ToString()) == chatCode)
                {
                    indexChat["Messages"] = indexChat["Messages"].ToString() + message + "\n";
                }
            }
            this.chatDataAdapter.Update(this.chatDataSet, "Chat");
            this.databaseConnection.Close();
        }

        [WebMethod]
        public void addFriend(string userId1, string userId2)
        {
            try
            {
                this.databaseConnection.Open();
                DataRow newFriend = this.friendsDataSet.Tables["Friends"].NewRow();
                newFriend["Id_User1"] = userId1;
                newFriend["Id_User2"] = userId2;
                newFriend["Code_Friends"] = this.friendsDataSet.Tables["Friends"].Rows.Count + 1;
                bool isChat = false;
                DataRow existingChat = null;
                foreach(DataRow indexFriends in this.friendsDataSet.Tables["Friends"].Rows)
                {
                    if (indexFriends["Id_User1"].ToString() == userId2 && indexFriends["Id_User2"].ToString() == userId1)
                    {
                        existingChat = indexFriends;
                        isChat = true;
                        break;
                    }
                }
                if (!isChat)
                {
                    newFriend["Code_Chat"] = this.chatDataSet.Tables["Chat"].Rows.Count + 1;
                    DataRow newChat = this.chatDataSet.Tables["Chat"].NewRow();
                    newChat["Code_Chat"] = this.chatDataSet.Tables["Chat"].Rows.Count + 1;
                    newChat["Messages"] = null;
                    this.chatDataSet.Tables["Chat"].Rows.Add(newChat);
                    this.chatDataAdapter.Update(this.chatDataSet, "Chat");
                } else
                {
                    newFriend["Code_Chat"] = existingChat["Code_Chat"];
                }
                this.friendsDataSet.Tables["Friends"].Rows.Add(newFriend);
                this.friendsDataAdapter.Update(this.friendsDataSet, "Friends");
                this.databaseConnection.Close();
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        [WebMethod]
        public void deleteFriend(string userId1, string userId2)
        {
            try
            {
                this.databaseConnection.Open();
                int chatCode = -1;
                foreach (DataRow friendIndex in this.friendsDataSet.Tables["Friends"].Rows)
                {
                    if (friendIndex["Id_User1"].ToString() == userId1 && friendIndex["Id_User2"].ToString() == userId2)
                    {
                        chatCode = int.Parse(friendIndex["Code_Chat"].ToString());
                        friendIndex.Delete();
                        break;
                    }
                }
                this.friendsDataAdapter.Update(this.friendsDataSet, "Friends");
                foreach (DataRow friendIndex in this.friendsDataSet.Tables["Friends"].Rows)
                {
                    if (friendIndex["Id_User1"].ToString() == userId2 && friendIndex["Id_User2"].ToString() == userId1)
                    {
                        friendIndex.Delete();
                        break;
                    }
                }
                this.friendsDataAdapter.Update(this.friendsDataSet, "Friends");
                foreach (DataRow chatIndex in this.chatDataSet.Tables["Chat"].Rows)
                {
                    if (chatCode == int.Parse(chatIndex["Code_Chat"].ToString()))
                    {
                        chatIndex.Delete();
                        break;
                    }
                }
                int counter = 1;
                foreach (DataRow indexFriends in this.friendsDataSet.Tables["Friends"].Rows)
                {
                    if (int.Parse(indexFriends["Code_Friends"].ToString()) != counter)
                    {
                        indexFriends["Code_Friends"] = counter;
                    }
                    counter++;
                }
                this.friendsDataAdapter.Update(this.friendsDataSet, "Friends");
                this.chatDataAdapter.Update(this.chatDataSet, "Chat");
                this.databaseConnection.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        [WebMethod]
        public List<string> getFriendsOfUser(string userId)
        {
            List<string> friends = new List<string>();
            foreach (DataRow indexFriends in this.friendsDataSet.Tables["Friends"].Rows)
            {
                if (indexFriends["Id_User1"].ToString() == userId)
                {
                    friends.Add(indexFriends["Id_User2"].ToString());
                }
            }
            return friends;
        }

        [WebMethod]
        public void makeAdmin(string idUser)
        {
            try
            {
                this.databaseConnection.Open();
                foreach (DataRow indexUsers in this.usersDataSet.Tables["Users"].Rows)
                {
                    if (indexUsers["Id_User"].ToString() == idUser)
                    {
                        indexUsers["Role"] = "Admin";
                        break;
                    }
                }
                this.usersDataAdapter.Update(this.usersDataSet, "Users");
                this.databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
