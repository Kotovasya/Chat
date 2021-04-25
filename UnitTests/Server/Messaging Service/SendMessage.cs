using Library.Contracts;
using Library.Contracts.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Properties;

namespace UnitTests.Server.Messaging_Service
{
    [TestClass]
    public class SendMessage
    {
        private SendMessageResponse Send(int dialogId, string message)
        {
            return TestService.Instance.SendMessage(new SendMessageRequest()
            {
                Id = TestUser.Id,
                DialogId = dialogId,
                Text = message
            });
        }

        [TestMethod]
        public void Succesfully_Send_Message()
        {
            Assert.IsTrue(Send(1, "Test").Result == Result.Succesfully);
        }

        [TestMethod]
        public void Send_Message_While_Not_In_Chat()
        {
            Assert.IsTrue(Send(2, "Test").Result == Result.UserNotInDialog);
        }

        [TestMethod]
        public void Send_Empty_Message()
        {
            Assert.IsTrue(Send(1, null).Result == Result.EmptyMessage);
            Assert.IsTrue(Send(1, "        ").Result == Result.EmptyMessage);
            Assert.IsTrue(Send(1, "").Result == Result.EmptyMessage);
        }
    }
}
