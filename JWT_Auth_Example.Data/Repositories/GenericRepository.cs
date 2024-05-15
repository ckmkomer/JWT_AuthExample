using JWT_Auth_Example.Core.Repositories;
using JWT_Auth_Example.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Data.Repositories
{
	public class GenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : class
	{

		private readonly AuthContextDb _authContextDb;
		private readonly DbSet <Tentity> _dbSet;

		public GenericRepository(AuthContextDb authContextDb, DbSet<Tentity> dbSet)
		{
			_authContextDb = authContextDb;
			_dbSet = _authContextDb.Set<Tentity>();
		}

		public  async Task<Tentity> CreateAsync(Tentity entity)
		{
		 return await_dbSet.Add(entity);
		}

		public void Delete(Tentity entity)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Tentity>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Tentity> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Tentity entity)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Tentity> Where(Expression<Func<Tentity, bool>> predicate)
		{
			throw new NotImplementedException();
		}
	}
}
