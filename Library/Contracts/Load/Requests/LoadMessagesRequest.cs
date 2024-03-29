﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Load
{
    /// <summary>
    /// Класс запроса для загрузки сообщений
    /// </summary>
    [DataContract]
    public class LoadMessagesRequest : Request
    {
        /// <summary>
        /// ID диалога, чьи сообщения будут загружаться
        /// </summary>
        [DataMember]
        public int DialogId { get; set; }

        /// <summary>
        /// Последнее сообщение, загруженное у пользователя
        /// </summary>
        [DataMember]
        public long? LastMessageId { get; set; }
    }
}
