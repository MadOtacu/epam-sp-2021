using Epam.Local_Forum.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Local_Forum.BLL.Interfaces
{
    public interface IMessageLogic
    {
        void AddMessage(Message message);

        void DeleteMessage(Guid id);

        void EditMessage(Guid id, string newMessage);
    }
}
