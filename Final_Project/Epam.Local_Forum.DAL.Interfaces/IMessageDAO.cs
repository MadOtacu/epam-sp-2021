using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Local_Forum.Common.Entities;

namespace Epam.Local_Forum.DAL.Interfaces
{
    public interface IMessageDAO
    {
        void AddMessage(Message message);

        void DeleteMessage(Guid id);

        void EditMessage(Guid id, string newMessage);
    }
}
