using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class WorkTime
    {
        [Key]
        public int WorkTimeID { get; set; }

        [Index("IX_OnDutyTime", IsUnique = false)]
        public DateTime OnDutyTime { get; set; }

        [Index("IX_OffDutyTime", IsUnique = false)]
        public DateTime OffDutyTime { get; set; }
    }
}
