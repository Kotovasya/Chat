using Library.Contracts;
using Library.Contracts.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Properties;

namespace UnitTests.Server.User_Service
{
    [TestClass]
    public class Authorization
    {
        private Guid id = TestService.Instance.Connect();
        private string login = "TestUser" + Settings.Default.TestUserNumber;
        private string password = "Test";
        private string wrongLogin = "WrongLogin";
        private string wrongPassword = "WrongPassword";

        private AuthResponse Auth(string login, string password)
        {
            return TestService.Instance.Authorization(new AuthRequest()
            {
                Id = id,
                Login = login,
                Password = password
            });
        }

        [TestMethod]
        public void Succesfully_Login()
        {
            AuthResponse response = Auth(login, password);
            Assert.IsTrue(response.Result == Result.Succesfully);
            TestService.Instance.Disconnect(response.Id);
        }

        [TestMethod]
        public void Wrong_Login()
        {
            Assert.IsTrue(Auth(wrongLogin, wrongPassword).Result == Result.WrongLogin);
            TestService.Instance.Disconnect(id);
        }

        [TestMethod]
        public void Wrong_Password()
        {
            Assert.IsTrue(Auth(login, wrongPassword).Result == Result.WrongPassword);
            TestService.Instance.Disconnect(id);
        }
    }
}
