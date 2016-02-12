using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class ManualSign
    {
        [Key]
        public int ManualSignID { get; set; }

        [Index("IX_SignTime", IsUnique = false)]
        public DateTime SignTime { get; set; }

        public string SignDesc { get; set; }

        public int SignTag { get; set; }

        [Index("IX_UserID", IsUnique = false)]
        public int UserID { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; }
    }
}
