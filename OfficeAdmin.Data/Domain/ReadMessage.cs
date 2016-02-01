using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class ReadMessage
    {
        [Key]
        public int ReadMessageID { get; set; }
        public int MessageID { get; set; }
        public string Reader { get; set; }

        // Foreign keys
        public virtual Message Message { get; set; }
    }
}
