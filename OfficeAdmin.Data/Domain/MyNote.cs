using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class MyNote
    {
        [Key]
        public int NoteID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        [Index("IX_CreateTime", IsUnique = false)]
        public DateTime CreateTime { get; set; }

        [Index("IX_WriterID", IsUnique = false)]
        public int WriterID { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; } 
    }
}
