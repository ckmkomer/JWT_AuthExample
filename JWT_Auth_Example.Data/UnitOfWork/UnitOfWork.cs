using JWT_Auth_Example.Core.UnitOfWork;
using JWT_Auth_Example.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Auth_Example.Data.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AuthContextDb _authContext;

		public UnitOfWork(AuthContextDb authContext)
		{
			_authContext = authContext;
		}

		public  void Commit()
		{
		  	_authContext.SaveChanges();
		}

		public async Task CommitAsync()
		{
		 await	_authContext.SaveChangesAsync();
		}
	}
}
