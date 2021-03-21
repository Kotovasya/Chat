using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    /// <summary>
    /// Класс, хранящий результат выполнения запроса клиента
    /// </summary>
    [DataContract]
    public class Response
    {
        /// <summary>
        /// Результат выполнения операции
        /// </summary>
        [DataMember]
        public Result Result { get; set; }
    }
}
