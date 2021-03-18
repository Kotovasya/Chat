using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Binding
{
    /// <summary>
    /// Интерфейс, определяющий возможность преобразования сущности в ее UI Control
    /// </summary>
    /// <typeparam name="U">Control, в который преобразовывается сущность</typeparam>
    public interface IToControl<out U>
        where U : UserControl
    {
        /// <summary>
        /// UI Control сущности
        /// </summary>
        U Control { get; }

        /// <summary>
        /// Преобразует сущность и возвращает ее UI Control
        /// </summary>
        /// <returns></returns>
        U ToControl();
    }
}
