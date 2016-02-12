using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class ReadMessage
    {
        [Key]
        public int ReadMessageID { get; set; }

        [Index("IX_MessageID", IsUnique = false)]
        public int MessageID { get; set; }

        public string Reader { get; set; }

        // Foreign keys
        public virtual Message Message { get; set; }
    }
}
