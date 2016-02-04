using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class WorkTime
    {
        [Key]
        public int WorkTimeID { get; set; }
        public DateTime OnDutyTime { get; set; }
        public DateTime OffDutyTime { get; set; }
    }
}
