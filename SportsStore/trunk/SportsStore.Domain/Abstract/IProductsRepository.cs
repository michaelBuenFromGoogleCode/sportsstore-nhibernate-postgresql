using System;
using SportsStore.Domain.Entities;
using System.Collections.Generic;
using NHibernate;


using System.Linq;

namespace SportsStore.Domain.Abstract
{
	public interface IProductsRepository
	{
		IQueryable<Product> Products { get; }
	}
}

