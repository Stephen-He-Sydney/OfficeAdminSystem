using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class SysFunc
    {
        public SysFunc()
        {
            this.OperationLogs = new HashSet<OperationLog>();
            this.RoleRights = new HashSet<RoleRight>(); 
        }

        [Key]
        public int SysFuncID { get; set; }
        public string DisplayName { get; set; }
        public string NodeUrl { get; set; }
        public string DisplayOrder { get; set; }
        public int ParentID { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<OperationLog> OperationLogs { get; set; }
        public virtual ICollection<RoleRight> RoleRights { get; set; }
    }
}
