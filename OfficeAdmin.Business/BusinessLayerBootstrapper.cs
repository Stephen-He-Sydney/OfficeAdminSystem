using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using OfficeAdmin.Business.Register;
using OfficeAdmin.Service;

namespace OfficeAdmin.Business
{
    public class BusinessLayerBootstrapper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            ServiceLayerBootstrapper.RegisterTypes(container);
            container.RegisterType<ISignUp, SignUp>();
        }
    }
}
