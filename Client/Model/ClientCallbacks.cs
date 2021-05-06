using Client.ServiceReference;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    /// <summary>
    /// Класс, служащий для обработки запросов с сервера и добавления их в модель
    /// </summary>
    public class ClientCallbacks : IServiceCallback
    {
        public ClientModel Model { get; set; }

        public void OnAddedUserToDialog(AddedUserToDialogEventArgs args)
        {
            if (Model.Dialogs.ContainsKey(args.DialogId))
            {
                if (!Model.Users.ContainsKey(args.AddedUser.Id))
                    Model.Users.Add(args.Id, new User(args.Id, args.AddedUser.Name, false));

                Model.Dialogs[args.DialogId].Users.Add(args.AddedUser.Id, Model.Users[args.AddedUser.Id]);
            }     
        }

        public void OnChangedDialog(ChangeDialogEventArgs args)
        {
            if (Model.Dialogs.ContainsKey(args.ChangedInfo.DialogId))
            {
                if (args.ChangedInfo.NewName != null)
                    Model.Dialogs[args.ChangedInfo.DialogId].Name = args.ChangedInfo.NewName;
            }
        }

        public void OnCreatedDialog(CreateDialogEventArgs args)
        {
            Model.Dialogs.Add(args.NewDialog.Id, new Dialog(args.NewDialog));
        }

        public void OnDialogRemoved(DialogRemovedEventArgs args)
        {
            Model.Dialogs.Remove(args.DialogId);
        }

        public void OnMessageEdited(MessageEditedEventArgs args)
        {
            var dialog = Model.Dialogs.FirstOrDefault(d => d.Key == args.DialogId).Value;
            if (dialog != null)
            {
                var message = dialog.Messages.FirstOrDefault(m => m.Key == args.MessageId).Value;
                if (message != null)
                    message.Text = args.NewText;
            }
        }

        public void OnMessageRemoved(MessageRemovedEventArgs args)
        {
            var dialog = Model.Dialogs.FirstOrDefault(d => d.Key == args.DialogId).Value;
            if (dialog != null)
            {
                foreach (var id in args.MessagesIds)
                    dialog.Messages.Remove(id);
            }
        }

        public void OnMessageSend(MessageSendEventArgs args)
        {
            Message message = new Message(args.Message);
            if (!Model.Users.ContainsKey(args.Id))
                Model.Users.Add(args.Id, new User(args.Id, args.Message.Author.Name, false));

            message.Author = Model.Users[args.Id];
            Model.Dialogs[message.DialogId].Messages.Add(message.Id, message);
        }

        public void OnUserConnected(UserConnectedEventArgs args)
        {
            if (Model.Users.ContainsKey(args.Id))
                Model.Users[args.Id].Online = true;
            else
                Model.Users.Add(args.Id, new User(args.User));
        }

        public void OnUserDiconnected(ServerEventArgs args)
        {
            Model.Users?.Remove(args.Id);
        }

        public void OnUserLeavedFromDialog(UserLeaveFromDialogEventArgs args)
        {
            var dialog = Model.Dialogs.FirstOrDefault(d => d.Key == args.DialogId).Value;
            if (dialog != null)
                dialog.Users.Remove(args.Id);
        }

        public void OnUsernameChanged(UsernameChangedEventArgs args)
        {
            if (Model.Users.ContainsKey(args.Id))
                Model.Users[args.Id].Name = args.NewName;
        }
    }
}
