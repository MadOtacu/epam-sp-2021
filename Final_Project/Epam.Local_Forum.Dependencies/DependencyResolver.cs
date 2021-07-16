using Epam.Local_Forum.BLL.BLL;
using Epam.Local_Forum.BLL.Interfaces;
using Epam.Local_Forum.DAL.DAL;
using Epam.Local_Forum.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Local_Forum.Dependencies
{
    public class DependencyResolver
    {
        private static DependencyResolver _instance;

        public static DependencyResolver Instance => _instance ??= new DependencyResolver();

        public IMessageDAO MessageDAO => new MessageSqlDAO();

        public IMessageLogic MessageLogic => new MessageLogic(MessageDAO);
    }
}
