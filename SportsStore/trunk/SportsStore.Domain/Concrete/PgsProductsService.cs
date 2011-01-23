using System;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;


using NHibernate.Linq;

using System.Linq;
using NHibernate;

namespace SportsStore.Domain.Concrete
{
	public class PgsProductsService : IProductsRepository
	{	

		
		private static ISessionFactory _sf;
		protected ISession _session;
		
		#region IProductsRepository implementation
		public IQueryable<Product> Products {
			get {
				return _sf.OpenSession().Query<Product>();
			}
		}
		#endregion

		/*
		public IList<Product> Products
		{
			get
			{
				ISession session = OpenSession();
				
				IQuery query = session.CreateQuery("from Product p order by p.Name");
				
				
				
				IList<Product> products = query.List<Product>();
				
				return products;
			}
		}*/
		
		
		
		
		
		public PgsProductsService(ISessionFactory sf)
		{
			_sf = sf;

			
		}
		
		/*
		// Implement interface...
		
		public ISession Session
		{
			get
			{
				return _session;
			}
		}// ISession get
		
		
		public void Dispose()
		{
			_session.Dispose();
		}
		*/
		
		// ..Implement interface	
		
		/*
		// implement interface...
		public ISession Session 
		{
			get
			{
				return OpenSession();
			}
		}
		
		
		
		public ISession OpenSession()
        {
            var c = new Configuration();
			
			
            // c.AddAssembly(Assembly.GetCallingAssembly());			
			// var x = Assembly.GetExecutingAssembly();			
			// var x = Assembly.GetAssembly(typeof(ProductsService));							
			// throw new Exception("T: " + x.ToString());			
			// c.Configure("/Users/Michael/Projects/SportsStore/SportsStore.Domain/bin/Debug/hibernate.cfg.xml");
			
			c.Configure();						
			c.AddAssembly(Assembly.GetExecutingAssembly());
			
            ISessionFactory f = c.BuildSessionFactory();
            return f.OpenSession();
        }
		
		// ...implement interface
		*/
 
	}
}

