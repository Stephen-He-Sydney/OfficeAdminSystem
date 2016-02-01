using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class MyNote
    {
        [Key]
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public int WriterID { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; } 
    }
}
