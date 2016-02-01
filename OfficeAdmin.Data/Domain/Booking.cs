using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int ScheduleID { get; set; }
        public int BookingMakerID { get; set; }

        // Foreign keys
        public virtual Schedule Schedule { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
