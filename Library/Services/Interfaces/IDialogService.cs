using Library.Contracts;
using Library.Contracts.Dialog;
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
        CreateDialogResponse CreateDialog(CreateDialogRequest request);

        [OperationContract]
        Response RemoveDialog(RemoveDialogRequest request);

        [OperationContract]
        Response ChangeDialog(ChangeDialogRequest request);

        [OperationContract]
        ConnectToDialogResponse ConnectToDialog(ConnectToDialogRequest request);

        [OperationContract]
        Response LeaveFromDialog(LeaveFromDialogRequest request);
    }

    public partial interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnCreatedDialog(CreateDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnAddedUserToDialog(AddedUserToDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnChangedDialog(ChangeDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnUserLeavedFromDialog(UserLeaveFromDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnDialogRemoved(DialogRemovedEventArgs args);
    }
}
