using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Unity;
using HCPService.Interfaces;
using HCPService.Implementations;
using HCPService.UnityConfig;
using Unity.WebApi;

namespace HCPService.UnityConfig
{
    public class IoC
    {
        public static void IocRegister(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IHCPService, HCPServices>(new Unity.Lifetime.SingletonLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);
            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
