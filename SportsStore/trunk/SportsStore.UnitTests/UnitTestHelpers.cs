using System;
using NUnit.Framework;
using SportsStore.Domain.Abstract;
using Moq;
using SportsStore.Domain.Entities;
using System.Linq;
namespace SportsStore.UnitTests
{
	public static class UnitTestHelpers 
	{
	
		public static void ShouldEqual<T>(this T actualValue, T expectedValue) 
		{
			Assert.AreEqual(expectedValue, actualValue);
		}
		
		public static IProductsRepository MockProductsRepository(params Product[] prods)
		{
			var mockProductsRepos = new Mock<IProductsRepository>();
			mockProductsRepos.Setup(x => x.Products).Returns(prods.AsQueryable());
			return mockProductsRepos.Object;
		}
	}
}

