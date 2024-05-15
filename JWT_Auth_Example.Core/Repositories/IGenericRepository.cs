using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Core.Repositories
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		Task<TEntity> CreateAsync(TEntity entity);
		void Update(TEntity entity);
		void Delete(TEntity entity);
		Task<IEnumerable<TEntity>> GetAllAsync();
		Task<TEntity> GetByIdAsync(int id);

		IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
	}
}
