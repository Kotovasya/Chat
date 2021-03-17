using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Interfaces
{
    [ServiceContract(CallbackContract = typeof(IServiceCallback))]
    public partial interface IService
    {
        [OperationContract]
        Guid Connect();

        [OperationContract]
        void Disconnect(Guid id);
    }

    public partial interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnUserDiconnected(ServerEventArgs args);
    }
}
