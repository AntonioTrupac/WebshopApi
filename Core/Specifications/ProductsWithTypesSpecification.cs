using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Models;

namespace Core.Specifications
{
	public class ProductsWithTypesSpecification : BaseSpecification<Product>
	{
		public ProductsWithTypesSpecification()
		{
			AddInclude(x => x.ProductType);
		}
	}
}