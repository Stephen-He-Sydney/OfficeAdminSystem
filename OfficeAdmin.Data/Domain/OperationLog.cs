using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class OperationLog
    {
        [Key]
        public int OperationLogID { get; set; }
        public int UserID { get; set; }
        public string OperationName { get; set; }
        public int SysFuncID { get; set; }
        public string OperationDesc { get; set; }
        public DateTime OperationTime { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; }
        public virtual SysFunc SysFunc { get; set; }
    }
}
