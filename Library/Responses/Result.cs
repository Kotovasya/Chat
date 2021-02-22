using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.Responses
{

    [DataContract]
    public enum Result
    {
        [EnumMember]
        Succesfully = 1,
        
        [EnumMember]
        AlreadyRegister = 2,
        [EnumMember]
        AlreadyLogged = 4,

        [EnumMember]
        WrongLogin = 8,
        [EnumMember]
        WrongPassword = 16,
    
        [EnumMember]
        ServerException = 1024,
    }
}
