using Library.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Load
{
    /// <summary>
    /// Класс, хранящий результат выполнения загрузки диалогов пользователя
    /// </summary>
    [DataContract]
    public class LoadDialogsResponse : Response
    {
        /// <summary>
        /// Загруженные диалоги
        /// </summary>
        [DataMember]
        public IEnumerable<DialogDto> Dialgos { get; set; }
    }
}
