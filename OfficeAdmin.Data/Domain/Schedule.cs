using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class Schedule
    {
        public Schedule()
        {
            this.Bookings = new HashSet<Booking>();
        }

        [Key]
        public int ScheduleID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Content { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsPrivate { get; set; }
        public int MeetingID { get; set; }

        // Foreign keys
        public virtual MeetingInfo MeetingInfo { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
