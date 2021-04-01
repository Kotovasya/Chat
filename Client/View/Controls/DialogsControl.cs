using Client.Binding;
using Client.Entities;
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
        private readonly SourceList<int, Dialog> dialogs;

        public DialogsControl(SourceList<int, Dialog> dialogs)
        {
            InitializeComponent();
            this.dialogs = dialogs;
            dialogs.ControlAdding += OnDialogAdded;
            dialogs.Collection = dialogsContainer.Controls;
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            var text = searchTextbox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                dialogs.Collection = dialogsContainer.Controls;
                return;
            }
            dialogs.Collection = null;
            var result = dialogs.Values
                .Where(d => d.Name.Contains(text))
                .OrderBy(d => d.Preview.LastMessage.Date)
                .Select(d => d.Control);
            foreach (var control in result)
                dialogsContainer.Controls.Add(control);
        }

        private void OnDialogAdded(object sender, Dialog dialog)
        {
            dialog.Control.Click += dialogPreview_Click;
        }

        private void dialogPreview_Click(object sender, EventArgs e)
        {
            
        }
    }
}
