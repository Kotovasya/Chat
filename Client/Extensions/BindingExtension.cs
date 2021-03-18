using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Extensions
{
    public static class BindingExtension
    {
        public static void CreateBinding(this Control control, string propertyName, object dataSource, string dataMember, ConvertEventHandler converter = null)
        {
            System.Windows.Forms.Binding binding = new System.Windows.Forms.Binding(propertyName, dataSource, dataMember);
            if (converter != null)
                binding.Format += converter;
            control.DataBindings.Add(binding);
        }
    }
}
