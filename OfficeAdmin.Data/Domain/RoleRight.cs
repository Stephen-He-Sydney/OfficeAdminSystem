using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class RoleRight
    {
        [Key]
        public int RoleRightID { get; set; }
        public int RoleID { get; set; }
        public int SysFuncID { get; set; }

        // Foreign keys
        public virtual RoleInfo RoleInfo { get; set; }
        public virtual SysFunc SysFunc { get; set; }
    }
}
