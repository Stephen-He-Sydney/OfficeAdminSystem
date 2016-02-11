using System.Data.Entity;

namespace OfficeAdmin.Data
{
    public class OfficeAdminContextCustomInitializer : IDatabaseInitializer<OfficeAdminContext>
    {
        public void InitializeDatabase(OfficeAdminContext context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
        }
    }
}
