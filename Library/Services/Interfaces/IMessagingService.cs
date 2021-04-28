using Library.Contracts;
using Library.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Interfaces
{
    public partial interface IService
    {
        [OperationContract]
        SendMessageResponse SendMessage(SendMessageRequest request);

        [OperationContract]
        Response EditMessage(EditMessageRequest request);

        [OperationContract]
        Response RemoveMessage(RemoveMessageRequest request);
    }

    public partial interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnMessageSend(MessageSendEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnMessageEdited(MessageEditedEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnMessageRemoved(MessageRemovedEventArgs args);
    }
}
