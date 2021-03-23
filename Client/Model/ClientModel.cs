using Client.Binding;
using Client.Entities;
using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Model
{
    /// <summary>
    /// Модель, служащая для хранения данных с сервера
    /// </summary>
    public class ClientModel : ServiceClient
    {
        /// <summary>
        /// Экземпляр объекта, принимающий данные с сервера
        /// </summary>
        private static readonly ClientCallbacks instance = new ClientCallbacks();
        /// <summary>
        /// Словарь, хранящий информацию о всех сообщениях
        /// </summary>
        public SourceList<int, Dialog> Dialogs { get; private set; }
        /// <summary>
        /// Словарь, хранящий информацию о всех пользователях
        /// </summary>
        public SourceList<Guid, User> Users { get; private set; }

        /// <summary>
        /// ID пользователя
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        public ClientModel() 
            : base(new InstanceContext(instance))
        {
            instance.Model = this;
            Dialogs = new SourceList<int, Dialog>();
            Users = new SourceList<Guid, User>();
            try
            {
                Id = Connect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ошибка подключения к серверу, пожалуйста, попробуй позже", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
