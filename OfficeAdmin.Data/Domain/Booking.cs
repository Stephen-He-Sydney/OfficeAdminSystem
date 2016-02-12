using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Index("IX_ScheduleID", IsUnique = false)]
        public int ScheduleID { get; set; }

        [Index("IX_BookingMakerID", IsUnique = false)]
        public int BookingMakerID { get; set; }

        // Foreign keys
        public virtual Schedule Schedule { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
