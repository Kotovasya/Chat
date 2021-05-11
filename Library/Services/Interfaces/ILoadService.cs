using Library.Contracts;
using Library.Contracts.Load;
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
        LoadMessagesResponse LoadMessages(LoadMessagesRequest request);

        [OperationContract]
        LoadDialogsResponse LoadDialogs(LoadDialogsRequest request);

        [OperationContract]
        LoadOnlineUsersResponse LoadOnlineUsers(Guid id);
    }
}
