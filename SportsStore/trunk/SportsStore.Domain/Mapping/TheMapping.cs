using System;
using FluentNHibernate.Mapping;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Mapping
{
	public class ProductMap : ClassMap<Product>
	{
		public ProductMap ()
		{
			Table("products");
			
			Id(x => x.ProductID);
			
			Map(x => x.Name);
			Map(x => x.Description);
			Map(x => x.Price);
			Map(x => x.Category);
		}
	}
}

