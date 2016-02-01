using System;
using System.Data.Entity;
using OfficeAdmin.Data.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OfficeAdmin.Data
{
    public class OfficeAdminContext:DbContext
    {
        public OfficeAdminContext()
            : base("name=OfficeAdminContext")
        { 
        }

        public virtual DbSet<AccessoryFile> AccessoryFiles { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileType> FileTypes { get; set; }
        public virtual DbSet<LoginLog> LoginLogs { get; set; }
        public virtual DbSet<ManualSign> ManualSigns { get; set; }
        public virtual DbSet<MeetingInfo> MeetingInfoes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageToUser> MessageToUsers { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<MyNote> MyNotes { get; set; }
        public virtual DbSet<OperationLog> OperationLogs { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<ReadMessage> ReadMessages { get; set; }
        public virtual DbSet<RoleInfo> RoleInfoes { get; set; }
        public virtual DbSet<RoleRight> RoleRights { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<SysFunc> SysFuncs { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<UserState> UserStates { get; set; }
        public virtual DbSet<WorkTime> WorkTime { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Database.SetInitializer(new DropCreateDatabaseAlways<PersonalDemoContext>());

            Database.SetInitializer(new OfficeAdminContextCustomInitializer());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
