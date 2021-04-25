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
    public class Registration
    {
        private Guid id = TestService.Instance.Connect();

        private AuthResponse RegisterNow(string login, string password)
        {
            return TestService.Instance.Registration(new AuthRequest()
            {
                Id = id,
                Login = login,
                Password = password
            });
        }

        [TestMethod]
        public void Sucessfully_Registration()
        {
            string login = "TestUser" + ++TestSettings.UserNumber;
            string password = "Test";

            AuthResponse response = RegisterNow(login, password);
            Assert.IsTrue(response.Result == Result.Succesfully);
            TestService.Instance.Disconnect(response.Id);
        }

        [TestMethod]
        public void Registration_With_Already_Exist_Name()
        {
            string login = "TestUser" + (Settings.Default.TestUserNumber - 1);
            string password = "Test";

            Assert.IsTrue(RegisterNow(login, password).Result == Result.AlreadyRegister);
        }

        [TestMethod]
        public void Registration_With_Short_Name()
        {
            string login = new string('A', 2);
            string password = "Test";

            Assert.IsTrue(RegisterNow(login, password).Result == Result.InvalidName);
        }

        [TestMethod]
        public void Registration_With_Long_Name()
        {
            string login = new string('A', 31);
            string password = "Test";

            Assert.IsTrue(RegisterNow(login, password).Result == Result.InvalidName);
        }

        [TestMethod]
        public void Registration_With_Empty_Name()
        {
            string login = string.Empty;
            string password = "Test";

            Assert.IsTrue(RegisterNow(login, password).Result == Result.InvalidName);
        }

        [TestMethod]
        public void Registration_With_Short_Password()
        {
            string login = "TestUser" + (TestSettings.UserNumber + 1);
            string password = "1";

            Assert.IsTrue(RegisterNow(login, password).Result == Result.InvalidPassword);
        }

        [TestMethod]
        public void Registration_With_Empty_Password()
        {
            string login = "TestUser" + (TestSettings.UserNumber + 1);
            string password = string.Empty;

            Assert.IsTrue(RegisterNow(login, password).Result == Result.InvalidPassword);
        }
    }
}
