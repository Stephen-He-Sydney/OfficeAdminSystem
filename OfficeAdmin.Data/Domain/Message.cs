using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Index("IX_MessageTypeID", IsUnique = false)]
        public int MessageTypeID { get; set; }

        [Index("IX_BeginTime", IsUnique = false)]
        public DateTime BeginTime { get; set; }

        [Index("IX_EndTime", IsUnique = false)]
        public DateTime EndTime { get; set; }

        public int FromUserID { get; set; }

        public bool IsPublished { get; set; }

        [Index("IX_RecordTime", IsUnique = false)]
        public DateTime RecordTime { get; set; }

        // Foreign keys
        public virtual MessageType MessageType { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<ReadMessage> ReadMessages { get; set; }
    }
}
