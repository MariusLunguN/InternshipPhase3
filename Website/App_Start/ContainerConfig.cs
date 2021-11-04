using Autofac;
using Autofac.Integration.Mvc;
using DataAccess.Services;
using System.Web.Http;
using System.Web.Mvc;

namespace Website
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SQLEmployeesData>().As<IEmployeeData>().InstancePerRequest();
            builder.RegisterType<InternshipPhase3DbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}