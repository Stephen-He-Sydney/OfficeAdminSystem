using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class RoleRight
    {
        [Key]
        public int RoleRightID { get; set; }

        [Index("IX_RoleID", IsUnique = false)]
        public int RoleID { get; set; }

        [Index("IX_SysFuncID", IsUnique = false)]
        public int SysFuncID { get; set; }

        // Foreign keys
        public virtual RoleInfo RoleInfo { get; set; }

        public virtual SysFunc SysFunc { get; set; }
    }
}
