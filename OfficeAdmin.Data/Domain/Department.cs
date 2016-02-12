using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class Department
    {
        public Department()
        {
            this.UserInfoes = new HashSet<UserInfo>();
        }

        [Key]
        public int DeptID { get; set; }

        public string DeptName { get; set; }

        public string HomePhone { get; set; }

        public string Mobile { get; set; }

        public string Fax { get; set; }

        [Index("IX_BranchID", IsUnique = false)]
        public int BranchID { get; set; }

        // Foreign keys
        public virtual Branch Branch { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}
