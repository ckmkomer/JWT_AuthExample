using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Core.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> CreateAsync(T entity);
		void Update(T entity);
		void Delete(T entity);
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);

		IQueryable<T> Where(Expression<Func<T, bool>> predicate);
	}
}
