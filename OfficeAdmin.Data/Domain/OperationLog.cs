using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class OperationLog
    {
        [Key]
        public int OperationLogID { get; set; }

        [Index("IX_UserID", IsUnique = false)]
        public int UserID { get; set; }

        public string OperationName { get; set; }

        [Index("IX_SysFuncID", IsUnique = false)]
        public int SysFuncID { get; set; }

        public string OperationDesc { get; set; }

        [Index("IX_OperationTime", IsUnique = false)]
        public DateTime OperationTime { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; }

        public virtual SysFunc SysFunc { get; set; }
    }
}
