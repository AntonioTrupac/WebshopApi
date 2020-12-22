using System.Linq;
using Core.Models;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
	public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
	{
		public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, 
			ISpecification<TEntity> specification)
		{
			var query = inputQuery;

			if (specification.Criteria != null)
			{
				query = query.Where(specification.Criteria); // ex. p => p.ProductTypeId === id
			}
			//taking include statements and aggregate them, then pass the into query, then its passed to list/method
			query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));

			return query;
		}
	}
}