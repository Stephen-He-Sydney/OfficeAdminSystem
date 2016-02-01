using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class Message
    {
        public Message()
        {
            this.ReadMessages = new HashSet<ReadMessage>();
        }

        [Key]
        public int MessageID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int MessageTypeID { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int FromUserID { get; set; }
        public bool IsPublished { get; set; }
        public DateTime RecordTime { get; set; }

        // Foreign keys
        public virtual MessageType MessageType { get; set; }
        public virtual UserInfo UserInfo { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<ReadMessage> ReadMessages { get; set; }
    }
}
