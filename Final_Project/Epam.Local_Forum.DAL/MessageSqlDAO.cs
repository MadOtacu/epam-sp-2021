using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Local_Forum.Common.Entities;
using Epam.Local_Forum.DAL.Interfaces;

namespace Epam.Local_Forum.DAL.DAL
{
    public class MessageSqlDAO : IMessageDAO
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        private static SqlConnection _connection = new SqlConnection(_connectionString);

        public void AddMessage (Message message)
        {
            DateTime creationDate = DateTime.Now;

            using (_connection)
            {
                var query = "INSERT INTO dbo.MessageList(Text, CreationDate) " +
                    "VALUES(@Text, @CreationDate); SELECT CAST(scope_identity() AS INT) AS NewID";

                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Text", message);
                command.Parameters.AddWithValue("@CreationDate", creationDate);

                _connection.Open();

                command.ExecuteScalar();
            }
        }

        public void DeleteMessage (Guid id)
        {

        }

        public void EditMessage (Guid id, string newMessage)
        {

        }
    }
}
