using Library.Contracts;
using Library.Contracts.User;
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
        Response ChangePassword(ChangePasswordRequest request);

        [OperationContract]
        Response ChangeUsername(ChangeUsernameRequest request);
    }

    public partial interface IServiceCallback
    {
        [OperationContract]
        void OnUsernameChanged(UsernameChangedEventArgs args);
    }
}
