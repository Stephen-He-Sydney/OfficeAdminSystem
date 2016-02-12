using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class UserInfo
    {
        public UserInfo()
        {
            this.LoginLogs = new HashSet<LoginLog>();
            this.ManualSigns = new HashSet<ManualSign>();
            this.Messages = new HashSet<Message>();
            this.MyNotes = new HashSet<MyNote>();
            this.OperationLogs = new HashSet<OperationLog>();
            this.Bookings = new HashSet<Booking>();
        }

        public enum Genders
        {
            Male,
            Female,
            Unknown
        }

        [Key]
        public int UserID { get; set; }

        [MaxLength(500)]// 注册长度不得超过500
        [Index("IX_UserName", IsUnique = true)]
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }
        // the random secure number for hashing password

        public Genders Gender { get; set; }

        [Index("IX_RoleID", IsUnique = false)]
        public int RoleID { get; set; }

        public bool IsActive { get; set; }

        [Index("IX_DeptID", IsUnique = false)]
        public int DeptID { get; set; }

        // Foreign keys
        public virtual Department Department { get; set; }

        public virtual RoleInfo RoleInfo { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<LoginLog> LoginLogs { get; set; }

        public virtual ICollection<ManualSign> ManualSigns { get; set; }

        [ForeignKey("FromUserID")]
        public virtual ICollection<Message> Messages { get; set; }

        [ForeignKey("WriterID")]
        public virtual ICollection<MyNote> MyNotes { get; set; }

        public virtual ICollection<OperationLog> OperationLogs { get; set; }

        [ForeignKey("BookingMakerID")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
