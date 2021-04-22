using Library.Contracts;
using Library.Contracts.Dialog;
using Library.Contracts.DTO;
using Library.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public partial class Service
    {
        public CreateDialogResponse CreateDialog(CreateDialogRequest request)
        {
            return Preform(() =>
            {
                if (context.Dialogs.Any(d => d.Name == request.Name))
                    return new CreateDialogResponse() { Result = Result.DialogNameAlreadyTaken };
                
                Dialog dialog = context.Dialogs.Add(new Dialog(context.Dialogs.Count(), request.Id, request.Name, request.Password));
                dialog.Users.Add(context.Users.Find(request.Id));
                context.SaveChanges();
                DialogDto dialogDto = dialog.ToDto();
                SendBroadcastEvent(new CreateDialogEventArgs(request.Id, dialogDto));
                return new CreateDialogResponse() { Result = Result.Succesfully, Dialog = dialogDto };                    
            });
        }

        public ConnectToDialogResponse ConnectToDialog(ConnectToDialogRequest request)
        {
            return Preform(() =>
            {
                User user = context.Users.Find(request.Id);
                Dialog dialog = context.Dialogs.SingleOrDefault(d => d.Name == request.Name);
                if (dialog == null)
                    return new ConnectToDialogResponse() { Result = Result.WrongLogin };

                if (dialog.Password != request.Password)
                    return new ConnectToDialogResponse() { Result = Result.WrongPassword };

                if (dialog.Users.Contains(user))
                    return new ConnectToDialogResponse() { Result = Result.UserAlreadyInDialog };

                dialog.Users.Add(user);
                context.Entry(dialog).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                SendEvent(dialog.Users.Select(u => u.Id), new AddedUserToDialogEventArgs(request.Id, dialog.Id, user.ToDto()));
                return new ConnectToDialogResponse() { Result = Result.Succesfully, DialogInfo = dialog.ToDto().AddInfo(dialog) };
            });
        }

        public Response AddUserToDialog(AddUserToDialogRequest request)
        {
            return Preform(() =>
            {
                User owner = context.Users.Find(request.Id);
                Dialog dialog = context.Dialogs.Find(request.DialogId);
                if (dialog.OwnerId != owner.Id)
                    return new Response() { Result = Result.NotPremissions };
                User addedUser = context.Users.Find(request.AddedId);

                dialog.Users.Add(addedUser);
                context.Entry(dialog).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                SendEvent(dialog.Users.Select(u => u.Id), new AddedUserToDialogEventArgs(request.Id, dialog.Id, addedUser.ToDto()));
                return new Response() { Result = Result.Succesfully };
            });
        }

        public Response ChangeDialog(ChangeDialogRequest request)
        {
            return Preform(() =>
            {
                User user = context.Users.Find(request.Id);
                Dialog dialog = context.Dialogs.Find(request.DialogId);
                if (user.Id != dialog.OwnerId)
                    return new Response() { Result = Result.NotPremissions };

                if (request.NewName != null)
                    dialog.Name = request.NewName;
                if (request.NewPassword != null)
                    dialog.Password = request.NewPassword;
                context.Entry(dialog).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                SendBroadcastEvent(new ChangeDialogEventArgs(request.Id, request));
                return new Response() { Result = Result.Succesfully };
            });
        }
    }
}
