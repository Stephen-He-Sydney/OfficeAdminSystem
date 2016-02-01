using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class MeetingInfo
    {
        public MeetingInfo()
        {
            this.Schedules = new HashSet<Schedule>();
        }

        [Key]
        public int MeetingID { get; set; }
        public string MeetingName { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
