using Library.Contracts;
using Library.Contracts.Dialog;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Server.Dialog_Service
{
    [TestClass]
    public class JoinToDialog
    {
        private string dialogName = "Test Dialog";

        [TestMethod]
        public void Succesfully_Join_And_Leave_From_Dialog()
        {
            ConnectToDialogResponse response = TestService.Instance.ConnectToDialog(new ConnectToDialogRequest()
            {
                Id = TestUser.Id,
                Name = dialogName,
                Password = "Test"
            });

            Assert.IsTrue(response.Result == Result.Succesfully);
            Assert.IsTrue(response.DialogInfo.Name == dialogName);
            Assert.IsTrue(response.DialogInfo.Users.ContainsKey(TestUser.Id));

            Response leaveResponse = TestService.Instance.LeaveFromDialog(new LeaveFromDialogRequest()
            {
                Id = TestUser.Id,
                DialogId = response.DialogInfo.Id,
            });
            Assert.IsTrue(leaveResponse.Result == Result.Succesfully);
        }

        [TestMethod]
        public void Wrong_Name_On_Join_To_Dialog()
        {
            ConnectToDialogResponse response = TestService.Instance.ConnectToDialog(new ConnectToDialogRequest()
            {
                Id = TestUser.Id,
                Name = "WrongName",
                Password = "WrongPassword"
            });

            Assert.IsTrue(response.Result == Result.WrongLogin);
        }

        [TestMethod]
        public void Wrong_Password_On_Join_To_Dialog()
        {
            ConnectToDialogResponse response = TestService.Instance.ConnectToDialog(new ConnectToDialogRequest()
            {
                Id = TestUser.Id,
                Name = dialogName,
                Password = "WrongPassword"
            });

            Assert.IsTrue(response.Result == Result.WrongPassword);
        }
    }
}
