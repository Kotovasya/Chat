using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    /// <summary>
    /// Абстрактный класс, служащий для наследования классов результатов выполнения операций
    /// </summary>
    [DataContract]
    public abstract class Response
    {
        /// <summary>
        /// Результат выполнения операции
        /// </summary>
        [DataMember]
        public Result Result { get; set; }
    }
}
