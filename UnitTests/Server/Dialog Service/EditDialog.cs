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
    public class EditDialog
    {
        private Response Edit(int dialogId, string newName, string newPassword)
        {
            return TestService.Instance.ChangeDialog(new ChangeDialogRequest()
            {
                Id = TestUser.Id,
                DialogId = dialogId,
                NewName = newName,
                NewPassword = newPassword
            });
        }

        [TestMethod]
        public void Succesfully_Edit_Name()
        {
            Assert.IsTrue(Edit(0, "Test Dialog0", null).Result == Result.Succesfully);
            Assert.IsTrue(Edit(0, "Test Dialog", null).Result == Result.Succesfully);
        }

        [TestMethod]
        public void Succesfully_Edit_Password()
        {
            Assert.IsTrue(Edit(0, null, "NewPassword").Result == Result.Succesfully);
            Assert.IsTrue(Edit(0, null, "Test").Result == Result.Succesfully);
        }

        [TestMethod]
        public void Succesfully_Edit_Name_And_Password()
        {
            Assert.IsTrue(Edit(0, "Test Dialog0", "NewPassword").Result == Result.Succesfully);
            Assert.IsTrue(Edit(0, "Test Dialog", "Test").Result == Result.Succesfully);
        }

        [TestMethod]
        public void Dialog_Name_Already_Taken()
        {
            Assert.IsTrue(Edit(0, "Test Dialog1", null).Result == Result.DialogNameAlreadyTaken);
        }
    }
}
