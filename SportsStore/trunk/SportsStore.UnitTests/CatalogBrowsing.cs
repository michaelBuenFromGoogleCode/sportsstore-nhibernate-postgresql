using System;
using NUnit;
using NUnit.Framework;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI;
using System.Collections.Generic;

using WebHelpers.Extensions;
using System.Linq;

namespace SportsStore.UnitTests
{
	[TestFixture]
	public class CatalogBrowsing
	{
		[Test]
		public void Can_view_a_single_page_of_products()
		{
			// Arrange
			var repository = UnitTestHelpers.MockProductsRepository(
				new Product { Name = "P1" }, new Product { Name = "P2" },
				new Product { Name = "P3" }, new Product { Name = "P4" },
				new Product { Name = "P5" }
			);
			
			// Act
			var controller = new ProductsController(repository);
			controller.PageSize = 3;
			          
			var result = controller.List(2);
			
			// Assert 
			var displayedProducts = (IList<Product>)result.ViewData.Model;
			displayedProducts.Count.ShouldEqual(2);
			displayedProducts[0].Name.ShouldEqual("P4");
			displayedProducts[1].Name.ShouldEqual("P5");
		}
	}

    [TestFixture]
    public class Miscellaneous
    {
        [Test]
        public void Is_paging_logic_correct()
        {
            var p = new int[] { 1, 2, 3, 4, 5};

            var e = p.AsQueryable().LimitAndOffset(3, 2).ToArray();

            Assert.AreEqual(2, e.Count());
            Assert.AreEqual(4, e[0]);
            Assert.AreEqual(5, e[1]);
            
        }
    }

}

