using Client.Binding;
using Client.Entities;
using Client.Model;
using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Controls
{
    public partial class DialogsControl : UserControl
    {
        private readonly SourceList<int, DialogPreview> dialogPreviews;
        private readonly ClientModel model;

        public EventHandler<Dialog> DialogOpen;

        public DialogsControl(ClientModel model)
        {
            InitializeComponent();
            this.model = model;
            this.dialogPreviews = new SourceList<int, DialogPreview>();
            dialogPreviews.Collection = dialogsContainer.Controls;
            model.Dialogs.ElementAdding += OnDialogAdded;
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            var text = searchTextbox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                dialogPreviews.Collection = dialogsContainer.Controls;
                return;
            }
            dialogPreviews.Collection = null;
            var result = dialogPreviews.Values
                .Where(d => d.Owner.Name.Contains(text))
                .OrderBy(d => d.LastMessage?.Date)
                .Select(d => d.Control);
            foreach (var control in result)
                dialogsContainer.Controls.Add(control);
        }

        private void OnDialogAdded(object sender, Dialog dialog)
        {
            dialogPreviews.Add(dialog.Id, dialog.Preview);
            var control = dialog.Preview.Control;
            var lastControl = dialogPreviews.Last()?.Control;
            if (lastControl != null)
                control.Location = new Point(control.Location.X, lastControl.Location.Y + lastControl.Height + 2);        
            control.Click += dialogPreview_Click;

        }

        private void dialogPreview_Click(object sender, EventArgs e)
        {
            var preview = (DialogPreviewControl)sender;
            DialogOpen?.Invoke(sender, model.Dialogs[preview.DialogId]);
        }

        private void connectToDialogButton_Click(object sender, EventArgs e)
        {
            ConnectToDialogWindow window = new ConnectToDialogWindow(model);
            window.ConnectedToDialog += (object obj, Dialog dialog) => 
            { 
                DialogOpen?.Invoke(obj, dialog); 
            };
            window.Show();
        }
    }
}
