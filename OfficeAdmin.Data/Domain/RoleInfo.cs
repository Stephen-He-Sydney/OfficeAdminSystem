using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class RoleInfo
    {
        public RoleInfo()
        {
            this.RoleRights = new HashSet<RoleRight>();
            this.UserInfoes = new HashSet<UserInfo>();
        }

        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<RoleRight> RoleRights { get; set; }
        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}
