using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestService.UnitTests
{
    [TestClass]
    public class WebServiceTests
    {

        [TestMethod]
        public void isUser_PersonIsUser_ReturnTrue()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.isUser("User", "userPassword");
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isUser_WrongName_ReturnFalse()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.isUser("","userPassword");
            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void isUser_WrongPassword_ReturnFalse()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.isUser("User", "");
            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void isAdmin_PersonIsAdmin_ReturnTrue()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.isUser("Admin", "adminPassword");
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isAdmin_WrongName_ReturnFalse()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.isUser("", "adminPassword");
            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void isAdmin_WrongPassword_ReturnFalse()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.isUser("Admin", "");
            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void getPassword_PersonExists_ReturnPassword()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getPassword("User", "user@yahoo.com");
            // Assert
            Assert.AreEqual("userPassword", result);
        }

        [TestMethod]
        public void getPassword_WrongName_ReturnNull()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getPassword("", "user@yahoo.com");
            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void getPassword_WrongMail_ReturnNull()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getPassword("User", "");
            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void getChatByCode_ChatExists_ReturnMessages()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getChatByCode(1);
            // Assert
            Assert.AreEqual("Test", result);
        }

        [TestMethod]
        public void getChatByCode_ChatEmpty_ReturnNull()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getChatByCode(2);
            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void getChatByCode_WrongCodeChat_ReturnNull()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getChatByCode(-1);
            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void getChatByUsers_ChatExists_ReturnMessage()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getChatByUsers("Admin","User");
            // Assert
            Assert.AreEqual("Test", result);
        }

        [TestMethod]
        public void getChatByUsers_WrongUser_ReturnNull() /////
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            var result = server.getChatByUsers("Admin", "");
            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void addUser_GoodConnection_AddAnUser()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            server.addUser("testUser", "testUser", "testUserPassword", "testUser@yahoo.com");
            var result = server.isUser("testUser", "testUserPassword");
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void updateUser_UpdateToAdmin_ChangeToAdmin()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            server.updateUser("testUser","Admin");
            var result = server.isAdmin("testUser");  
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void updateUser_UpdateToUser_ChangeToUser()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            server.updateUser("testUser", "User");
            var result1 = server.isAdmin("testUser");
            var result2 = server.isUser("testUser", "testUserPassword");
            // Assert
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void updateUser_WrongRole_NoChange()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            server.updateUser("testUser", "");
            var result1 = server.isAdmin("testUser");
            var result2 = server.isUser("testUser", "testUserPassword");

            // Assert
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void addMessage_GoodConnection_AddAMessage()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            server.addMessage(2,"Test Message");
            var result = server.getChatByCode(2);

            // Assert
            Assert.Equals(result, "Test Message");
        }

        [TestMethod]
        public void addFriend_GoodConnection_AddAFriend()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            server.addFriend("testUser", "User");
            var result = server.getChatByUsers("testUser", "User");

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void deleteFriend_GoodConnection_DeleteAFriend()
        {
            // Arrange
            ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
            // Act
            server.deleteFriend("testUser", "User");
            var result = server.getChatByUsers("testUser", "User");

            // Assert
            Assert.IsNull(result);
        }

    }
}
