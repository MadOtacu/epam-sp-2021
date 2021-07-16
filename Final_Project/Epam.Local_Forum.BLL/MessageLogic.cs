using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Local_Forum.DAL.DAL;
using Epam.Local_Forum.Common.Entities;
using Epam.Local_Forum.DAL.Interfaces;
using Epam.Local_Forum.BLL.Interfaces;

namespace Epam.Local_Forum.BLL.BLL
{
    public class MessageLogic : IMessageLogic
    {
        private IMessageDAO _messageDAO;

        public MessageLogic(IMessageDAO dao) =>
            _messageDAO = dao;

        public void AddMessage(Message message) =>
            _messageDAO.AddMessage(message);

        public void DeleteMessage(Guid id) =>
            _messageDAO.DeleteMessage(id);

        public void EditMessage(Guid id, string newMessage) =>
            _messageDAO.EditMessage(id, newMessage);
    }
}
