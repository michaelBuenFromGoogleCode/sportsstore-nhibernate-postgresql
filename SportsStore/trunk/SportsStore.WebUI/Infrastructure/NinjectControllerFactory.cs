using System;
using Ninject;
using Ninject.Modules;

using System.Web.Routing;
using System.Web.Mvc;

using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;

using FluentNHibernate.Cfg;

using NHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.LowercaseSystem;


namespace SportsStore.WebUI
{
	public class NinjectControllerFactory : DefaultControllerFactory
	{
		private IKernel kernel = new StandardKernel(new SportsStoreServices());

		protected override IController GetControllerInstance(RequestContext context, Type controllerType)
		{
			if (controllerType == null) 
				return null;
			
			return (IController) kernel.Get(controllerType);
		}
		
		
		private class SportsStoreServices : NinjectModule
		{
			public override void Load ()
			{
				Bind<IProductsRepository>()
					.To<PgsProductsService>()
					.WithConstructorArgument("sf",SessionFactoryBuilder.GetSessionFactory<SportsStore.Domain.Mapping.ProductMap>());
			}
		}
	}
	
	
	public static class SessionFactoryBuilder
	{
		
 		static ISessionFactory _sf = null;
        public static ISessionFactory GetSessionFactory<T>()
        {
            // Building SessionFactory is costly, should be done only once, making the backing variable static would prevent creating multiple factory

            if (_sf != null) return _sf;

            _sf = Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard.ConnectionString("Server=localhost;Database=sports_store;User ID=postgres;Password=opensesame;"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>().Conventions.ForLowercaseSystem("_id"))
                .BuildSessionFactory();

            return _sf;
        }
	}
}

