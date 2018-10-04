using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Unity;

namespace HCPService.UnityConfig
{
    public class RouteConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            config.DependencyResolver = new UnityResolver(container);

            //Registration to Unity Container call
            IoC.IocRegister(config);
        }
    }
}
