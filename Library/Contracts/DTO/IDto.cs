using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.DTO
{
    /// <summary>
    /// Определяет возможность преобразования объекта в Data Transfer Object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDto<out T>
    {
        /// <summary>
        /// Преобразует экземпляр класса в его экземпляр Data Transfer Object
        /// </summary>
        /// <returns></returns>
        T ToDto();
    }
}
