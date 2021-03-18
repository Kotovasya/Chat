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
        /// <summary>
        /// Создает и добавляет к Control привязку данных
        /// </summary>
        /// <param name="control">Control, к которому создается привязка</param>
        /// <param name="propertyName">Название свойства Control'а, к которому создается привязка</param>
        /// <param name="dataSource">Объект, данные которого используются в привязке</param>
        /// <param name="dataMember">Название свойства объекта, откуда берутся данные</param>
        /// <param name="converter">Конвертер, необходимый для преобразования данных из источника</param>
        public static void CreateBinding(this Control control, string propertyName, object dataSource, string dataMember, ConvertEventHandler converter = null)
        {
            System.Windows.Forms.Binding binding = new System.Windows.Forms.Binding(propertyName, dataSource, dataMember);
            if (converter != null)
                binding.Format += converter;
            control.DataBindings.Add(binding);
        }
    }
}
