using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Local_Forum.Common.Entities
{
    public class Message
    {
        public Message (string text)
        {
            ID = Guid.NewGuid();
            Text = text;
            SendTime = DateTime.Now;
        }

        public Guid ID { get; }

        public string Text { get; private set; }

        public DateTime SendTime { get; }

        public void EditMessage (string newText)
        {
            if (newText == null)
                throw new ArgumentNullException("str", "Text string can not be null!");

            Text = newText;
        }
    }
}
