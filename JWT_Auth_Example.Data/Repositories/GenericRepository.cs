using JWT_Auth_Example.Core.Repositories;
using JWT_Auth_Example.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JWT_Auth_Example.Data.Repositories
{
	public class GenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : class
	{

		protected readonly AuthContextDb _authContextDb;
		private readonly DbSet <Tentity> _dbSet;

		public GenericRepository(AuthContextDb authContextDb, DbSet<Tentity> dbSet)
		{
			_authContextDb = authContextDb;
			_dbSet = _authContextDb.Set<Tentity>();
		}

		public  async Task CreateAsync(Tentity entity)
		{
		     await	_dbSet.AddAsync(entity);
		}

		public void Delete(Tentity entity)
		{
			_dbSet.Remove(entity);
		}

		public async Task<IEnumerable<Tentity>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<Tentity> GetByIdAsync(int id)
		{
			var entity = await _dbSet.FindAsync(id);

			if (entity != null)
			{
				_authContextDb.Entry(entity).State = EntityState.Detached;
			}

			return entity;
		}


		public Tentity Update(Tentity entity)
		{
			_authContextDb.Entry(entity).State = EntityState.Modified;
			return entity;
		}

		public IQueryable<Tentity> Where(Expression<Func<Tentity, bool>> predicate)
		{
			return _dbSet.Where(predicate);
		}
	}
}
