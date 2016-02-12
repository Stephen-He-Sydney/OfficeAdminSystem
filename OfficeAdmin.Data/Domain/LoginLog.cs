using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class LoginLog
    {
        [Key]
        public int LoginLogID { get; set; }

        [Index("IX_UserID", IsUnique = false)]
        public int UserID { get; set; }

        [Index("IX_LoginTime", IsUnique = false)]
        public DateTime LoginTime { get; set; }

        public bool IsSuccess { get; set; }

        public string LoginIP { get; set; }

        public string LoginDesc { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; }
    }
}
