using System;
namespace SportsStore.Domain.Entities
{
	public class Product
	{
		public virtual int ProductID { get; set; }
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual decimal Price { get; set; }
		public virtual string Category { get; set; }
	}
}

