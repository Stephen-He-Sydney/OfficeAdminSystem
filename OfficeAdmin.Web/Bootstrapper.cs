using System.Web.Mvc;
using Microsoft.Practices.Unity;
using System.Web.Http;
using OfficeAdmin.Service;
using OfficeAdmin.Business;
using OfficeAdmin.Web.Controllers;
using OfficeAdmin.Web.Infrastructure;

namespace OfficeAdmin.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // register dependency resolver for WebAPI RC
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            // if you still use the beta version - change above line to:
            //GlobalConfiguration.Configuration.ServiceResolver.SetResolver(new Unity.WebApi.UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            

            //ServiceLayerBootstrapper.RegisterTypes(container);
            BusinessLayerBootstrapper.RegisterTypes(container);
           
            return container;
        }
    }
}