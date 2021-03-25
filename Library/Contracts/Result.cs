using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    /// <summary>
    /// Содержит результаты выполнения операций
    /// </summary>
    [DataContract]
    public enum Result
    {
        /// <summary>
        /// Операция выполнена успешно
        /// </summary>
        [EnumMember]
        Succesfully = 1,
        
        /// <summary>
        /// Пользователя с таким именем уже зарегистрирован
        /// </summary>
        [EnumMember]
        AlreadyRegister = 2,
        /// <summary>
        /// Пользователь с таким именем уже авторизован
        /// </summary>
        [EnumMember]
        AlreadyLogged = 4,

        /// <summary>
        /// Неверное имя пользователя
        /// </summary>
        [EnumMember]
        WrongLogin = 8,
        /// <summary>
        /// Неверный пароль
        /// </summary>
        [EnumMember]
        WrongPassword = 16,

        /// <summary>
        /// Добавляемый пользователь уже есть в диалоге
        /// </summary>
        [EnumMember]
        UserAlreadyInDialog = 32,

        /// <summary>
        /// Недостаточно прав пользователя для выполнения запроса
        /// </summary>
        [EnumMember]
        NotPremissions = 64,

        /// <summary>
        /// Во время выполнения операции произошла ошибка
        /// </summary>
        [EnumMember]
        ServerException = 1024,
    }
}
