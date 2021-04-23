using Library.Contracts;
using Library.Contracts.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Server.User_Service
{
    [TestClass]
    public class AuthorizationUser
    {
        private Guid id = TestService.Instance.Connect();
        private string login = "TestUser" + TestSettings.UserNumber;
        private string password = "Test";
        private string wrongLogin = "WrongLogin";
        private string wrongPassword = "WrongPassword";

        [TestMethod]
        public void Sucessfully_Registration()
        {
            string login = "TestUser" + ++TestSettings.UserNumber;
            AuthResponse response = TestService.Instance.Registration(new AuthRequest()
            {
                Id = id,
                Login = login,
                Password = password
            });
            Assert.IsTrue(response.Result == Result.Succesfully);
            TestService.Instance.Disconnect(response.Id);
        }

        [TestMethod]
        public void Wrong_Login()
        {
            AuthResponse response = TestService.Instance.Authorization(new AuthRequest()
            {
                Id = id,
                Login = wrongLogin,
                Password = wrongPassword
            });
            Assert.IsTrue(response.Result == Result.WrongLogin);
            TestService.Instance.Disconnect(id);
        }

        [TestMethod]
        public void Wrong_Password()
        {
            AuthResponse response = TestService.Instance.Authorization(new AuthRequest()
            {
                Id = id,
                Login = login,
                Password = wrongPassword
            });
            Assert.IsTrue(response.Result == Result.WrongPassword);
            TestService.Instance.Disconnect(id);
        }

        [TestMethod]
        public void Succesfully_Login()
        {
            AuthResponse response = TestService.Instance.Authorization(new AuthRequest()
            {
                Id = id,
                Login = login,
                Password = password
            });
            Assert.IsTrue(response.Result == Result.Succesfully);
            TestService.Instance.Disconnect(response.Id);
        }
    }
}
