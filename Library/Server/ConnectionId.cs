using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Server
{
    public struct ConnectionId
    {
        public Guid Id { get; private set; }
        public bool IsTemporary { get; set; }

        public ConnectionId(Guid id, bool isTemporary = true)
        {
            Id = id;
            IsTemporary = isTemporary;
        }

        /// <summary>
        /// Создает новый экземпляр подключения
        /// </summary>
        /// <param name="isTemporary">Определяет, является ли подключение временным</param>
        public ConnectionId(bool isTemporary = true)
            : this(Guid.NewGuid(), isTemporary)
        { }

        public static bool operator == (ConnectionId first, ConnectionId other)
        {
            return first.Id == other.Id;
        }

        public static bool operator !=(ConnectionId first, ConnectionId other)
        {
            return !(first.Id == other.Id);
        }

        public bool Equals(ConnectionId other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is ConnectionId))
                return false;
            return Equals((ConnectionId)obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
