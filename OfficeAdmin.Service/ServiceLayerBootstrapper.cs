using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.Practices.Unity;
using OfficeAdmin.Data.Domain;
using OfficeAdmin.Service.Login;
using OfficeAdmin.Data;
using OfficeAdmin.Repository;

namespace OfficeAdmin.Service
{
    public class ServiceLayerBootstrapper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<DbContext, OfficeAdminContext>();

            container.RegisterType<IRepository<UserInfo>, EFRepository<UserInfo>>();
           
            container.RegisterType<ILoginService, LoginService>();
        }
    }
}
