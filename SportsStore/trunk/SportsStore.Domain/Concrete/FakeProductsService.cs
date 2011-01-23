using SportsStore.Domain.Abstract;
using System.Linq;
using SportsStore.Domain.Entities;
using System.Collections.Generic;


namespace SportsStore.Domain.Concrete 
{
	public class FakeProductsRepository : IProductsRepository 
	{
		// Fake hard-coded list of products 
		private static IQueryable<Product> fakeProducts = new List<Product> {
			new Product { Name = "Football", Price = 25 }, new Product { Name = "Surf board", Price = 179 }, 
			new Product { Name = "Running shoes", Price = 95 }
			}.AsQueryable();
		
		public IQueryable<Product> Products 
		{
			get { return fakeProducts; }
		}
	}
}