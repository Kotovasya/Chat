using Library.Events.Auth;
using Library.Requests.Auth;
using Library.Responses.Auth;
using System;
using System.ServiceModel;

namespace Library.Services.Interfaces
{
    [ServiceContract(CallbackContract = typeof(IAuthCallback))]
    public interface IAuthService
    {
        [OperationContract]
        RegistrationResponse Registration(RegistrationRequest request);

        [OperationContract]
        AuthResponse Authorization(AuthRequest request);

        [OperationContract]
        Guid Connect();
    }

    public interface IAuthCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnUserConnected(UserConnectedEventArgs args);
    }
}
