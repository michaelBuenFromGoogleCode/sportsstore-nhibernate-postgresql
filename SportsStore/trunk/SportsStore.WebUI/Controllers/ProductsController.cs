using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;


using SportsStore.Domain.Entities;

namespace SportsStore.WebUI
{
	public class ProductsController : Controller
	{
		private IProductsRepository _productsRepository;
		
		public int PageSize = 4;
		
		public ProductsController(IProductsRepository productsRepository)
		{
			_productsRepository = productsRepository;						
		}
		

		public ViewResult List(int page = 1)
		{
			return View(_productsRepository.Products.OrderBy(x => x.Description)
			            .Skip((page - 1) * PageSize)
			            .Take(PageSize).ToList());
		}
			
	}
}

