﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Messaging
{
    /// <summary>
    /// Класс для отправки запроса на отправку сообщения
    /// </summary>
    [DataContract]
    public class SendMessageRequest : Request
    {
        /// <summary>
        /// Текст сообщения
        /// </summary>
        [DataMember]
        public string Text { get; set; }
    }
}
