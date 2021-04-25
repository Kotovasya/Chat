using Library.Contracts;
using Library.Contracts.Dialog;
using Library.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Properties;

namespace UnitTests.Server.Dialog_Service
{
    [TestClass]
    public class CreateDialog
    {
        private string testName = "Test Dialog";

        [TestMethod]
        public void Succesfully_Create_Dialog()
        {
            string testName = "Test Dialog" + ++TestSettings.DialogNumber;
            CreateDialogResponse response = TestService.Instance.CreateDialog(new CreateDialogRequest() 
            { 
                Id = TestUser.Id, 
                Name = testName,
                Password = "Test" }
            );

            Assert.IsTrue(response.Result == Result.Succesfully);
            Assert.IsTrue(response.Dialog.Name == testName);
            Assert.IsTrue(response.Dialog.OwnerId == TestUser.Id);
        }

        [TestMethod]
        public void Create_Dialog_With_Existing_Name()
        {
            CreateDialogResponse response = TestService.Instance.CreateDialog(new CreateDialogRequest()
            {
                Id = TestUser.Id,
                Name = testName,
                Password = "Test"
            });
            Assert.IsTrue(response.Result == Result.DialogNameAlreadyTaken);
        }
    }
}
