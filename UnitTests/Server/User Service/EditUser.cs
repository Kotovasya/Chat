using Library.Contracts;
using Library.Contracts.User;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Server.User_Service
{
    [TestClass]
    public class EditUser
    {
        private Response ChangeUsername(string name)
        {
            return TestService.Instance.ChangeUsername(new ChangeUsernameRequest()
            {
                Id = TestUser.Id,
                NewName = name
            });
        }

        private Response ChangePassword(string oldPassword, string newPassword)
        {
            return TestService.Instance.ChangePassword(new ChangePasswordRequest()
            {
                Id = TestUser.Id,
                OldPassword = oldPassword,
                NewPassword = newPassword
            });
        }

        [TestMethod]
        public void Succesfully_Change_Username()
        {           
            Assert.IsTrue(ChangeUsername("TestUser0").Result == Result.Succesfully);
            Assert.IsTrue(ChangeUsername("UserTest0").Result == Result.Succesfully);
        }

        [TestMethod]
        public void Succesfully_Change_Password()
        {
            string oldPassword = "Test";
            string newPassword = "NewPassword";
            Assert.IsTrue(ChangePassword(oldPassword, newPassword).Result == Result.Succesfully);
            Assert.IsTrue(ChangePassword(newPassword, oldPassword).Result == Result.Succesfully);
        }

        [TestMethod]
        public void Changeed_Username_Already_Exist()
        {
            Assert.IsTrue(ChangeUsername("TestUser5").Result == Result.AlreadyRegister);
        }
    }
}
