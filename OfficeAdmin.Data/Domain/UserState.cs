using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class UserState
    {
        public UserState()
        {
            this.UserInfoes = new HashSet<UserInfo>();
        }

        [Key]
        public int UserStateID { get; set; }
        public string UserStateName { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}
