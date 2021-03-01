using Library.Contracts.Auth;
using System;
using System.ServiceModel;

namespace Library.Services.Interfaces
{
    public partial interface IService
    {
        [OperationContract]
        RegistrationResponse Registration(RegistrationRequest request);

        [OperationContract]
        AuthResponse Authorization(AuthRequest request);
    }

    public partial interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnUserConnected(UserConnectedEventArgs args);
    }
}
