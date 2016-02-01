using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class MessageType
    {
        public MessageType()
        {
            this.Messages = new HashSet<Message>();
        }

        [Key]
        public int MessageTypeID { get; set; }
        public string MessageTypeName { get; set; }
        public string MessageDesc { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<Message> Messages { get; set; }
    }
}
