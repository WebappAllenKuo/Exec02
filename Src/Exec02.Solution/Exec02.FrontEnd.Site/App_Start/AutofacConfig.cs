using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Exec02.FrontEnd.Application.News;
using Exec02.FrontEnd.Domain.Interfaces;
using Exec02.FrontEnd.Domain.News;
using Exec02.FrontEnd.Infra.Data.EFModels;
using Exec02.FrontEnd.Infra.Data.Repositories;

namespace Exec02.FrontEnd.Site
{
	public class AutofacConfig
	{
		public static void Bootstrapper()
		{
			var builder = new ContainerBuilder();

			builder.RegisterControllers(Assembly.GetExecutingAssembly());

			builder.RegisterType<HotNewsApi>().AsSelf();
			builder.RegisterType<NewsService>().AsSelf();
			builder.RegisterType<NewsRepository>().As<INewsRepository>();
			builder.RegisterType<ErpDbContext>().AsSelf();
			
			builder.RegisterFilterProvider();

			IContainer container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}