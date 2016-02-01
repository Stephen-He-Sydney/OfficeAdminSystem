using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class LoginLog
    {
        [Key]
        public int LoginLogID { get; set; }
        public int UserID { get; set; }
        public DateTime LoginTime { get; set; }
        public bool IsSuccess { get; set; }
        public string LoginIP { get; set; }
        public string LoginDesc { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; }
    }
}
